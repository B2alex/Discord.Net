using System.Collections.Immutable;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.ApiRoutes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes.Fetchable;

using PartialFetchableDetails = (
    FetchableTraitNode.Kind Kind,
    string Route,
    TypeRef? PageParams,
    TypeRef? ApiType,
    TypeRef? PagedEntity
    );

public sealed partial class FetchableTraitNode : TraitNode
{
    public enum Kind
    {
        Fetchable,
        FetchableOfMany,
        PagedFetchableOfMany
    }

    public readonly record struct FetchableDetails(
        Kind Kind,
        RouteInfo Route,
        TypeRef? PageParams = null,
        TypeRef? ApiType = null,
        TypeRef? PagedEntity = null
    );

    private readonly record struct PartialFetchableTarget(
        string Target,
        ImmutableEquatableArray<PartialFetchableDetails> Details
    );

    public IncrementalGroupingProvider<TraitImplementationTarget, FetchableDetails> FetchableProvider { get; }

    public FetchableTraitNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        FetchableProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.FetchableAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                MapTarget
            )
            .WhereNotNull()
            .Collect()
            .Combine(
                context
                    .SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.FetchableOfManyAttribute",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        MapTarget
                    )
                    .WhereNotNull()
                    .Collect()
            )
            .Combine(
                context
                    .SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.PagedFetchableOfManyAttribute`1",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        MapTarget
                    )
                    .WhereNotNull()
                    .Collect()
            )
            .Combine(
                context
                    .SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.PagedFetchableOfManyAttribute`2",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        MapTarget
                    )
                    .WhereNotNull()
                    .Collect()
            )
            .SelectMany(IEnumerable<PartialFetchableTarget> (x, _) =>
                [..x.Left.Left.Left, ..x.Left.Left.Right, ..x.Left.Right, ..x.Right]
            )
            .DependsOn(GetTask<ApiRouteTask>().Routes)
            .GroupManyBy(
                x => x.Target,
                x => x.Details
                    .Where(x => GetTask<ApiRouteTask>().Routes.ContainsKey(x.Route))
                    .Select(details =>
                        new FetchableDetails(
                            details.Kind,
                            GetTask<ApiRouteTask>()
                                .Routes
                                .GetValue(details.Route)
                                .Routes[0],
                            details.PageParams,
                            details.ApiType,
                            details.PagedEntity
                        )
                    )
            )
            .TransformKeysVia(TargetsProvider);
            

        CreateImplementation(context);
    }

    private PartialFetchableTarget? MapTarget(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (
            context.SemanticModel.GetDeclaredSymbol(context.TargetNode)
            is not INamedTypeSymbol symbol
        ) return null;

        var details = context.Attributes
            .Select(x => MapDetails(symbol, x))
            .Where(x => x.HasValue)
            .Select(x => x.Value)
            .ToImmutableEquatableArray();

        if (details.Count == 0) return null;
        
        Logger.Log($"{details.Count} details:");

        foreach (var detail in details)
        {
            Logger.Log($"{detail.Kind}: {detail.Route}");
        }

        return new(symbol.ToDisplayString(), details);
    }

    private PartialFetchableDetails? MapDetails(INamedTypeSymbol symbol, AttributeData attribute)
    {
        if (attribute.AttributeClass?.TypeArguments.Length == 0)
            return null;

        var route = attribute.AttributeClass!.TypeArguments[0].Name;

        Kind? kind = attribute.AttributeClass?.Name switch
        {
            "FetchableAttribute" => Kind.Fetchable,
            "FetchableOfManyAttribute" => Kind.FetchableOfMany,
            "PagedFetchableOfManyAttribute" => Kind.PagedFetchableOfMany,
            _ => null
        };

        if (kind is null) return null;

        TypeRef? paramsType = null;
        TypeRef? apiType = null;
        TypeRef? pagedType = null;

        if (
            attribute.AttributeClass?.TypeArguments.Length > 1 &&
            !TryExtractParamsTypeInfo(attribute.AttributeClass.TypeArguments[1], out paramsType, out apiType)
        ) return null;

        pagedType = attribute.AttributeClass?.TypeArguments.Length > 2
            ? new TypeRef(attribute.AttributeClass.TypeArguments[2])
            : null;

        return (kind.Value, route, paramsType, apiType, pagedType);
    }

    private bool TryExtractParamsTypeInfo(ITypeSymbol symbol, out TypeRef paramsType, out TypeRef apiType)
    {
        paramsType = null!;
        apiType = null!;

        var pagingParamsInterface =
            symbol.AllInterfaces.FirstOrDefault(x => x is {Name: "IPagingParams", TypeArguments.Length: 2});

        if (pagingParamsInterface is null)
            return false;

        paramsType = new(symbol);
        apiType = new(pagingParamsInterface.TypeArguments[1]);
        return true;
    }
}