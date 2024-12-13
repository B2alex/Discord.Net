using System.Collections.Immutable;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Tasks.ApiRoutes;
using Discord.Net.Hanz.Tasks.EntityProperties;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes.Modifiable;

public sealed class ModifiableTraitNode : TraitNode
{
    private record Context(
        string Target,
        string Parameters,
        string Route
    );

    private record ModifiableState(
        EntityPropertiesTask.EntityPropertiesWithInheritance Properties,
        RouteInfoGroup Route,
        ImmutableEquatableArray<TraitTargetAncestor> Ancestors
    );

    private readonly IncrementalKeyValueProvider<TraitImplementationTarget, ModifiableState> _stateProvider;

    public ModifiableTraitNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        _stateProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.ModifiableAttribute`1",
                (node, _) => node is InterfaceDeclarationSyntax,
                Map
            )
            .WhereNotNull()
            .DependsOn(GetTask<ApiRouteTask>().Routes)
            .DependsOn(GetTask<EntityPropertiesTask>().Properties)
            .KeyedBy(x => x.Target)
            .PairKeys(TargetsProvider)
            .TransformValuesVia(TargetAncestorsProvider)
            .MaybeMapValues((_, tuple) =>
            {
                var (context, ancestors) = tuple;

                if (!GetTask<ApiRouteTask>().Routes.TryGetValue(context.Route, out var route))
                    return default;

                if (!GetTask<EntityPropertiesTask>().PropertiesWithInherited
                        .TryGetValue(context.Parameters, out var properties))
                    return default;

                return new ModifiableState(
                    properties,
                    route,
                    ancestors
                ).Some();
            });

        context.RegisterSourceOutput(
            _stateProvider
                .MapValues(CreateImplementation)
                .Select((target, implementation) => new SourceSpec(
                    $"Modifiable/{target.Type.MetadataName}",
                    target.Type.Namespace!,
                    new(["Discord", "Discord.Models", "Discord.Rest", "Discord.Models.Json"]),
                    new([
                        implementation.ActorImplementation, implementation.EntityImplementation
                    ])
                ))
        );
    }

    private (TypeSpec ActorImplementation, TypeSpec EntityImplementation) CreateImplementation(
        TraitImplementationTarget target,
        ModifiableState state
    ) => (CreateActorImplementation(target, state), CreateEntityImplementation(target, state));

    private static string GetModifiableInterface(
        TraitImplementationTarget target,
        ModifiableState state
    ) => $"Discord.IModifiable<" +
         $"{target.Id}, " +
         $"{state.Properties.Source.Type}, " +
         $"{state.Properties.Source.ParamsType}, " +
         $"{target.Model}" +
         $">";

    private static string GetActorModifiableInterface(
        TraitImplementationTarget target,
        ModifiableState state
    ) => $"Discord.IModifiable<" +
         $"{target.Id}, " +
         $"{state.Properties.Source.Type}, " +
         $"{state.Properties.Source.ParamsType}, " +
         $"{target.Model}" +
         $">.Actor<{target.Type}, {target.Entity}>";

    private static string GetEntityModifiableInterface(
        TraitImplementationTarget target,
        ModifiableState state
    ) => $"Discord.IModifiable<" +
         $"{target.Id}, " +
         $"{state.Properties.Source.Type}, " +
         $"{state.Properties.Source.ParamsType}, " +
         $"{target.Model}" +
         $">.Entity<{target.Entity}>";

    private string FormatRouteInvocation(
        TraitImplementationTarget target,
        ModifiableState state)
    {
        return FormatRoute(
            state.Route.BestMatch(
                route =>
                [
                    RequestBodyMatches(route),
                    ResponseBodyMatches(route)
                ]
            )!
        );

        bool RequestBodyMatches(
            RouteInfo route
        )
        {
            if (route.RequestBody is null) return false;

            foreach (var generic in route.GenericParameters)
            {
                if (route.RequestBody.Equals(generic.Type))
                    return true;
            }

            foreach (var properties in state.Properties)
            {
                if (properties.ParamsType.Equals(route.RequestBody))
                    return true;
            }

            return false;
        }

        bool ResponseBodyMatches(
            RouteInfo route
        )
        {
            if (route.ResponseBody is null) return false;

            foreach (var generic in route.GenericParameters)
            {
                if (route.ResponseBody.Equals(generic.Type))
                    return true;
            }

            if (target.Model.Equals(route.ResponseBody))
                return true;

            foreach (var ancestor in state.Ancestors)
            {
                if (ancestor.Target.Model.Equals(route.RequestBody))
                    return true;
            }

            return false;
        }


        string FormatRoute(RouteInfo route)
        {
            var generics = new List<string>();

            foreach (var generic in route.GenericParameters)
            {
                if (generic.Type.Equals(route.RequestBody))
                {
                    generics.Add(state.Properties.Source.ParamsType.DisplayString);
                    continue;
                }

                if (generic.Type.Equals(route.ResponseBody))
                {
                    generics.Add(target.Model.DisplayString);
                    continue;
                }

                throw new InvalidOperationException($"Unresolvable generic \"{generic}\" in \"{route}\"");
            }

            return route.AsInvocation(
                parameter =>
                {
                    if (parameter.IsGeneric && parameter.Type.Equals(route.RequestBody))
                        return "args";

                    if (state.Properties.Any(x => parameter.Type.Equals(x.Type)))
                        return "args";

                    if (parameter.Heuristics.Count > 0)
                    {
                        foreach (var selfCheck in state.Ancestors.Select(x => x.Target).Prepend(target))
                        foreach (var heuristic in parameter.Heuristics)
                        {
                            if (selfCheck.Type.Equals(heuristic) || selfCheck.Entity.Equals(heuristic))
                                return "id";
                        }

                        return $"path.Require<{parameter.Heuristics[0]}>()";
                    }

                    return null;
                },
                generics
            );
        }
    }

    private TypeSpec CreateActorImplementation(
        TraitImplementationTarget target,
        ModifiableState state
    )
    {
        var actorModifiableInterface = GetActorModifiableInterface(target, state);
        var modifiableInterface = GetModifiableInterface(target, state);

        var modifiers = new List<string>(){"new"};
        
        if(HasChildren(target))
            modifiers.Insert(0, "virtual");
        
        return TypeSpec
            .From(target.Type)
            .AddModifiers("partial")
            .AddBases(actorModifiableInterface)
            .AddMethods([
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInOutRoute<{state.Properties.Source.ParamsType}, {target.Model}>",
                    Accessibility.Internal,
                    new([
                        "static",
                        ..modifiers
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    Expression: FormatRouteInvocation(target, state)
                ),
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInOutRoute<{state.Properties.Source.ParamsType}, {target.Model}>",
                    Modifiers: new([
                        "static"
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    ExplicitInterfaceImplementation: actorModifiableInterface,
                    Expression: "ModifyRoute(path, id, args)"
                ),
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInRoute<{state.Properties.Source.ParamsType}>",
                    Modifiers: new([
                        "static"
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    ExplicitInterfaceImplementation: GetModifiableInterface(target, state),
                    Expression: "ModifyRoute(path, id, args)"
                ),
                ..state.Ancestors
                    .Where(x => _stateProvider.ContainsKey(x.Target))
                    .Select(x =>
                    {
                        var ancestorState = _stateProvider.GetValue(x.Target);

                        return new MethodSpec(
                            "ModifyRoute",
                            $"IApiInOutRoute<{ancestorState.Properties.Source.ParamsType}, {x.Target.Model}>",
                            Modifiers: new([
                                "static"
                            ]),
                            ExplicitInterfaceImplementation: x.Target.Type.DisplayString,
                            Expression: "ModifyRoute(path, id, args)",
                            Parameters: new([
                                ("IPathable", "path"),
                                (x.Target.Id.DisplayString, "id"),
                                (ancestorState.Properties.Source.ParamsType.DisplayString, "args")
                            ])
                        );
                    })
            ]);
    }

    private TypeSpec CreateEntityImplementation(
        TraitImplementationTarget target,
        ModifiableState state
    )
    {
        var entityModifiableInterface = GetEntityModifiableInterface(target, state);
        var modifiableInterface = GetModifiableInterface(target, state);

        return TypeSpec
            .From(target.Entity)
            .AddModifiers("partial")
            .AddBases(entityModifiableInterface, modifiableInterface)
            .AddMethods([
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInOutRoute<{state.Properties.Source.ParamsType}, {target.Model}>",
                    Accessibility.Internal,
                    new([
                        "new",
                        "static"
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    Expression: FormatRouteInvocation(target, state)
                ),
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInOutRoute<{state.Properties.Source.ParamsType}, {target.Model}>",
                    Modifiers: new([
                        "static"
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    ExplicitInterfaceImplementation: entityModifiableInterface,
                    Expression: "ModifyRoute(path, id, args)"
                ),
                new MethodSpec(
                    "ModifyRoute",
                    $"IApiInRoute<{state.Properties.Source.ParamsType}>",
                    Modifiers: new([
                        "static"
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id"),
                        (state.Properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    ExplicitInterfaceImplementation: GetModifiableInterface(target, state),
                    Expression: "ModifyRoute(path, id, args)"
                ),
                ..state.Ancestors
                    .Where(x => _stateProvider.ContainsKey(x.Target))
                    .Select(x =>
                    {
                        var ancestorState = _stateProvider.GetValue(x.Target);

                        return new MethodSpec(
                            "ModifyRoute",
                            $"IApiInOutRoute<{ancestorState.Properties.Source.ParamsType}, {x.Target.Model}>",
                            Modifiers: new([
                                "static"
                            ]),
                            ExplicitInterfaceImplementation: x.Target.Type.DisplayString,
                            Expression: "ModifyRoute(path, id, args)",
                            Parameters: new([
                                ("IPathable", "path"),
                                (x.Target.Id.DisplayString, "id"),
                                (ancestorState.Properties.Source.ParamsType.DisplayString, "args")
                            ])
                        );
                    })
            ]);
    }

    private static Context? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.TargetNode is not InterfaceDeclarationSyntax syntax)
            return null;

        if (syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
            return null;

        if (context.Attributes.Length != 1)
            return null;

        var attribute = context.Attributes[0];

        if (attribute.AttributeClass?.TypeArguments.Length != 1)
            return null;

        if (attribute.ConstructorArguments.FirstOrDefault().Value is not string route)
            return null;

        return new(
            context.TargetSymbol.ToDisplayString(),
            attribute.AttributeClass.TypeArguments[0].ToDisplayString(),
            route
        );
    }
}