using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Nodes.TypeNodes.Implementers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public abstract class BaseLinkTypeNode :
    LinkNode,
    ITypeImplementerNode.WithState<ILinkImplmenter.LinkSpec>
{
    protected abstract bool ShouldImplement(LinkTypeNode.State state);

    public record Context(
        LinkTypeNode.State LinkState,
        ImmutableEquatableArray<LinkTargetAncestor> Ancestors
    )
    {
        public LinkSchematics.Entry Entry => LinkState.Entry;
        public TypePath Path => LinkState.Path;
        public ActorOrTraitInfo Target => LinkState.Target;
    }

    protected abstract IncrementalValuesProvider<(Context Context, ILinkImplmenter.LinkSpec Implementation)> Create(
        IncrementalValuesProvider<Context> provider
    );

    protected BaseLinkTypeNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
    }

    public IncrementalValuesProvider<NodeImplementation<ILinkImplmenter.LinkSpec, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent>> provider)
    {
        var stateProvider = provider
            .MaybeSelect(context =>
            {
                if (context is not NodeContext<LinkTypeNode.State> linkContext)
                    return default;

                if (!ShouldImplement(linkContext.Parent))
                    return default;

                return linkContext.Some();
            })
            .KeyedBy(x => x.Parent.Target)
            .JoinByKey(
                TargetAncestorsProvider!,
                (info, context, ancestors) => new Context(
                    context.Parent,
                    ancestors!
                )
            )
            .ValuesProvider;

        return Create(stateProvider)
            .KeyedBy(x => x.Context.LinkState, x => x.Implementation)
            .Select((state, spec) =>
                new NodeImplementation<ILinkImplmenter.LinkSpec, TParent>(
                    spec,
                    state.Path,
                    (TParent) Convert.ChangeType(state, typeof(TParent))
                )
            );
    }

    public void Implement(ref TypeSpec spec, ILinkImplmenter.LinkSpec state, TypePath path)
    {
        spec = spec
            .AddMethods(state.Methods)
            .AddIndexers(state.Indexers)
            .AddProperties(state.Properties);
    }
}

// public abstract class BaseLinkTypeNode : LinkNode, ILinkImplmenter
// {
//     protected readonly record struct AncestorInfo(
//         ActorInfo ActorInfo,
//         bool HasAncestors
//     );
//
//     protected readonly record struct LinkInfo(
//         ImmutableEquatableArray<AncestorInfo> Ancestors,
//         LinkTypeNode.State State
//     )
//     {
//         public bool IsTemplate => State.IsTemplate;
//         public ActorInfo ActorInfo => State.ActorInfo;
//     }
//
//     public BaseLinkTypeNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
//     {
//     }
//
//     protected abstract bool ShouldContinue(LinkTypeNode.State linkState, CancellationToken token);
//
//     protected virtual bool ShouldContinue(LinkInfo info, CancellationToken token)
//         => true;
//
//     protected abstract IncrementalValuesProvider<Branch<ILinkImplmenter.LinkImplementation>> CreateImplementation(
//         IncrementalValuesProvider<Branch<LinkInfo>> provider
//     );
//
//
//     private IncrementalValuesProvider<Branch<LinkInfo>> CreateProvider(
//         IncrementalValuesProvider<Branch<LinkTypeNode.State>> provider
//     )
//     {
//         var actorAncestors = GetTask<ActorsTask>()
//             .ActorAncestors;
//
//         return provider
//             .Where(ShouldContinue)
//             .Select((branch, __) => branch
//                 .Mutate(
//                     new LinkInfo(
//                         actorAncestors
//                             .GetValueOrDefault(branch.Value.ActorInfo, ImmutableEquatableArray<ActorInfo>.Empty)
//                             .Select(x => new AncestorInfo(
//                                 x,
//                                 actorAncestors.GetValueOrDefault(x, ImmutableEquatableArray<ActorInfo>.Empty).Count > 0)
//                             )
//                             .ToImmutableEquatableArray(),
//                         branch.Value
//                     )
//                 )
//             )
//             .Where(ShouldContinue);
//     }
//
//     public IncrementalValuesProvider<Branch<ILinkImplmenter.LinkImplementation>> Branch(
//         IncrementalValuesProvider<Branch<LinkTypeNode.State>> provider
//     ) => CreateImplementation(CreateProvider(provider));
// }