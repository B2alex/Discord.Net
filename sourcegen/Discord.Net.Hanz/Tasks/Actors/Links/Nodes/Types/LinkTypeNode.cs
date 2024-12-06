using System.Collections.Immutable;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class LinkTypeNode :
    LinkNode,
    ITypeProducerNode<LinkTypeNode.State>.WithParameters<ActorOrTraitInfo>.Introspects<AncestorPathingIntrospection>
{
    public record State(
        ActorOrTraitInfo Target,
        TypePath Path,
        LinkSchematics.Entry Entry
    ) : IPathedState
    {
        public bool IsTemplate { get; } = !Path.Contains<LinkTypeNode>();

        public TypePath Path { get; } = Path.Add<LinkTypeNode>(Entry.Type.ReferenceName);
    }

    public LinkTypeNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }

    public TypeSpec CreateSpec(AncestorPathingIntrospection introspection, State state, TypePath path)
    {
        var spec = TypeSpec
            .From(state.Entry.Type)
            .AddModifiers("new")
            .AddBases([
                ..introspection.SemanticBases,
                ..introspection.AncestorBases.Select(x => $"{x.Type}.{path.FormatRelative()}")
            ]);

        if (state.IsTemplate)
        {
            spec = spec.AddBases(
                $"{state.Target.Type}.Link"
            );

            switch (state.Target.Assembly)
            {
                case AssemblyTarget.Core:
                    spec = spec.AddBases(
                        $"{state.Target.FormattedLinkType}.{state.Path.FormatRelative()}"
                    );
                    break;
                case AssemblyTarget.Rest:
                    spec = spec.AddBases(
                        state.Target.FormattedRestLinkType
                    );
                    break;
            }
        }

        return spec;
    }

    public IncrementalValuesProvider<NodeGeneration<State, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent, ActorOrTraitInfo>> provider,
        ContinuationContext<State, TParent> continuationContext)
    {
        continuationContext.AddChild(GetNode<HierarchyNode>(), x => x.Target);
        continuationContext.AddChild(GetNode<BackLinkNode>(), x => x.Target);
        continuationContext.AddChild(GetNode<ExtensionNode>(), x => x.Target);

        continuationContext.WithImplementationFrom(GetNode<IndexableNode>());
        continuationContext.WithImplementationFrom(GetNode<EnumerableNode>());
        continuationContext.WithImplementationFrom(GetNode<DefinedNode>());
        continuationContext.WithImplementationFrom(GetNode<PagedNode>());

        return provider
            .Combine(Schematics.Collect())
            .SelectMany((tuple, _) => CreateState(tuple.Left, tuple.Right));

        static IEnumerable<NodeGeneration<State, TParent>> CreateState(
            NodeContext<TParent, ActorOrTraitInfo> context,
            ImmutableArray<LinkSchematics.Schematic> schematics)
        {
            foreach (var schematic in schematics)
            foreach (var entry in schematic.Root.Children)
            {
                yield return CreateLinkState(context, entry, context.Path);
            }
        }

        static NodeGeneration<State, TParent> CreateLinkState(
            NodeContext<TParent, ActorOrTraitInfo> context,
            LinkSchematics.Entry entry,
            TypePath path)
        {
            var state = new State(
                context.Parameters,
                path,
                entry
            );

            return context.WithState(
                state,
                state.Path,
                entry.Children.Select(child => CreateLinkState(context, child, state.Path))
            );
        }
    }

    public IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, State>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<State>> provider
    ) => Introspect(provider, x => x.Target);
}