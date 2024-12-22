using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;

public sealed class BackLinkNode :
    LinkNode,
    ITypeProducerNode<BackLinkNode.BackLink>.WithParameters<ActorOrTraitInfo>.Introspects<AncestorPathingIntrospection>
{
    public record Introspection(
        ImmutableEquatableArray<TypePath> SelfBases,
        ImmutableEquatableArray<ActorInfo> AncestorBases
    );

    public record BackLink(
        ActorOrTraitInfo Target
    )
    {
        public bool IsCovariant => Target.IsCore;
        public string TypeName => $"BackLink<{(IsCovariant ? "out " : string.Empty)}TSource>";
        public string ReferenceName => $"BackLink<TSource>";
    }

    public record ExtensionBackLink(
        ActorOrTraitInfo Target,
        ExtensionNode.Extension Extension
    ) : BackLink(Target);

    public record HierarchyBackLink(
        ActorOrTraitInfo Target,
        HierarchyNode.Hierarchy Hierarchy
    ) : BackLink(Target);

    public BackLinkNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
    }

    public TypeSpec CreateSpec(AncestorPathingIntrospection introspection, BackLink state, TypePath path)
    {
        var spec =
            new TypeSpec(
                Name: "BackLink",
                Kind: TypeKind.Interface,
                Generics: new([
                    ("TSource", state.IsCovariant ? VarianceKind.Out : VarianceKind.None)
                ]),
                GenericConstraints: new([
                    ("TSource", ["class", "IPathable"])
                ]),
                Bases: new([
                    state.Target.FormattedBackLinkType,
                    ..introspection.SemanticBases,
                    ..introspection.AncestorBases.Select(x => $"{x.Type}.{~path}")
                ])
            );

        if (path.Equals(typeof(ActorNode), typeof(BackLinkNode)))
            spec = spec.AddBases(state.Target.Type.DisplayString);

        switch (state)
        {
            case ExtensionBackLink extensionBackLink:
                spec = spec.AddProperties(
                    extensionBackLink.Extension.Properties.SelectMany(property =>
                        ExtensionNode.BuildExtensionProperty(
                            path,
                            property,
                            extensionBackLink.Extension
                        )
                    )
                );
                break;
            case HierarchyBackLink hierarchyBackLink:
                spec = spec.AddProperties(
                    hierarchyBackLink.Hierarchy.HierarchyInfos.SelectMany(IEnumerable<PropertySpec> (info) => [
                        HierarchyNode.FormatExtensionProperty(state.Target, info, path),
                        HierarchyNode.FormatExtensionProperty(state.Target, info, path.ParentPath.Value) with
                        {
                            ExplicitInterfaceImplementation = path.ParentPath.Value,
                            Expression = HierarchyNode.GetHierarchyPropertyName(state.Target, info)
                        },
                    ])
                );
                break;
        }

        return spec;
    }


    public IncrementalValuesProvider<NodeGeneration<BackLink, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent, ActorOrTraitInfo>> provider,
        ContinuationContext<BackLink, TParent> continuationContext)
    {
        return provider
            .Select((context, _) =>
            {
                var state = context.Parent switch
                {
                    ExtensionNode.Extension extension => new ExtensionBackLink(
                        context.Parameters,
                        extension
                    ),
                    HierarchyNode.Hierarchy hierarchy => new HierarchyBackLink(
                        context.Parameters,
                        hierarchy
                    ),
                    _ => new BackLink(context.Parameters)
                };

                return context.WithState(state, context.Path.Add<BackLinkNode>(state.ReferenceName));
            });
    }

    public IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, BackLink>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<BackLink>> provider
    ) => Introspect(provider, x => x.Target);
}