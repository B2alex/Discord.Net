using System.Collections.Immutable;
using System.Text;
using Discord.Net.Hanz.Nodes.TypeNodes.Implementers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public abstract class NodeInfo
{
    public ITypeProducerNode Node { get; }

    public NodeInfo(ITypeProducerNode node)
    {
        Node = node;
    }
}

public abstract class NodeInfo<TParent> : NodeInfo
{
    protected NodeInfo(ITypeProducerNode node) : base(node)
    {
    }

    public abstract IncrementalGroupingProvider<TParent, StateTree> GetStateTreeProvider();

    public abstract IncrementalGroupingProvider<TParent, PathedTypeSpec> GetTypeSpecProvider(
        IncrementalValueProvider<IIntrospectionGraph> graph
    );
}

public record PathedTypeSpec(
    TypePath Path,
    TypeSpec Spec,
    ImmutableEquatableArray<PathedTypeSpec> Children);

public record StatefulPathedTypeSpec<TState>(
    TState State,
    TypePath Path,
    TypeSpec Spec,
    ImmutableEquatableArray<PathedTypeSpec> Children
) : PathedTypeSpec(Path, Spec, Children);

public delegate NodeInfo<TState> ChildNodeFactory<TState, TParent>(
    NodeInfo<TParent, TState> parent
);

public class NodeInfo<TParent, TState> : NodeInfo<TParent>
{
    public IncrementalValuesProvider<NodeGeneration<TState, TParent>> Provider { get; }
    public IncrementalValuesProvider<NodeContext<TState>> ChildProvider { get; }

    private readonly INodeSpecProvider<TParent, TState> _specProvider;

    private readonly List<NodeInfo<TState>> _children = [];
    private readonly List<INodeImplementerInfo> _implementers = [];

    public NodeInfo(
        ITypeProducerNode node,
        IncrementalValuesProvider<NodeGeneration<TState, TParent>> provider,
        INodeSpecProvider<TParent, TState> specProvider
    ) : base(node)
    {
        Provider = provider;
        _specProvider = specProvider;
        ChildProvider = provider.Select((x, _) => new NodeContext<TState>(x.Path, x.State));
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Node.GetType()}:");
        sb.AppendLine($" - Spec Provider: {_specProvider.GetType()}");
        sb.AppendLine($" - {_children.Count} children:");

        foreach (var child in _children)
        {
            sb.AppendLine($"   - {child}".WithNewlinePadding(4));
        }

        return sb.ToString().TrimEnd();
    }

    public override IncrementalGroupingProvider<TParent, StateTree> GetStateTreeProvider()
    {
        if (_children.Count == 0)
            return Provider
                .GroupBy(x => (
                        x.Parent,
                        MapIsolatedTree(x)
                    )
                );

        var children = _children
            .Select(x => x.GetStateTreeProvider())
            .Aggregate((a, b) => a.Combine(b));

        return Provider
            .DependsOn(children)
            .GroupBy(x => (x.Parent, MapTree(x)));

        StateTree MapIsolatedTree(NodeGeneration<TState> generation)
            => new(
                Node,
                generation,
                new(
                    generation.Children.OfType<NodeGeneration<TState>>().Select(MapIsolatedTree)
                )
            );

        StateTree MapTree(NodeGeneration<TState> generation)
            => new(
                Node,
                generation,
                new([
                    ..generation.Children
                        .OfType<NodeGeneration<TState>>()
                        .Select(MapTree),
                    ..children
                        .GetValuesOrEmpty(generation.State)
                        .Where(x => generation.Path.IsParentTo(x.Generation.Path))
                ])
            );
    }


    public override IncrementalGroupingProvider<TParent, PathedTypeSpec> GetTypeSpecProvider(
        IncrementalValueProvider<IIntrospectionGraph> graph)
    {
        var specProvider = _specProvider
            .GetSpecProvider(this, graph);

        if (_implementers.Count > 0)
        {
            specProvider = specProvider
                .EntriesProvider
                .KeyedBy(x => (x.Value.State, x.Value.Path), x => x)
                .JoinByKey(
                    _implementers
                        .Select(x => x.ApplyImplementation(specProvider.ValuesProvider))
                        .Aggregate((a, b) =>
                            a.Collect().Combine(b.Collect())
                                .SelectMany(IEnumerable<Implementation<TState>> (x, _) =>
                                    [..x.Left, ..x.Right]
                                )
                        )
                        .GroupBy(x => ((x.StatefulSpec.State, x.StatefulSpec.Path), x))!,
                    (_, kvp, implementations) => (
                        Parent: kvp.Key,
                        Spec: implementations
                            .Aggregate(
                                kvp.Value,
                                (a, b) => b.Strategy(a)
                            )
                    ))
                .EntriesProvider
                .GroupBy(x => (x.Value.Parent, x.Value.Spec));
        }

        if (_children.Count == 0)
            return specProvider.MapValues(PathedTypeSpec (_, v) => v);

        var children = _children
            .Select(x => x.GetTypeSpecProvider(graph))
            .Aggregate((a, b) => a.Combine(b));

        return specProvider
            .Map((parent, statefulSpec) => (
                statefulSpec.State,
                (Parent: parent, StatefulSpec: statefulSpec)))
            .TransformValuesVia(
                children,
                (state, pair, children) => (
                    pair.Parent,
                    pair.StatefulSpec with
                    {
                        Spec = BuildWithChildren(pair.StatefulSpec)
                    }
                ),
                includeDefault: true
            )
            .Map((TParent, PathedTypeSpec) (state, pair) => pair);

        TypeSpec BuildWithChildren(StatefulPathedTypeSpec<TState> statefulSpec)
        {
            return statefulSpec.Spec
                .AddNestedTypes([
                    ..children.GetValuesOrEmpty(statefulSpec.State)
                        .Where(x => statefulSpec.Path.IsParentTo(x.Path))
                        .Select(x => x.Spec),
                    ..statefulSpec.Children
                        .OfType<StatefulPathedTypeSpec<TState>>()
                        .Select(BuildWithChildren)
                ]);
        }
    }


    public void AddChild(NodeInfo<TState> child)
        => _children.Add(child);

    public void AddImplementers(IEnumerable<INodeImplementerInfo> implementers)
        => _implementers.AddRange(implementers);
}