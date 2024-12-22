using System.Collections.Immutable;
using System.Globalization;
using System.Net;
using System.Reflection.Metadata;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.OpenApi.Models;

namespace Discord.Net.Hanz.Tasks.ApiRoutes.Nodes;

public class RouteMapperNode : Node
{
    public record RequiredType(
        string Name,
        string Route
    );

    public record PathParameterRequiredType(
        string Name,
        string ParameterName,
        string Route
    ) : RequiredType(Name, Route);

    public record MediaRequiredType(
        string Name,
        string Route,
        OperationType OperationType
    ) : RequiredType(Name, Route);

    private record RequestRequiredType(
        string Name,
        string Route,
        OperationType OperationType
    ) : MediaRequiredType(Name, Route, OperationType);

    private record ResponseRequiredType(
        string Name,
        string Route,
        OperationType OperationType,
        string Code
    ) : MediaRequiredType(Name, Route, OperationType);

    public record Mapper(
        TypeRef Type,
        ImmutableEquatableArray<TypeMapping> Mappings,
        ImmutableEquatableArray<string> IgnoredRoutes,
        bool HasResolver
    );

    public record TypeMapping(string Name, TypeRef Type);

    public record ApiTypeMapping(
        string Route,
        ImmutableEquatableArray<(OperationType? Operation, string? Code, string? ParameterName, TypeRef Type)>
            MappedTypes
    )
    {
        public bool TryGetPathParameterType(string name, out TypeRef type)
            => (
                type = MappedTypes.FirstOrDefault(x =>
                    x.Operation is null && x.ParameterName == name
                ).Type
            ) is not null;

        public bool TryGetRequestType(OperationType operation, out TypeRef type)
            => (
                type = MappedTypes.FirstOrDefault(x =>
                    x.Operation == operation &&
                    x.Code is null
                ).Type
            ) is not null;

        public bool TryGetResponseType(OperationType operation, string code, out TypeRef type)
            => (
                type = MappedTypes.FirstOrDefault(x =>
                    x.Operation == operation &&
                    x.Code == code
                ).Type
            ) is not null;
    }

    public IncrementalKeyValueProvider<string, OpenApiPathItem> IncludedRoutes { get; }

    public IncrementalGroupingProvider<string, RequiredType> RouteTypes { get; }
    public IncrementalValuesProvider<Mapper> MapperProvider { get; }
    public IncrementalKeyValueProvider<string, ApiTypeMapping> MappedTypes { get; }

