using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Tasks.ApiRoutes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes.Deletable;

public sealed class DeletableTraitNode : TraitNode
{
    public IncrementalKeyValueProvider<TraitImplementationTarget, RouteInfo> DeletableActors { get; }

    public DeletableTraitNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        DeletableActors = context.SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.DeletableAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                (string Actor, string Route)? (context, _) =>
                {
                    if (context.SemanticModel.GetDeclaredSymbol(context.TargetNode) is not INamedTypeSymbol symbol)
                        return null;

                    if (context.Attributes.Length != 1)
                        return null;

                    if (context.Attributes[0].ConstructorArguments.Length != 1 ||
                        context.Attributes[0].ConstructorArguments[0].Value is not string route)
                        return null;

                    return (
                        symbol.ToDisplayString(),
                        route
                    );
                }
            )
            .WhereNotNull()
            .KeyedBy(x => x.Actor, x => x.Route)
            .TransformKeyVia(TargetsProvider)
            .TransformValuesVia(GetTask<ApiRouteTask>().Routes)
            .MapValues((_, route) => route.Routes[0]);

        context.RegisterSourceOutput(
            DeletableActors
                .MapValues(CreateContainer)
                .Select(CreateImplementation)
        );
    }

    private static SourceSpec CreateImplementation(
        TraitImplementationTarget target,
        StatefulGeneration<RouteInfo> generation)
    {
        var (route, spec) = generation;

        var deletableInterface = $"Discord.IDeletable<{target.Id}, {target.Type}>";

        spec = spec
            .AddBases(
                deletableInterface
            )
            .AddMethods(
                new MethodSpec(
                    "DeleteRoute",
                    "IApiRoute",
                    Modifiers: new([
                        "static"
                    ]),
                    ExplicitInterfaceImplementation: deletableInterface,
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id")
                    ]),
                    Expression: route.AsInvocation(parameter =>
                    {
                        if (parameter.Type.Equals(target.Id))
                            return "id";

                        return parameter.Heuristics.Count > 0
                            ? $"path.Require<{parameter.Heuristics[0]}>()"
                            : null;
                    })
                )
            );

        return new SourceSpec(
            $"Deletable/{target.Type.MetadataName}",
            "Discord",
            Types: new([
                spec
            ])
        );
    }
}