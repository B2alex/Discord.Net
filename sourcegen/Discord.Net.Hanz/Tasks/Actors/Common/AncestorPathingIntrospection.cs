using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Links;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Common;

public sealed record AncestorPathingIntrospection(
    ImmutableEquatableArray<TypePath> SemanticBases,
    ImmutableEquatableArray<ActorOrTraitInfo> AncestorBases
)
{
    // public static IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, TState>>
    //     Introspect<TState>(
    //         IncrementalValuesProvider<IntrospectionContext<TState>> provider,
    //         Func<TState, ActorInfo> getActorInfo
    //     )
    // {
    //     
    // }
    
    public static AncestorPathingIntrospection? Introspect(
        ActorOrTraitInfo target, 
        ImmutableEquatableArray<LinkTargetAncestor> ancestors,
        TypePath path,
        IIntrospectionGraph graph)
    {
        if (!graph.TryGet(target, out var introspection))
            return null;

        var semantics = (~path).SemanticalProduct().ToArray();
        var targets = (path.First!.Value + semantics).ToArray();

        return new AncestorPathingIntrospection(
            targets.Where(introspection.Contains).ToImmutableEquatableArray(),
            ancestors
                .Select(x => x.Info)
                .Where(x => graph.TryGet(x, out var tree) && tree.HasSubPath(~path))
                .ToImmutableEquatableArray()
        );
    }
}