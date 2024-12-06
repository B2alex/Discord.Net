using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes;

public abstract class LinkNode : Node
{
    protected IncrementalValuesProvider<LinkSchematics.Schematic> Schematics { get; }

    protected IncrementalKeyValueProvider<string, ActorOrTraitInfo> TargetsProvider
        => GetTask<LinksTask>().TargetsProvider;

    protected IncrementalKeyValueProvider<ActorOrTraitInfo, ImmutableEquatableArray<LinkTargetAncestor>>
        TargetAncestorsProvider
        => GetTask<LinksTask>().TargetAncestorsProvider;
    
    protected LinkNode(
        IncrementalGeneratorInitializationContext context,
        Logger logger
    ) : base(context, logger)
    {
        Schematics = GetTask<LinkSchematics>(context).Schematics;
    }

    protected bool HasAncestors(ActorOrTraitInfo info)
        => TargetAncestorsProvider.TryGetValue(info, out var ancestors) && ancestors.Count > 0;

    protected IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, TState>>
        Introspect<TState>(
            IncrementalValuesProvider<IntrospectionContext<TState>> provider,
            Func<TState, ActorOrTraitInfo> getInfo
        ) => provider
        .KeyedBy(x => getInfo(x.State))
        .JoinByKey(GetTask<LinksTask>().TargetAncestorsProvider!)
        .Select((info, pair) =>
            new IntrospectionResult<AncestorPathingIntrospection, TState>(
                pair.Value.State,
                AncestorPathingIntrospection.Introspect(
                    info,
                    pair.Other!,
                    pair.Value.Path,
                    pair.Value.Graph
                )!,
                pair.Value.Path
            )
        );
}