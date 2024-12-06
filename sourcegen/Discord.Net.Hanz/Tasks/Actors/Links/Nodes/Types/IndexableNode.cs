using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Nodes.TypeNodes.Implementers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class IndexableNode :
    BaseLinkTypeNode
{
    public IndexableNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }

    protected override bool ShouldImplement(LinkTypeNode.State state)
        => state.Entry.Type.Name == "Indexable" && state.IsTemplate;

    protected override IncrementalValuesProvider<(Context Context, ILinkImplmenter.LinkSpec Implementation)> Create(
        IncrementalValuesProvider<Context> provider)
    {
        return provider.Select((context, token) => (context, CreateInterfaceSpec(context, token)));
    }
    
    private string GetOverrideTarget(Context context, LinkTargetAncestor ancestor)
        => HasAncestors(ancestor.Info)
            ? $"{ancestor.Info.Type}.{context.Path.FormatRelative()}"
            : $"{ancestor.Info.FormattedLinkType}.Indexable";

    private ILinkImplmenter.LinkSpec CreateInterfaceSpec(Context context, CancellationToken token)
    {
        var redefinesLinkMembers = context.Ancestors.Count > 0 || !context.Target.IsCore;

        var spec = new ILinkImplmenter.LinkSpec(
            Indexers: new([
                new IndexerSpec(
                    Type: context.Target.Type.DisplayString,
                    Modifiers: new(redefinesLinkMembers ? ["new"] : []),
                    Accessibility: Accessibility.Internal,
                    Parameters: new([
                        (context.Target.FormattedIdentifiable, "identity")
                    ]),
                    Expression: "identity.Actor ?? GetActor(identity.Id)"
                )
            ])
        );

        if (!context.Target.IsCore && context.Target is ActorInfo actorInfo)
        {
            spec = spec with
            {
                Indexers = spec.Indexers.AddRange(
                    new IndexerSpec(
                        Type: actorInfo.CoreActor.DisplayString,
                        Parameters: new([
                            (context.Target.FormattedIdentifiable, "identity")
                        ]),
                        Expression: "identity.Actor ?? GetActor(identity.Id)",
                        ExplicitInterfaceImplementation: $"{actorInfo.CoreActor}.Indexable"
                    ),
                    new IndexerSpec(
                        Type: actorInfo.CoreActor.DisplayString,
                        Parameters: new([
                            (context.Target.Id.DisplayString, "id")
                        ]),
                        Expression: "this[id]",
                        ExplicitInterfaceImplementation: $"{actorInfo.FormattedCoreLinkType}.Indexable"
                    )
                ),
                Methods = spec.Methods.AddRange(
                    new MethodSpec(
                        Name: "Specifically",
                        ReturnType: actorInfo.Actor.DisplayString,
                        ExplicitInterfaceImplementation: $"{actorInfo.FormattedCoreLinkType}.Indexable",
                        Parameters: new([
                            (context.Target.Id.DisplayString, "id")
                        ]),
                        Expression: "Specifically(id)"
                    )
                )
            };
        }

        if (!redefinesLinkMembers)
            return spec;

        return spec with
        {
            Indexers = spec.Indexers.AddRange([
                new IndexerSpec(
                    Type: context.Target.Type.DisplayString,
                    Modifiers: new(["new"]),
                    Parameters: new([
                        (context.Target.Id.DisplayString, "id")
                    ]),
                    Expression: $"(this as {context.Target.FormattedActorProvider}).GetActor(id)"
                ),
                ..context.Ancestors.Select(x =>
                    new IndexerSpec(
                        Type: x.Info.Type.DisplayString,
                        Parameters: new([
                            (context.Target.Id.DisplayString, "id")
                        ]),
                        ExplicitInterfaceImplementation: GetOverrideTarget(context, x),
                        Expression: "this[id]"
                    )
                )
            ]),
            Methods = spec.Methods.AddRange([
                new MethodSpec(
                    Name: "Specifically",
                    ReturnType: context.Target.Type.DisplayString,
                    Modifiers: new(["new"]),
                    Parameters: new([
                        (context.Target.Id.DisplayString, "id")
                    ]),
                    Expression: $"(this as {context.Target.FormattedActorProvider}).GetActor(id)"
                ),
                ..context.Ancestors.Select(x =>
                    new MethodSpec(
                        Name: "Specifically",
                        ReturnType: x.Info.Type.DisplayString,
                        Parameters: new([
                            (context.Target.Id.DisplayString, "id")
                        ]),
                        ExplicitInterfaceImplementation: GetOverrideTarget(context, x),
                        Expression: "Specifically(id)"
                    )
                )
            ])
        };
    }
}