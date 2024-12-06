using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes.Implementers;

public interface INodeImplementerInfo
{
    IncrementalValuesProvider<Implementation<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider
    );
}

public record Implementation<TParent>(
    StatefulPathedTypeSpec<TParent> StatefulSpec,
    ImplementationStrategy<TParent> Strategy
);

public delegate StatefulPathedTypeSpec<TParent> ImplementationStrategy<TParent>(
    StatefulPathedTypeSpec<TParent> statefulSpec);

public sealed class StatefulNodeImplementerInfo<TState> : INodeImplementerInfo
{
    private readonly ITypeImplementerNode.WithState<TState> _node;

    public StatefulNodeImplementerInfo(
        ITypeImplementerNode.WithState<TState> node
    )
    {
        _node = node;
    }

    public IncrementalValuesProvider<Implementation<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider)
    {
        return _node
            .Create(
                provider.Select((x, _) => new NodeContext<TParent>(x.Path, x.State))
            )
            .KeyedBy(x => (x.Parent, x.Path))
            .MergeByKey(
                provider.KeyedBy(x => (x.State, x.Path)),
                (_, result, original) =>
                {
                    if (!original.HasValue)
                        return default;

                    var statefulSpec = original.Value;


                    return new Implementation<TParent>(
                        statefulSpec,
                        result.HasValue
                            ? x =>
                            {
                                var spec = x.Spec;
                                _node.Implement(ref spec, result.Value.State, x.Path);
                                return (x with {Spec = spec});
                            }
                            : x => x
                    ).Some();
                }
            )
            .ValuesProvider;
    }
}

public sealed class BasicNodeImplementerInfo : INodeImplementerInfo
{
    private readonly ITypeImplementerNode _node;

    public BasicNodeImplementerInfo(ITypeImplementerNode node)
    {
        _node = node;
    }

    public IncrementalValuesProvider<Implementation<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider)
    {
        return provider
            .Select((statefulSpec, _) =>
            {
                return new Implementation<TParent>(
                    statefulSpec,
                    x =>
                    {
                        var spec = x.Spec;
                        _node.Implement(ref spec, x.State, x.Path);
                        return x with {Spec = spec};
                    }
                );
            });
    }
}