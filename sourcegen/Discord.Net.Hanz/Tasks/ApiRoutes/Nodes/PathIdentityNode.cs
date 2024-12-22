using System.Collections.Immutable;
using System.Text;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Tasks.Actors;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.ApiRoutes.Nodes;

public sealed class PathIdentityNode : Node
{
    private record Context(string Target, ImmutableEquatableArray<string> Types);

    public IncrementalValueProvider<ImmutableArray<Keyed<ActorInfo, ImmutableEquatableArray<string>>>> MappingProvider
    {
        get;
    }

    public PathIdentityNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        MappingProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.PathIdentityAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                Map
            )
            .WhereNotNull()
            .KeyedBy(x => x.Target, x => x.Types)
            .PairKeys(GetTask<ActorsTask>().ActorInfos)
            .EntriesProvider
            .Collect();

        context.RegisterSourceOutput(
            MappingProvider
                .Combine(GetNode<RouteMapperNode>().MapperProvider.Collect())
                .Select(CreateSpec)
        );
    }

    private SourceSpec CreateSpec(
        (ImmutableArray<Keyed<ActorInfo, ImmutableEquatableArray<string>>> Mapping,
            ImmutableArray<RouteMapperNode.Mapper> Mappers) tuple,
        CancellationToken token)
    {
        var (mapping, mappers) = tuple;

        var groups = mapping
            .SelectMany(x => x.Value.Select(y => (Type: y, Info: x.Key)))
            .GroupBy(x => x.Type);

        var caseBuilder = new StringBuilder();

        foreach (var group in groups)
        {
            var groupCases = group.Select(
                x =>
                {
                    var paramName = x.Info.Actor.Name.ToParameterName();

                    return
                        $$"""
                         case {{x.Info.Actor}} {{paramName}} when typeof(T) == typeof({{x.Info.Id}}):
                             {
                                var id = {{paramName}}.Id;
                                return Unsafe.As<{{x.Info.Id}}, T>(ref id);
                             }  
                         """;
                }
            );

            caseBuilder.AppendLine(
                $$"""
                  case {{group.Key}}:
                      switch(path)
                      {
                          {{
                              string.Join(Environment.NewLine, groupCases).WithNewlinePadding(4)
                          }}
                          default: break;
                      }
                      break;
                  """
            );
        }

        return new SourceSpec(
            "ApiRoutes/IRouteMapper.PathResolver",
            "Discord.Rest",
            Usings: new([
                "Discord.Rest",
                "System.Runtime.CompilerServices"
            ]),
            Types: new([
                new(
                    "IRouteMapper",
                    TypeKind.Interface,
                    Modifiers: new(["partial"]),
                    Methods: new([
                        new(
                            "ResolvePathParameter",
                            "T",
                            Accessibility.Internal,
                            new(["static"]),
                            Generics: new(["T"]),
                            Parameters: new([
                                ("IPathable", "path"),
                                ("PathParameterType", "type")
                            ]),
                            Body:
                            $$"""
                              switch(type)
                              {
                                  {{caseBuilder.ToString().WithNewlinePadding(4)}}
                                  default: break;
                              }

                              {{
                                  string.Join(
                                      Environment.NewLine,
                                      mappers
                                          .Where(x => x.HasResolver)
                                          .Select(x =>
                                              $"""
                                               if({x.Type}.TryResolvePathParameter<T>(path, type, out var parameter)) return parameter;
                                               """
                                          )
                                  )
                              }}

                              throw new InvalidOperationException("Unable to resolve path parameter.");
                              """
                        ),
                        new MethodSpec(
                            "TryResolvePathParameter",
                            "bool",
                            Accessibility.Internal,
                            new(["static virtual"]),
                            Parameters: new([
                                ("IPathable", "path"),
                                ("PathParameterType", "type"),
                                ("out T", "parameter")
                            ]),
                            Generics: new(["T"]),
                            Body:
                            """
                            parameter = default!;
                            return false;
                            """
                        )
                    ])
                )
            ])
        );
    }

    private Context? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.TargetNode is not InterfaceDeclarationSyntax)
            return null;

        if (context.TargetSymbol is not ITypeSymbol symbol)
            return null;

        if (context.Attributes.Length != 1)
            return null;

        var attribute = context.Attributes[0];
        
        if (attribute.ApplicationSyntaxReference is null)
            return null;

        if (attribute.ApplicationSyntaxReference.GetSyntax(token) is not AttributeSyntax
            {
                ArgumentList: not null
            } attributeSyntax)
            return null;

        var types = attributeSyntax.ArgumentList
            .Arguments
            .Select(x => x.ToString())
            .Where(x => x.StartsWith("PathParameterType."))
            .ToImmutableEquatableArray();

        Logger.Log($"{types.Count} types:");

        foreach (var type in types)
        {
            Logger.Log($" - {type}");
        }

        if (types.Count == 0)
            return null;

        return new(
            symbol.ToDisplayString(),
            types
        );
    }
}