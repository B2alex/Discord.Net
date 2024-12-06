using System.Collections.Immutable;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Links;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Nodes;

public sealed partial class ActorNode
{
    private record LinkContext(
        ActorOrTraitInfo Target,
        ImmutableEquatableArray<LinkTargetAncestor> Ancestors
    )
    {
        public bool RedefinesRootInterfaceMembers =>
            !Target.IsCore ||
            Ancestors.Any(x => x.IsEntityAssignable is true) ||
            Ancestors.All(x => x is null);
    }

    public TypeRootProviders<ActorOrTraitInfo> LinkProviders { get; private set; }

    private void CreateLinks(IncrementalGeneratorInitializationContext context)
    {
        var typeRoot = new NestedTypeRoot<ActorOrTraitInfo>(
            GetTask<LinksTask>()
                .TargetsProvider
                .Select((_, x) => (x, TypePath.Empty.Add<ActorNode>(x.Type.ReferenceName)))
        );

        typeRoot.AddChild(GetNode<LinkTypeNode>());
        typeRoot.AddChild(GetNode<BackLinkNode>());
        typeRoot.AddChild(GetNode<ExtensionNode>());
        typeRoot.AddChild(GetNode<HierarchyNode>());

        LinkProviders = typeRoot.Build(Logger.GetSubLogger("BuildTypeRoot"));

        context.RegisterSourceOutput(
            LinkProviders
                .SpecProvider
                .ToKeyed((info, specs) =>
                    TypeSpec.From(info.Type) with
                    {
                        Modifiers = new(["partial"]),
                        Children = specs.ToImmutableEquatableArray()
                    }
                )
                .JoinByKey(
                    GetTask<LinksTask>()
                        .TargetAncestorsProvider
                        .MapValues((info, hierarchy) => new LinkContext(info, hierarchy))
                        .MapValues((info, context) => CreateLinkInterface(context))!,
                    (info, container, linkInterface) => container.AddNestedType(linkInterface!)
                )
                .Select((actorInfo, spec) =>
                    new SourceSpec(
                        $"Links/{actorInfo.Type.MetadataName}",
                        actorInfo.Type.Namespace!,
                        new ImmutableEquatableArray<string>([
                            "Discord",
                            "Discord.Models",
                            "MorseCode.ITask"
                        ]),
                        new([
                            spec
                        ]),
                        new([
                            "CS0108",
                            "CS0109"
                        ])
                    )
                )
                .Select((x, _) =>
                {
                    using var logger = Logger
                        .GetSubLogger("Output")
                        .GetSubLogger(x.Path.Split('/')[1])
                        .WithCleanLogFile();

                    logger.Log(x.ToString());

                    return x;
                })
        );
    }

    private TypeSpec CreateLinkInterface(LinkContext context)
    {
        var linkType = new TypeSpec(
            "Link",
            TypeKind.Interface,
            Bases: new([
                context.Target.FormattedLink
            ])
        );

        if (
            context.Ancestors
                .Any(x => GetTask<LinksTask>()
                    .TargetAncestorsProvider
                    .GetValueOrDefault(
                        x.Info,
                        ImmutableEquatableArray<LinkTargetAncestor>.Empty
                    )!
                    .Count > 0
                )
            ||
            !context.Target.IsCore
        )
        {
            linkType = linkType.AddModifiers("new");
        }

        if (!context.Target.IsCore && context.Target is ActorInfo actorInfo)
            linkType = linkType.AddBases(actorInfo.FormattedCoreLink);

        if (context.RedefinesRootInterfaceMembers)
        {
            linkType = linkType
                .AddInterfaceMethodOverload(
                    context.Target.Type.DisplayString,
                    context.Target.FormattedActorProvider,
                    "GetActor",
                    [
                        new ParameterSpec(
                            context.Target.Id.DisplayString,
                            "id"
                        )
                    ],
                    expression: "GetActor(id)"
                )
                .AddInterfaceMethodOverload(
                    context.Target.Entity.DisplayString,
                    context.Target.FormattedEntityProvider,
                    "CreateEntity",
                    [
                        new ParameterSpec(
                            context.Target.Model.DisplayString,
                            "model"
                        )
                    ],
                    expression: "CreateEntity(model)"
                );

            // if (!context.Target.IsCore)
            // {
            //     linkType = linkType
            //         .AddInterfaceMethodOverload(
            //             context.Target.CoreActor.DisplayString,
            //             context.Target.FormattedCoreActorProvider,
            //             "GetActor",
            //             [
            //                 new ParameterSpec(
            //                     context.Target.Id.DisplayString,
            //                     "id"
            //                 )
            //             ],
            //             expression: "GetActor(id)"
            //         )
            //         .AddInterfaceMethodOverload(
            //             context.Target.CoreEntity.DisplayString,
            //             context.Target.FormattedCoreEntityProvider,
            //             "CreateEntity",
            //             [
            //                 new ParameterSpec(
            //                     context.Target.Model.DisplayString,
            //                     "model"
            //                 )
            //             ],
            //             expression: "CreateEntity(model)"
            //         );
            // }
        }

        foreach (var ancestor in context.Ancestors)
        {
            var ancestorActorProviderTarget = HasEntityAssignableAncestors(ancestor.Info)
                ? $"{ancestor.Info.Type}.Link"
                : ancestor.Info.FormattedActorProvider;

            var ancestorEntityProviderTarget = HasEntityAssignableAncestors(ancestor.Info)
                ? $"{ancestor.Info.Type}.Link"
                : ancestor.Info.FormattedEntityProvider;

            linkType = linkType
                .AddBases($"{ancestor.Info.Type}.Link")
                .AddInterfaceMethodOverload(
                    ancestor.Info.Type.DisplayString,
                    ancestorActorProviderTarget,
                    "GetActor",
                    [(ancestor.Info.Id.DisplayString, "id")],
                    expression: "GetActor(id)"
                )
                .AddInterfaceMethodOverload(
                    ancestor.Info.Entity.DisplayString,
                    ancestorEntityProviderTarget,
                    "CreateEntity",
                    [(ancestor.Info.Model.DisplayString, "model")],
                    expression: "CreateEntity(model)"
                );
        }

        return linkType;

        bool HasEntityAssignableAncestors(ActorOrTraitInfo info)
            => GetTask<LinksTask>()
                   .TargetAncestorsProvider
                   .TryGetValue(info, out var ancestors) &&
               (
                   ancestors.Any(x => x.IsEntityAssignable is true)
                   ||
                   ancestors.All(x => x.IsEntityAssignable is null)
               );
    }
}