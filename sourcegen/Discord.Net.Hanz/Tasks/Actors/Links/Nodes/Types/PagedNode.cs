using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class PagedNode : BaseLinkTypeNode
{
    private readonly record struct State(
        bool PagesEntity,
        ActorOrTraitInfo Target,
        string PagedType,
        string PagingProviderType,
        string ReferenceName,
        ImmutableEquatableArray<(string AsyncPagedType, string OverrideTarget)> Ancestors)
    {
        public string AsyncPagedType => $"IAsyncPaged<{PagedType}>";
    }
    
    public PagedNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }
    
    private State CreateState(Context context, CancellationToken token)
    {
        var pagesEntity = context.Entry.Type.Generics.Length == 1;

        var pagedType = pagesEntity
            ? context.Target.Entity.DisplayString
            : context.Entry.Type.Generics[0].Name;

        return new State(
            pagesEntity,
            context.Target,
            pagedType,
            $"Func<{context.Target}.{context.Entry.Type.ReferenceName}, TParams?, RequestOptions?, IAsyncPaged<{pagedType}>>",
            context.Entry.Type.ReferenceName,
            new(
                context.Ancestors.Select(x =>
                    (
                        $"IAsyncPaged<{(pagesEntity ? x.Info.Entity.DisplayString : pagedType)}>",
                        HasAncestors(x.Info)
                            ? $"{x.Info.Type}.{context.Path.FormatRelative()}"
                            : $"{x.Info.FormattedLinkType}.{context.Entry.Type.ReferenceName}"
                    )
                )
            )
        );
    }

    protected override IncrementalValuesProvider<(Context Context, ILinkImplmenter.LinkSpec Implementation)> Create(
        IncrementalValuesProvider<Context> provider
    ) => provider
        .Select((context, token) => (Context: context, State: CreateState(context, token)))
        .Select((pair, token) => (pair.Context, CreateInterfaceSpec(pair.Context, pair.State, token)));
    
    protected override bool ShouldImplement(LinkTypeNode.State linkState)
        => linkState is {IsTemplate: true, Entry.Type.Name: "Paged"};

    private ILinkImplmenter.LinkSpec CreateInterfaceSpec(Context context, State state, CancellationToken token)
    {
        return new ILinkImplmenter.LinkSpec(
            Methods: new([
                new MethodSpec(
                    Name: "PagedAsync",
                    ReturnType: state.AsyncPagedType,
                    Modifiers: new(["new"]),
                    Parameters: new([
                        ("TParams?", "args", "default"),
                        ("RequestOptions?", "options", "null"),
                    ])
                ),
                new MethodSpec(
                    Name: "PagedAsync",
                    ReturnType: state.AsyncPagedType,
                    ExplicitInterfaceImplementation: $"{state.Target.FormattedLinkType}.{state.ReferenceName}",
                    Parameters: new([
                        ("TParams?", "args", "default"),
                        ("RequestOptions?", "options", "null"),
                    ]),
                    Expression: "PagedAsync(args, options)"
                ),
                ..state.Ancestors.Select(x => 
                    new MethodSpec(
                        Name: "PagedAsync",
                        ReturnType: x.AsyncPagedType,
                        ExplicitInterfaceImplementation: x.OverrideTarget,
                        Parameters: new([
                            ("TParams?", "args", "default"),
                            ("RequestOptions?", "options", "null"),
                        ]),
                        Expression: "PagedAsync(args, options)"
                    )
                )
            ])
        );
    }

    private ILinkImplmenter.LinkSpec CreateImplementationSpec(State state, CancellationToken token)
    {
        return ILinkImplmenter.LinkSpec.Empty;
    }
}