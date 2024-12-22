using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public interface ITypeProducerNode
{
    ILogger Logger { get; }
}

public interface ITypeProducerNode<TState> :  IStatefulNode<TState>
{
    IncrementalValuesProvider<NodeGeneration<TState, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent>> provider,
        ContinuationContext<TState, TParent> continuationContext
    );
    
    public interface WithParameters<TParameters> : IStatefulNode<TState>
    {
        IncrementalValuesProvider<NodeGeneration<TState, TParent>> Create<TParent>(
            IncrementalValuesProvider<NodeContext<TParent, TParameters>> provider,
            ContinuationContext<TState, TParent> continuationContext
        );
        
        public interface Introspects<TIntrospection> : IIntrospectingNode<TIntrospection, TState>
        {
            IncrementalValuesProvider<NodeGeneration<TState, TParent>> Create<TParent>(
                IncrementalValuesProvider<NodeContext<TParent, TParameters>> provider,
                ContinuationContext<TState, TParent> continuationContext
            );
        }
    }

    public interface Introspects<TIntrospection> : IIntrospectingNode<TIntrospection, TState>
    {
        IncrementalValuesProvider<NodeGeneration<TState, TParent>> Create<TParent>(
            IncrementalValuesProvider<NodeContext<TParent>> provider,
            ContinuationContext<TState, TParent> continuationContext
        );
    }
}

public interface IStatefulNode<TState>: ITypeProducerNode
{
    TypeSpec CreateSpec(TState state, TypePath path);

}

public record IntrospectionContext<TState>(
    TState State,
    TypePath Path,
    IIntrospectionGraph Graph
);

public record IntrospectionResult<TIntrospection, TState>(
    TState State,
    TIntrospection Introspection,
    TypePath Path
);

public interface IIntrospectingNode<TIntrospection, TState> : ITypeProducerNode
{
    IncrementalValuesProvider<IntrospectionResult<TIntrospection, TState>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<TState>> provider
    );
    
    //TIntrospection Introspect(TState state, TypePath path, IIntrospectionGraph graph);
    
    TypeSpec CreateSpec(TIntrospection introspection, TState state, TypePath path);
}