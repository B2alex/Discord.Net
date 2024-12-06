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
        return State.MapValues(CreateImplementation);
    }

    private TypeSpec CreateImplementation(
        TraitImplementationTarget target,
        CreatableTraitState state
    )
    {
        var spec = TypeSpec.From(target.Type).AddModifiers("partial");
        
        foreach (var detail in state.Details)
        {
            ImplementDetails(ref spec, target, detail);
        }

        return spec;
    }

    private void ImplementDetails(ref TypeSpec spec, TraitImplementationTarget target, TraitDetails details)
    {
        if (details.Properties.HasValue)
        {
            ImplementCreatableWithProperties(ref spec, target, details, details.Properties.Value);
            return;
        }
    }

    private void ImplementCreatableWithProperties(
        ref TypeSpec spec,
        TraitImplementationTarget target,
        TraitDetails details,
        EntityPropertiesTask.EntityPropertiesWithInheritance properties)
    {
        var creatableInterface = $"Discord.ICreatable<" +
                                 $"{target.Type}, " +
                                 $"{target.Entity}, " +
                                 $"{target.Id}, " +
                                 $"{details.Properties.Value.Source.Type}, " +
                                 $"{details.Properties.Value.Source.ParamsType}, " +
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

        spec = spec
            .AddBases(creatableInterface)
            .AddMethods(
                new MethodSpec(
                    "CreateRoute",
                    $"IApiInOutRoute<{details.Properties.Value.Source.ParamsType}, {target.Model}>",
                    ExplicitInterfaceImplementation: creatableInterface,
                    Modifiers: new(["static"]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (details.Properties.Value.Source.ParamsType.DisplayString, "args")
                    ]),
                    Expression: routeExpression
                )
            );
    }
}