    public RouteMapperNode(
        IncrementalGeneratorInitializationContext context,
        ILogger logger
    ) : base(context, logger)
    {
        MapperProvider = context
            .SyntaxProvider
            .CreateSyntaxProvider(
                (node, _) => node is ClassDeclarationSyntax,
                (context, _) =>
                {
                    if (context.Node is not ClassDeclarationSyntax {BaseList: not null} classDeclarationSyntax)
                        return null;

                    if (context.SemanticModel.GetDeclaredSymbol(classDeclarationSyntax) is not INamedTypeSymbol symbol)
                        return null;

                    if (!symbol.Interfaces.Any(x => x.Name is "IRouteMapper"))
                        return null;

                    var ignoredRoutesSyntax = classDeclarationSyntax.Members
                        .OfType<PropertyDeclarationSyntax>()
                        .FirstOrDefault(x => x.Identifier.ValueText == "IgnoredRoutes");

                    var ignoredRoutes = ImmutableEquatableArray<string>.Empty;

                    if (ignoredRoutesSyntax?.ExpressionBody?.Expression is CollectionExpressionSyntax ignoredCollection)
                    {
                        ignoredRoutes = ignoredCollection.Elements
                            .OfType<ExpressionElementSyntax>()
                            .Where(x => x.Expression is LiteralExpressionSyntax)
                            .Select(x => ((LiteralExpressionSyntax) x.Expression).Token.ValueText)
                            .ToImmutableEquatableArray();
                    }

                    return new Mapper(
                        new(symbol),
                        ImmutableEquatableArray<TypeMapping>.Empty,
                        ignoredRoutes,
                        symbol.GetMembers().Any(x => x.Name is "TryResolvePathParameter")
                    );
                }
            )
            .WhereNotNull();

        IncludedRoutes = GetTask<ApiRouteGenerator>()
            .PathsProvider
            .EntriesProvider
            .Combine(MapperProvider.Collect())
            .Where(x => x.Right.All(y => !y.IgnoredRoutes.Contains(x.Left.Key)))
            .ToKeyed(x => (x.Left.Key, x.Left.Value));

        var pathParameterNames = IncludedRoutes
            .EntriesProvider
            .SelectMany((kvp, _) =>
            {
                return kvp
                    .Value
                    .Parameters
                    .Where(x => x.In is ParameterLocation.Path)
                    .Select(x => (Name: OpenApiNode.FormatPathName(x.Name), Route: kvp.Key));
            })
            .Collect();

        RouteTypes = IncludedRoutes
            .EntriesProvider
            .SelectMany((tuple, token) =>
            {
                var (route, item) = tuple;
                return GetRequiredTypes(route, item);
            })
            .GroupBy(x => x.Route);

        MappedTypes = RouteTypes
            .EntriesProvider
            .Combine(MapperProvider.Collect())
            .MaybeSelect(tuple =>
            {
                var ((route, type), mappers) = tuple;

                foreach (var mapper in mappers)
                {
                    var mappedType = mapper.Mappings.FirstOrDefault(x => x.Name == type.Name);

                    if (mappedType is not null)
                    {
                        Logger.Log($" - {type.Name}: {mappedType}");
                        Logger.Flush();
                        return (
                            Route: route,
                            Method: type is MediaRequiredType media ? media.OperationType : (OperationType?) null,
                            Code: type is ResponseRequiredType resp ? resp.Code : null,
                            Parameter: type is PathParameterRequiredType path ? path.ParameterName : null,
                            Type: mappedType.Type
                        ).Some();
                    }
                }

                return default;
            })
            .GroupBy(x => x.Route)
            .ToKeyed((route, mappings) =>
                new ApiTypeMapping(
                    route,
                    mappings.Select(x => (x.Method, x.Code, x.Parameter, x.Type)).ToImmutableEquatableArray()
                )
            );

        context.RegisterSourceOutput(
            pathParameterNames,
            (context, names) =>
            {
                context.AddSource(
                    "ApiRoutes/PathParametersTypes",
                    $$"""
                      namespace Discord.Rest;

                      public enum PathParameterType
                      {
                          {{
                              string.Join(
                                      $",{Environment.NewLine}",
                                      names
                                          .GroupBy(x => x.Name)
                                          .Select(group =>
                                              $"""
                                               /// <summary>
                                               ///    The <c>{group.Key}</c> parameter, used in the following routes:
                                               ///    <list type="bullet">
                                               ///      {
                                                   string.Join(
                                                       $"{Environment.NewLine}///      ",
                                                       group.Select(x => $"<item><term>{x.Route}</term></item>")
                                                   )
                                               }
                                               ///    </list>
                                               /// </summary>
                                               {group.Key}
                                               """
                                          )
                                  )
                                  .WithNewlinePadding(4)
                          }}
                      }
                      """
                );
            }
        );

        context
            .RegisterSourceOutput(
                RouteTypes
                    .ValuesProvider
                    .Collect()
                    .Select(CreateSourceSpec)
            );
    }

    private SourceSpec CreateSourceSpec(ImmutableArray<RequiredType> requiredTypes, CancellationToken token)
    {
        return new SourceSpec(
            "ApiRoutes/IRouteMapper",
            "Discord.Rest",
            Types: new([
                new TypeSpec(
                    "IRouteMapper",
                    TypeKind.Interface,
                    Modifiers: new(["partial"]),
                    Properties: new([
                        new PropertySpec(
                            "IEnumerable<string>",
                            "IgnoredRoutes",
                            Expression: "[]"
                        ),
                        // ..requiredTypes
                        //     .OrderBy(x => x.Name)
                        //     .Select(x =>
                        //         new PropertySpec(
                        //             "Type",
                        //             x.Name
                        //         )
                        //     )
                        //     .Distinct()
                    ])
                )
            ])
        );
    }

    private IEnumerable<RequiredType> GetRequiredTypes(string route, OpenApiPathItem item)
    {
        foreach (var pathParameter in item.Parameters.Where(x => x.In == ParameterLocation.Path))
        {
            if (pathParameter.Schema.Type is "string" or "integer" ||
                pathParameter.Schema.Reference?.Id is "SnowflakeType")
                continue;

            var typeName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                pathParameter.Name.Replace("_", " ")
            ).Replace(" ", "");

            yield return new PathParameterRequiredType(
                pathParameter.Schema.Reference?.Id ?? $"{typeName}PathType",
                pathParameter.Name,
                route
            );
        }

        foreach (var operation in item.Operations)
        {
            var typeName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                operation.Value.OperationId.Replace("_", " ")
            ).Replace(" ", "");

            if (operation.Value.RequestBody?.Content.TryGetValue("application/json", out var media) ?? false)
            {
                yield return new RequestRequiredType(
                    media.Schema.Reference?.Id ?? $"{typeName}RequestModel",
                    route,
                    operation.Key
                );
            }

            foreach (var response in operation.Value.Responses)
            {
                if (!response.Value.Content.TryGetValue("application/json", out var jsonModel))
                    continue;

                yield return new ResponseRequiredType(
                    jsonModel.Schema.Reference?.Id ?? $"{typeName}{response.Key}ResponseModel",
                    route,
                    operation.Key,
                    response.Key
                );
            }
        }
    }
}