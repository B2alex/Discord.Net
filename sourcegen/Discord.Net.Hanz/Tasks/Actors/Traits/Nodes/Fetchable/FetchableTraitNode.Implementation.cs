using System.Collections.Immutable;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes.Fetchable;

public sealed partial class FetchableTraitNode
{
    private void CreateImplementation(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(
            FetchableProvider
                .MapValues(CreateContainer)
                .MapValues(ImplementFetchableDetails)
                .Select(ToSourceSpec)
        );
    }

    private SourceSpec ToSourceSpec(TraitImplementationTarget target, StatefulGeneration<FetchableDetails> generation)
    {
        return new(
            $"{generation.State.Kind}/{target.Type.MetadataName}_{generation.State.Route.Name}",
            "Discord",
            new(["Discord", "Discord.Rest"]),
            new([generation.Spec])
        );
    }

    private StatefulGeneration<FetchableDetails> ImplementFetchableDetails(
        TraitImplementationTarget target,
        StatefulGeneration<FetchableDetails> generation)
    {
        Logger.Log($"Implementing {generation.State.Kind}...");

        var spec = generation.Spec;

        switch (generation.State.Kind)
        {
            case Kind.Fetchable:
                ImplementSimpleFetchable(target, generation.State, ref spec);
                break;
            case Kind.FetchableOfMany:
                ImplementFetchableOfMany(target, generation.State, ref spec);
                break;
            case Kind.PagedFetchableOfMany:
                ImplementPagedFetchableOfMany(target, generation.State, ref spec);
                break;
        }

        Logger.Log($"Spec:\n{spec}");

        return generation with {Spec = spec};
    }

    private void ImplementPagedFetchableOfMany(
        TraitImplementationTarget target,
        FetchableDetails details,
        ref TypeSpec spec
    )
    {
        if (details.PageParams is null || details.ApiType is null)
            return;

        var fetchableInterface =
            $"Discord.IPagedFetchableOfMany<{target.Id}, {target.Model}, {details.PageParams}, {details.ApiType}>";

        spec = spec.AddBases(fetchableInterface);
    }

    public void ImplementFetchableOfMany(
        TraitImplementationTarget target,
        FetchableDetails details,
        ref TypeSpec spec
    )
    {
        var fetchableInterface = $"Discord.IFetchableOfMany<{target.Id}, {target.Model}>";

        var routeInvocation = details.Route.AsInvocation(x =>
        {
            return x.Heuristics.Count > 0
                ? $"path.Require<{x.Heuristics[0]}>()"
                : null;
        });

        spec = spec
            .AddBases(fetchableInterface)
            .AddMethods([
                new MethodSpec(
                    "FetchManyRoute",
                    $"IApiOutRoute<IEnumerable<{target.Model}>>",
                    Modifiers: new(["static", "new"]),
                    Parameters: new([
                        ("IPathable", "path")
                    ]),
                    Expression: routeInvocation
                ),
                new MethodSpec(
                    "FetchManyRoute",
                    $"IApiOutRoute<IEnumerable<{target.Model}>>",
                    Modifiers: new(["static"]),
                    ExplicitInterfaceImplementation: fetchableInterface,
                    Parameters: new([
                        ("IPathable", "path")
                    ]),
                    Expression: "FetchManyRoute(path)"
                ),
                ..TargetAncestorsProvider
                    .GetValueOrDefault(target, ImmutableEquatableArray<TraitTargetAncestor>.Empty)!
                    .Where(x => HasFetchableImplementation(x.Target, Kind.FetchableOfMany))
                    .Select(x =>
                        new MethodSpec(
                            "FetchManyRoute",
                            $"IApiOutRoute<IEnumerable<{x.Target.Model}>>",
                            Modifiers: new(["static"]),
                            ExplicitInterfaceImplementation: GetOverloadInterface(x.Target),
                            Parameters: new([
                                ("IPathable", "path")
                            ]),
                            Expression: "FetchManyRoute(path)"
                        )
                    )
            ]);

        string GetOverloadInterface(TraitImplementationTarget info)
            => RedefinesFetchableMembers(info, Kind.FetchableOfMany)
                ? info.Type.DisplayString
                : $"Discord.IFetchableOfMany<{info.Id}, {info.Model}>";
    }

    public void ImplementSimpleFetchable(
        TraitImplementationTarget target,
        FetchableDetails details,
        ref TypeSpec spec)
    {
        var fetchableInterface = $"Discord.IFetchable<{target.Id}, {target.Model}>";

        var routeInvocation = details.Route.AsInvocation(x =>
        {
            if (x.Heuristics.Count == 0)
                return null;
            
            foreach (var heuristic in x.Heuristics)
            {
                if (target.Type.Equals(heuristic) || target.Entity.Equals(heuristic))
                    return "id";
            }

            return $"path.Require<{x.Heuristics[0]}>()";
        });

        spec = spec
            .AddBases(fetchableInterface)
            .AddMethods([
                new MethodSpec(
                    "FetchRoute",
                    $"IApiOutRoute<{target.Model}>",
                    Modifiers: new(["static", "new"]),
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id")
                    ]),
                    Expression: routeInvocation
                ),
                new MethodSpec(
                    "FetchRoute",
                    $"IApiOutRoute<{target.Model}>",
                    Modifiers: new(["static"]),
                    ExplicitInterfaceImplementation: fetchableInterface,
                    Parameters: new([
                        ("IPathable", "path"),
                        (target.Id.DisplayString, "id")
                    ]),
                    Expression: "FetchRoute(path, id)"
                ),
                ..TargetAncestorsProvider
                    .GetValueOrDefault(target, ImmutableEquatableArray<TraitTargetAncestor>.Empty)!
                    .Where(x => HasFetchableImplementation(x.Target, Kind.Fetchable))
                    .Select(x =>
                        new MethodSpec(
                            "FetchRoute",
                            $"IApiOutRoute<{x.Target.Model}>",
                            Modifiers: new(["static"]),
                            ExplicitInterfaceImplementation: GetOverloadInterface(x.Target),
                            Parameters: new([
                                ("IPathable", "path"),
                                (target.Id.DisplayString, "id")
                            ]),
                            Expression: "FetchRoute(path, id)"
                        )
                    )
            ]);

        string GetOverloadInterface(TraitImplementationTarget info)
            => RedefinesFetchableMembers(info, Kind.Fetchable)
                ? info.Type.DisplayString
                : $"Discord.IFetchable<{info.Id}, {info.Model}>";
    }

    public bool HasFetchableImplementation(TraitImplementationTarget info, Kind kind)
        => FetchableProvider.GetValuesOrEmpty(info).Any(x => x.Kind == kind);

    public bool RedefinesFetchableMembers(TraitImplementationTarget info, Kind kind)
        => TargetAncestorsProvider.TryGetValue(info, out var hierarchy) &&
           hierarchy
               .Any(x =>
                   HasFetchableImplementation(x.Target, kind)
               );
}