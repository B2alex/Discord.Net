using System.Collections.Immutable;
using System.Text;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Tasks.ApiRoutes;
using Discord.Net.Hanz.Tasks.EntityProperties;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes;

public sealed partial class CreatableTraitNode : TraitNode
{
    public enum CreatableKind
    {
        Link,
        Actor
    }

    public record CreatableTraitState(
        string Target,
        ImmutableEquatableArray<TraitDetails> Details
    );

    public record TraitDetails(
        RouteInfo Route,
        string MethodName,
        EntityPropertiesTask.EntityPropertiesWithInheritance? Properties,
        ImmutableEquatableArray<TypeRef> RouteGenerics,
        ImmutableEquatableArray<TraitImplementationTarget> FromBackLinks,
        string? IdPath,
        CreatableKind Kind
    );

    private record TraitAttributeDetails(
        string Route,
        string? MethodName,
        string? Properties,
        ImmutableEquatableArray<TypeRef> RouteGenerics,
        ImmutableEquatableArray<string> FromBackLinks,
        string? IdPath,
        CreatableKind Kind
    );

    private record TargetMapping(
        string Target,
        ImmutableEquatableArray<TraitAttributeDetails> Details
    );

    public IncrementalKeyValueProvider<TraitImplementationTarget, CreatableTraitState> State { get; }

    private IncrementalValuesProvider<TargetMapping> CreatableProvider { get; }

    public CreatableTraitNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        CreatableProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.CreatableAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                Map
            )
            .WhereNotNull()
            .Concat(
                context.SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.CreatableAttribute`1",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        Map
                    )
                    .WhereNotNull()
            )
            .Concat(
                context.SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.ActorCreatableAttribute`1",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        Map
                    )
                    .WhereNotNull()
            );

        State = CreatableProvider
            .DependsOn(GetTask<ApiRouteTask>(context).Routes)
            .DependsOn(GetTask<EntityPropertiesTask>(context).PropertiesWithInherited)
            .Select((mapping, _) =>
            {
                return (
                    Actor: mapping.Target,
                    Details: mapping
                        .Details
                        .Select(x =>
                            (
                                Detail: x,
                                Route: GetTask<ApiRouteTask>(context).Routes.GetValueOrDefault(x.Route),
                                FromBackLinks: x.FromBackLinks
                                    .Select(TargetsProvider.GetValueOrDefault)
                                    .Where(x => x is not null)!
                                    .ToImmutableEquatableArray<TraitImplementationTarget>(),
                                Properties: GetTask<EntityPropertiesTask>(context)
                                    .PropertiesWithInherited
                                    .GetValueOrDefault(x.Properties)
                            )
                        )
                        .Where(x =>
                            x.Route != default
                            &&
                            (
                                x.FromBackLinks.Count == 0 ||
                                x.FromBackLinks.All(x => x != default)
                            )
                            &&
                            x.Detail.Properties is null == (x.Properties == default)
                        )
                        .ToImmutableEquatableArray()
                );
            })
            .Where(x => x.Details.Count > 0)
            .KeyedBy(
                x => x.Actor,
                x => new CreatableTraitState(
                    x.Actor,
                    x.Details
                        .Select(tuple =>
                            new TraitDetails(
                                tuple.Route!.Routes.OrderBy(x => x.GenericParameters.Count - tuple.Detail.RouteGenerics.Count).First(),
                                tuple.Detail.MethodName ?? "CreateAsync",
                                tuple.Properties,
                                tuple.Detail.RouteGenerics,
                                tuple.FromBackLinks,
                                tuple.Detail.IdPath,
                                tuple.Detail.Kind
                            )
                        )
                        .ToImmutableEquatableArray()
                )
            )
            .PairKeys(TargetsProvider);

        context.RegisterSourceOutput(
            CreateImplementationsProvider()
                .MergeByKey(
                    CreateExtensionsProvider(),
                    (target, implementation, extension) => implementation.HasValue || extension.HasValue
                        ? new SourceSpec(
                            $"Creatable/{target.Type.MetadataName}",
                            target.Type.Namespace!,
                            new(["Discord", "Discord.Models"]),
                            new([
                                ..implementation.HasValue
                                    ? ImmutableArray.Create(implementation.Value)
                                    : ImmutableArray<TypeSpec>.Empty,
                                ..extension.HasValue
                                    ? ImmutableArray.Create(extension.Value)
                                    : ImmutableArray<TypeSpec>.Empty
                            ])
                        ).Some()
                        : default
                )
                .ValuesProvider
            );
    }


    private TargetMapping? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.SemanticModel.GetDeclaredSymbol(context.TargetNode) is not INamedTypeSymbol symbol)
            return null;

        var details = new List<TraitAttributeDetails>();
        
        foreach (var attribute in context.Attributes)
        {
            Logger.Log($"Processing attribute {attribute} on {symbol}");

            if (attribute.ConstructorArguments.Length == 0) continue;

            if (attribute.ConstructorArguments[0].Value is not string route)
                continue;

            if (attribute.AttributeClass is null) continue;

            CreatableKind? kind = attribute.AttributeClass?.Name switch
            {
                "ActorCreatableAttribute" => CreatableKind.Actor,
                "CreatableAttribute" => CreatableKind.Link,
                _ => null
            };

            if (kind is null) continue;

            var routeGenerics = new List<TypeRef>();

            var routeGenericsArg = attribute.NamedArguments
                .FirstOrDefault(x => x.Key == "RouteGenerics")
                .Value;

            if (routeGenericsArg.Kind is TypedConstantKind.Array)
            {
                routeGenerics.AddRange(
                    routeGenericsArg.Values
                        .Where(x => x.Value is ITypeSymbol)
                        .Select(x => new TypeRef((x.Value as ITypeSymbol)!))
                );
            }

            var backLinksValues = attribute.NamedArguments
                .FirstOrDefault(x => x.Key == "WhenBackLinkingFrom")
                .Value;

            var methodName = attribute.NamedArguments
                .FirstOrDefault(x => x.Key == "MethodName")
                .Value.Value as string;

            details.Add(
                new TraitAttributeDetails(
                    route,
                    methodName,
                    attribute.AttributeClass!.TypeArguments[0].ToDisplayString(),
                    routeGenerics.ToImmutableEquatableArray(),
                    backLinksValues.Kind is TypedConstantKind.Array
                        ? backLinksValues.Values
                            .Select(x => (x.Value as ITypeSymbol)?.ToDisplayString())
                            .Where(x => x is not null)!
                            .ToImmutableEquatableArray<string>()
                        : ImmutableEquatableArray<string>.Empty,
                    attribute.ConstructorArguments.Length == 3
                        ? attribute.ConstructorArguments[1].Value as string
                        : null,
                    kind.Value
                )
            );
        }

        if (details.Count == 0)
        {
            Logger.Log($"no details");
            return null;
        }

        foreach (var detail in details)
        {
            Logger.Log($" - {detail}");
            Logger.Log($" - {detail.FromBackLinks.Count} backlinks:");

            foreach (var backLink in detail.FromBackLinks)
            {
                Logger.Log($"   - {backLink}");
            }
        }

        return new(symbol.ToDisplayString(), details.ToImmutableEquatableArray());
    }
}