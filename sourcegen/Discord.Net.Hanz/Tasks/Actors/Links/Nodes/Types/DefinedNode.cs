using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class DefinedNode : BaseLinkTypeNode
{
    public DefinedNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }
    
    protected override bool ShouldImplement(LinkTypeNode.State state)
        =>  state.Entry.Type.Name == "Defined";

    protected override IncrementalValuesProvider<(Context Context, ILinkImplmenter.LinkSpec Implementation)> Create(
        IncrementalValuesProvider<Context> provider
    ) => provider.Select((context, token) => (context, CreateInterfaceSpec(context, token)));

    private string GetOverrideTarget(
        Context context,
        LinkTargetAncestor ancestor
    ) => HasAncestors(ancestor.Info)
        ? $"{ancestor.Info.Type}.{context.Path.FormatRelative()}"
        : $"{ancestor.Info.FormattedLinkType}.Defined";
    
    private ILinkImplmenter.LinkSpec CreateInterfaceSpec(Context context, CancellationToken token)
    {
        return new ILinkImplmenter.LinkSpec(
            Properties: new([
                new PropertySpec(
                    Type: $"IReadOnlyCollection<{context.Target.Id}>",
                    Name: "Ids",
                    Modifiers: new(["new"])
                ),
                new PropertySpec(
                    Type: $"IReadOnlyCollection<{context.Target.Id}>",
                    Name: "Ids",
                    ExplicitInterfaceImplementation: $"{context.Target.FormattedLinkType}.Defined",
                    Expression: "Ids"
                ),
                ..context.Ancestors.Select(x =>
                    new PropertySpec(
                        Type: $"IReadOnlyCollection<{x.Info.Id}>",
                        Name: "Ids",
                        ExplicitInterfaceImplementation: GetOverrideTarget(context, x),
                        Expression: "Ids"
                    )
                )
            ])
        );
    }
    
    // protected override bool ShouldContinue(LinkTypeNode.State linkState, CancellationToken token)
    //     => linkState.Entry.Type.Name == "Defined";
    //
    // protected override IncrementalValuesProvider<Branch<ILinkImplmenter.LinkImplementation>> CreateImplementation(
    //     IncrementalValuesProvider<Branch<LinkInfo>> provider
    // ) => provider.Select(CreateImplementation);
    //

    //
    // private ILinkImplmenter.LinkImplementation CreateImplementation(LinkInfo info, CancellationToken token)
    // {
    //     return new ILinkImplmenter.LinkImplementation(
    //         CreateInterfaceSpec(info, token),
    //         CreateImplementationSpec(info, token)
    //     );
    // }
    //
    
    //
    // private ILinkImplmenter.LinkSpec CreateImplementationSpec(LinkInfo state, CancellationToken token)
    // {
    //     return ILinkImplmenter.LinkSpec.Empty;
    // }
    
}