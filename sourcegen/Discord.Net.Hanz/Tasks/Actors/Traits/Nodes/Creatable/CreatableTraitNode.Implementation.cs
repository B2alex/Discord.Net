using System.Collections.Immutable;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Tasks.EntityProperties;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes;

public sealed partial class CreatableTraitNode
{
    private IncrementalKeyValueProvider<TraitImplementationTarget, TypeSpec> CreateImplementationsProvider()
    {
        return State
            .JoinByKey(
                TargetAncestorsProvider!,
                CreateImplementation!
            );
    }

    private TypeSpec CreateImplementation(
        TraitImplementationTarget target,
        CreatableTraitState state,
        ImmutableEquatableArray<TraitTargetAncestor> ancestors)
    {
        var spec = TypeSpec.From(target.Type).AddModifiers("partial");

        foreach (var detail in state.Details)
        {
            ImplementDetails(ref spec, target, detail, ancestors);
        }

        return spec;
    }

    private void ImplementDetails(
        ref TypeSpec spec,
        TraitImplementationTarget target,
        TraitDetails details,
        ImmutableEquatableArray<TraitTargetAncestor> ancestors
    )
    {
        if (details.Properties.HasValue)
        {
            ImplementCreatableWithProperties(ref spec, target, details, details.Properties.Value, ancestors);
            return;
        }
    }

    private void ImplementCreatableWithProperties(
        ref TypeSpec spec,
        TraitImplementationTarget target,
        TraitDetails details,
        EntityPropertiesTask.EntityPropertiesWithInheritance properties,
        ImmutableEquatableArray<TraitTargetAncestor> ancestors)
    {
        var creatableInterface = $"Discord.ICreatable<" +
                                 $"{target.Type}, " +
                                 $"{target.Entity}, " +
                                 $"{target.Id}, " +
                                 $"{properties.Source.Type}, " +
                                 $"{properties.Source.ParamsType}, " +
                                 $"{target.Model}>";

        var extraParameters = new List<RouteParameter>();

        var routeExpression = details.Route
            .AsInvocation(
                parameter =>
                {
                    if (parameter.Heuristics.Count > 0)
                        return $"path.Require<{parameter.Heuristics[0]}>()";

                    if (parameter.Name is "id")
                        return $"path.Require<{target.Entity}>()";

                    if (parameter.Type.Equals(properties.Source.ParamsType))
                        return "args";

                    extraParameters.Add(parameter);
                    return null;
                },
                details.RouteGenerics.Select(x => x.DisplayString)
            );

        var modifiers = new List<string>(){"new"};
        
        if(HasChildren(target))
            modifiers.Insert(0, "virtual");
        
        spec = spec
            .AddBases(creatableInterface)
            .AddMethods([
                new MethodSpec(
                    "CreateRoute",
                    $"IApiInOutRoute<{properties.Source.ParamsType}, {target.Model}>",
                    Accessibility: Accessibility.Internal,
                    Modifiers: new([
                        "static",
                        ..modifiers,
                    ]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    Expression: routeExpression
                ),
                new MethodSpec(
                    "CreateRoute",
                    $"IApiInOutRoute<{properties.Source.ParamsType}, {target.Model}>",
                    ExplicitInterfaceImplementation: creatableInterface,
                    Modifiers: new(["static"]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (properties.Source.ParamsType.DisplayString, "args")
                    ]),
                    Expression: "CreateRoute(path, args)"
                ),
                ..ancestors
                    .Where(x => State.ContainsKey(x.Target))
                    .SelectMany(ancestor => State.GetValue(ancestor.Target)
                        .Details
                        .Where(x => x.Route.Equals(details.Route) && x.Properties.HasValue)
                        .Select(x =>
                            new MethodSpec(
                                "CreateRoute",
                                $"IApiInOutRoute<{x.Properties!.Value.Source.ParamsType}, {ancestor.Target.Model}>",
                                ExplicitInterfaceImplementation: ancestor.Target.Type.DisplayString,
                                Modifiers: new(["static"]),
                                Parameters: new([
                                    ("IPathable", "path"),
                                    (x.Properties!.Value.Source.ParamsType.DisplayString, "args")
                                ]),
                                Expression: "CreateRoute(path, args)"
                            )
                        )
                    )
            ]);
    }
}