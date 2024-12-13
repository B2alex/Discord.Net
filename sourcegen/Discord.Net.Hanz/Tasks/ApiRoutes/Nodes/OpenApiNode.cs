using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Models;

namespace Discord.Net.Hanz.Tasks.ApiRoutes.Nodes;

public class OpenApiNode : Node
{
    private static readonly Dictionary<string, string> NameFixes = new()
    {
        {"oauth2", "OAuth2"}
    };

    private record OpenApiPath(
        string Name,
        string SpecName,
        string Route,
        string? Parent,
        OpenApiPathItem Item
    )
    {
        public bool IsParameter => SpecName.StartsWith("{") && SpecName.EndsWith("}");
    }

    private record Target(
        OpenApiPath Path,
        ImmutableEquatableArray<OpenApiPath> Children,
        ImmutableEquatableArray<OpenApiPath> Ancestors)
    {
        public string? Parent => Path.Parent;
    }


    public OpenApiNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        var pathsProvider = GetNode<RouteMapperNode>()
            .IncludedRoutes
            .MapValues(Map);

        context
            .RegisterSourceOutput(
                pathsProvider
                    .MapValues((route, path) =>
                        new Target(
                            path,
                            pathsProvider.Values
                                .Where(x => x.Parent == route)
                                .ToImmutableEquatableArray(),
                            pathsProvider.Values
                                .Where(x => x.Route != route && route.StartsWith(x.Route))
                                .ToImmutableEquatableArray()
                        )
                    )
                    .JoinByKey(
                        GetNode<RouteMapperNode>().MappedTypes!,
                        (route, target, mapping) => (Target: target, Spec: CreateRouteSpec(target, mapping)),
                        allowDefault: true
                    )
                    .ValuesProvider
                    .Collect()
                    .Select(MapTypeNesting)
                    .Select((spec, token) => new SourceSpec(
                        "ApiRoutes/Generated",
                        "Discord",
                        new(["Discord", "Discord.Rest", "Discord.Models", "Discord.Models.Json"]),
                        new([spec])
                    ))
            );
    }

    private void AddRoutePathParameters(
        ref TypeSpec spec,
        IEnumerable<OpenApiParameter> routeParameters,
        string route,
        out ImmutableEquatableArray<(OpenApiParameter OpenApi, ParameterSpec Spec)> parameters,
        RouteMapperNode.ApiTypeMapping? mapping = null
    )
    {
        var pathParameters = new List<(OpenApiParameter, ParameterSpec)>();

        foreach (var pathParameter in routeParameters)
        {
            var type = pathParameter.Schema.Reference?.Id is "SnowflakeType"
                ? "ulong"
                : (mapping?.TryGetPathParameterType(pathParameter.Name, out var parameterType) ?? false)
                    ? parameterType.DisplayString
                    : pathParameter.Schema.Type switch
                    {
                        "string" => "string",
                        "integer" => "int",
                        _ => null
                    };

            if (type is null)
            {
                Logger.Warn(
                    $"Unable to map parameter {pathParameter.Name} in {route}: {pathParameter.Schema.Type}");
                Logger.Flush();

                continue;
            }

            pathParameters.Add(
                (
                    pathParameter,
                    new ParameterSpec(
                        type,
                        CultureInfo.CurrentCulture.TextInfo
                            .ToTitleCase(pathParameter.Name.Replace("_", " "))
                            .Replace(" ", "")
                            .ToParameterName()
                    )
                )
            );
        }

        parameters = pathParameters.ToImmutableEquatableArray();

        if (pathParameters.Count > 0)
            spec = spec with {Parameters = parameters.Select(x => x.Spec).ToImmutableEquatableArray()};
    }

    private void AddRoutePathParameters(
        ref TypeSpec spec,
        OpenApiPathItem item,
        string route,
        out ImmutableEquatableArray<(OpenApiParameter OpenApi, ParameterSpec Spec)> parameters,
        RouteMapperNode.ApiTypeMapping? mapping = null
    ) => AddRoutePathParameters(
        ref spec,
        item.Parameters.Where(x => x.In == ParameterLocation.Path),
        route,
        out parameters,
        mapping
    );

    private void AddBuildRouteMethod(
        ref TypeSpec spec,
        Target target,
        ImmutableEquatableArray<(OpenApiParameter OpenApi, ParameterSpec Spec)> parameters)
    {
        if (parameters.Count == 0)
            return;

        var routeInterpolation = target.Path.Route;

        foreach (var (openApiParameter, parameterSpec) in parameters)
        {
            routeInterpolation =
                routeInterpolation.Replace(openApiParameter.Name, $"@{FormatPathName(openApiParameter.Name)}");
        }

        spec = spec.AddMethods(
            new MethodSpec(
                "BuildRoute",
                "string",
                Accessibility.Public,
                Expression: $"$\"{routeInterpolation}\"",
                Modifiers: new(
                    target.Ancestors.Count > 0
                        ? ["override"]
                        : ["virtual"]
                )
            )
        );
    }

    private void CreateRouteOperationSpec(
        Target target,
        ref TypeSpec containerSpec,
        OperationType method,
        OpenApiOperation operation,
        ImmutableEquatableArray<(OpenApiParameter OpenApi, ParameterSpec Spec)> pathParameters,
        RouteMapperNode.ApiTypeMapping? mapping)
    {
        var specBase = $"{containerSpec.Name}{(
            pathParameters.Count > 0
                ? $"({string.Join(", ", pathParameters.Select(x => x.Spec.Name))})"
                : string.Empty
        )}";

        var operationParameters = new List<ParameterSpec>(pathParameters.Select(x => x.Spec));

        var operationSpec =
            new TypeSpec(
                method.ToString(),
                TypeKind.Class,
                Record: true,
                Bases: new([specBase, "IRouteOperation"]),
                Parameters: operationParameters.ToImmutableEquatableArray(),
                Properties: new([
                    new PropertySpec(
                        "string",
                        "OperationName",
                        Accessibility.Public,
                        Modifiers: new(["static"]),
                        EqualsClause: operation.OperationId.Quote()
                    ),
                    new PropertySpec(
                        "RequestMethod",
                        "Method",
                        Accessibility.Public,
                        Modifiers: new(["static"]),
                        EqualsClause: $"RequestMethod.{method.ToString()}"
                    ),
                    new PropertySpec(
                        "bool",
                        "RequiresBotToken",
                        Accessibility.Public,
                        Modifiers: new(["static"]),
                        EqualsClause: operation
                            .Security
                            .Any(x => x
                                .Keys
                                .Any(x => x.Name == "Authorization")
                            )
                            ? "true"
                            : "false"
                    )
                ])
            );

        var returnsSpec = new TypeSpec(
            "Returns",
            TypeKind.Class,
            Generics: new([
                "TBody"
            ]),
            Bases: new([
                "IRouteWithResponseBody<TBody>"
            ]),
            Parameters: operationParameters.ToImmutableEquatableArray()
        );

        var paramsSpec = new TypeSpec(
            "Params",
            TypeKind.Class,
            Generics: new([
                "TParams"
            ]),
            Bases: new([
                "IRouteWithRequestBody<TParams>"
            ]),
            Parameters: new([
                ..operationParameters,
                ("TParams", "args")
            ]),
            Properties: new([
                new PropertySpec(
                    "TParams",
                    "Body",
                    Accessibility.Public,
                    EqualsClause: "args"
                )
            ])
        );


        operationSpec = operationSpec.AddNestedTypes([
            returnsSpec
                .AddBaseClass(
                    $"{method.ToString()}({string.Join(", ", pathParameters.Select(x => x.Spec.Name))})"
                )
                .AddNestedType(
                    paramsSpec
                        .AddBaseClass(
                            $"Returns<TBody>({string.Join(", ", returnsSpec.Parameters.Select(x => x.Name))})")
                ),
            paramsSpec
                .AddBaseClass(
                    $"{method.ToString()}({string.Join(", ", pathParameters.Select(x => x.Spec.Name))})"
                )
                .AddNestedType(
                    returnsSpec
                        .AddBaseClass(
                            $"Params<TParams>({string.Join(", ", paramsSpec.Parameters.Select(x => x.Name))})")
                        .AddParameters(
                            ("TParams", "args")
                        )
                ),
        ]);


        // if (mapping is not null && mapping.TryGetRequestType(method, out var requestType))
        // {
        //     operationSpec = operationSpec.AddBases($"IRouteWithRequestBody<{requestType}>");
        //
        //     operationParameters.Add(
        //         new ParameterSpec(
        //             requestType.DisplayString,
        //             "body"
        //         )
        //     );
        //
        //     operationSpec = operationSpec
        //             .AddProperties(
        //                 new PropertySpec(
        //                     requestType.DisplayString,
        //                     "Body",
        //                     Accessibility.Public,
        //                     EqualsClause: "body"
        //                 )
        //             )
        //         with
        //         {
        //             Parameters = operationParameters.ToImmutableEquatableArray()
        //         };
        // }
        //
        // if (
        //     operation.Responses
        //         .FirstOrDefault(x => x
        //             .Value.Content.ContainsKey("application/json")
        //         ) is { } successResponse &&
        //     mapping is not null &&
        //     mapping.TryGetResponseType(method, successResponse.Key, out var responseType)
        // )
        // {
        //     operationSpec = operationSpec.AddBases($"IRouteWithResponseBody<{responseType}>");
        // }

        containerSpec = containerSpec.AddNestedType(operationSpec);
    }

    private TypeSpec CreateRouteSpec(Target target, RouteMapperNode.ApiTypeMapping? mapping)
    {
        using var logger = Logger.GetSubLogger(nameof(CreateRouteSpec))
            .GetSubLogger(target.Path.Route.Replace("/", "_"));

        var spec = new TypeSpec(
                target.Path.Name,
                TypeKind.Class,
                Modifiers: new(["abstract"]),
                Record: true
            )
            .AddBases("IRoute")
            .AddProperties([
                new PropertySpec(
                    "string",
                    "Path",
                    Accessibility.Public,
                    Modifiers: new([
                        "static",
                        ..target.Ancestors.Count > 0
                            ? (string[]) ["new"]
                            : []
                    ]),
                    EqualsClause: target.Path.Route.Quote()
                )
            ]);


        if (target.Ancestors.Count > 0)
            spec = spec.AddProperties(
                new PropertySpec(
                    "string",
                    "Path",
                    Modifiers: new(["static"]),
                    ExplicitInterfaceImplementation: "IRoute",
                    Expression: "Path"
                )
            );

        logger.Log($"Processing {target.Path.Name} ({target.Path.Route}), Mapping: {mapping}");

        AddRoutePathParameters(ref spec, target.Path.Item, target.Path.Route, out var pathParameters, mapping);

        AddBuildRouteMethod(ref spec, target, pathParameters);

        if (target.Path.IsParameter)
        {
            var paramName = target.Path.SpecName.Remove(0, 1).Remove(target.Path.SpecName.Length - 2, 1);
            var pathParameter = pathParameters
                .First(x => x.OpenApi.Name == paramName);

            spec = spec.AddProperties(
                new PropertySpec(
                    pathParameter.Spec.Type,
                    $"@{target.Path.Name}",
                    Accessibility.Public,
                    AutoSet: Accessibility.Public,
                    EqualsClause: pathParameter.Spec.Name,
                    Init: true
                )
            );
        }

        foreach (var kvp in target.Path.Item.Operations)
        {
            var method = kvp.Key;
            var operation = kvp.Value;

            CreateRouteOperationSpec(target, ref spec, method, operation, pathParameters, mapping);
        }

        return spec;
    }

    private TypeSpec MapTypeNesting(ImmutableArray<(Target Target, TypeSpec Spec)> targets, CancellationToken token)
    {
        var types = new Dictionary<string, TypeSpec>();
        var targetsTable = targets.ToDictionary(x => x.Target.Path.Route);

        using var logger = Logger.GetSubLogger(nameof(MapTypeNesting));

        var routesRootType = new TypeSpec(
            "Routes",
            TypeKind.Class,
            Modifiers: new(["partial"])
        );

        foreach
        (
            var kvp
            in targetsTable
                .OrderByDescending(x => x.Key.Count(x => x is '/'))
                .ThenBy(x => x.Key)
        )
        {
            var route = kvp.Key;
            var (target, spec) = kvp.Value;

            logger.Log($"Processing {route}: ");

            if (types.ContainsKey(route))
            {
                continue;
            }

            logger.Log(" - added to types table");
            types[route] = spec;

            // else if (!spec.Children.All(x => types[route].Children.Contains(x)))
            // {
            //     foreach (var child in spec.Children)
            //     {
            //         types[route] = types[route].AddOrReplaceNestedType(child);
            //         logger.Log($" - updated child {child.Name}");
            //     }
            // }

            if (target.Parent is null) continue;

            var parentParts = target.Parent.Split(['/'], StringSplitOptions.RemoveEmptyEntries);

            for (var i = parentParts.Length; i > 0; i--)
            {
                var parentPath = $"/{string.Join("/", parentParts.Take(i))}";

                if (!types.TryGetValue(parentPath, out var parentSpec))
                {
                    if (targetsTable.TryGetValue(parentPath, out var parent))
                    {
                        parentSpec = parent.Spec;
                    }
                    else
                    {
                        parentSpec = CreateContainerType(
                            parentPath,
                            parentParts.ElementAt(i - 1),
                            target
                        );
                    }
                }

                spec = types[parentPath] = parentSpec.AddOrReplaceNestedType(
                    spec.AddBaseClass($"{parentSpec.Name}{(
                        parentSpec.Parameters.Count > 0
                            ? $"({string.Join(", ", parentSpec.Parameters.Select(x => x.Name))})"
                            : string.Empty)}"
                    )
                );
            }
        }

        routesRootType = routesRootType.AddNestedTypes(
            types
                .Where(x => x.Key.Count(x => x is '/') == 1)
                .Select(x => x.Value)
        );

        return routesRootType;

        TypeSpec CreateContainerType(string route, string name, Target target)
        {
            var spec = new TypeSpec(
                FormatPathName(name),
                TypeKind.Class,
                Modifiers: new(["abstract"]),
                Record: true
            );

            AddRoutePathParameters(
                ref spec,
                target.Path.Item.Parameters.Where(x => x.In == ParameterLocation.Path && route.Contains(x.Name)),
                route,
                out var parameters
            );

            if (name.StartsWith("{"))
            {
                var paramName = name.Remove(0, 1).Remove(name.Length - 2, 1);
                var pathParameter =
                    parameters.First(x => x.OpenApi.Name == paramName);

                spec = spec.AddProperties(
                    new PropertySpec(
                        pathParameter.Spec.Type,
                        $"@{FormatPathName(name)}",
                        Accessibility.Public,
                        AutoSet: Accessibility.Public,
                        EqualsClause: pathParameter.Spec.Name,
                        Init: true
                    )
                );
            }

            return spec;
        }
    }

    private OpenApiPath Map(string route, OpenApiPathItem item)
    {
        var path = new List<string>(route.Split(['/'], StringSplitOptions.RemoveEmptyEntries));

        var parentParts = new List<string>(path.Take(path.Count - 1));

        var name = path.Last();
        var nameParts = name.Split(['.'], StringSplitOptions.RemoveEmptyEntries);

        if (nameParts.Length > 1)
        {
            parentParts.Add(string.Join(".", nameParts.Take(nameParts.Length - 1)));
            name = nameParts.Last();
        }

        var parent = parentParts.Count > 0
            ? $"{string.Join("/", parentParts)}"
            : null;

        return new(
            FormatPathName(name),
            name,
            route,
            parent,
            item
        );
    }

    private static string FormatPathName(string name)
    {
        name = name.Replace("@", "");

        if (name.StartsWith("{") && name.EndsWith("}"))
            name = name.Substring(1, name.Length - 2);

        if (NameFixes.TryGetValue(name, out var fix))
            return fix;

        var sb = new StringBuilder();

        for (var i = 0; i < name.Length; i++)
        {
            var ch = name[i];

            if (ch is '-' or '_')
                ch = ' ';

            if (i > 0 && name[i - 1] is '-' or '_')
                ch = char.ToUpperInvariant(ch);

            sb.Append(ch);
        }

        name = sb.ToString();

        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name).Replace(" ", "");
    }
}