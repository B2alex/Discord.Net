using System.Collections.Immutable;
using System.Text;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;

public sealed class HierarchyNode :
    LinkNode,
    ITypeProducerNode<HierarchyNode.Hierarchy>.WithParameters<ActorOrTraitInfo>.Introspects<
        AncestorPathingIntrospection>
{
    public record Hierarchy(
        ActorOrTraitInfo Target,
        ImmutableEquatableArray<ActorOrTraitInfo> HierarchyInfos
    );

    private readonly IncrementalKeyValueProvider<ActorOrTraitInfo, ImmutableEquatableArray<ActorOrTraitInfo>>
        _hierarchyProvider;

    public HierarchyNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        _hierarchyProvider = GetTask<LinksTask>()
            .TargetAncestorsProvider
            .JoinByKey(
                context
                    .SyntaxProvider
                    .ForAttributeWithMetadataName(
                        "Discord.LinkHierarchicalRootAttribute",
                        (node, _) => node is InterfaceDeclarationSyntax,
                        (string Target, ImmutableEquatableArray<string>? UserSpecifiedTypes)? (sourceContext, _) =>
                        {
                            if (sourceContext.SemanticModel.GetDeclaredSymbol(sourceContext.TargetNode) is not
                                INamedTypeSymbol
                                symbol)
                                return null;

                            if (sourceContext.Attributes.Length != 1)
                                return null;

                            var value = sourceContext
                                .Attributes[0]
                                .NamedArguments
                                .FirstOrDefault(x => x.Key == "Types")
                                .Value;

                            if (value.Kind is TypedConstantKind.Error)
                                return (symbol.ToDisplayString(), null);

                            return (
                                symbol.ToDisplayString(),
                                value.Values
                                    .Select(x => ((INamedTypeSymbol) x.Value!).ToDisplayString())
                                    .ToImmutableEquatableArray()
                            );
                        }
                    )
                    .WhereNotNull()
                    .KeyedBy(x => x.Target, x => x.UserSpecifiedTypes)
                    .TransformKeyVia(GetTask<LinksTask>().TargetsProvider),
                (info, _, userSpecifiedTypes) =>
                    (
                        userSpecifiedTypes?.Count > 0
                            ? userSpecifiedTypes
                                .Select(x => TargetsProvider.GetValueOrDefault(x))
                                .Where(x => x != default)
                            : TargetAncestorsProvider.Entries
                                .Where(x => x.Value.Any(x => x.Info == info))
                                .Select(x => x.Key)
                    )!
                    .ToImmutableEquatableArray<ActorOrTraitInfo>()
            );
    }

    public static string GetHierarchyPropertyName(ActorOrTraitInfo from, ActorOrTraitInfo property)
    {
        return string.Join(
            string.Empty,
            ToNameParts(GetFriendlyName(property.Type))
                .Except(
                    ToNameParts(GetFriendlyName(from.Type))
                )
        );
    }

    public static string[] ToNameParts(string str)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < str.Length; i++)
        {
            var ch = str[i];
            if (char.IsUpper(ch) && i > 0)
                sb.Append(' ');

            sb.Append(ch);
        }

        return sb.ToString().Split(' ');
    }

    public static PropertySpec FormatExtensionProperty(
        ActorOrTraitInfo info,
        ActorOrTraitInfo property,
        TypePath path
    )
    {
        return new PropertySpec(
            Type: path.Equals(typeof(ActorNode), typeof(HierarchyNode))
                ? property.FormattedLink
                : $"{property.Type}.{path.ParentPath!.Value.FormatRelative()}",
            Name: GetHierarchyPropertyName(info, property)
        );
    }

    public TypeSpec CreateSpec(AncestorPathingIntrospection introspection, Hierarchy state, TypePath path)
    {
        var isTemplate = path.Count == 1;

        var spec = new TypeSpec(
                Name: "Hierarchy",
                Kind: TypeKind.Interface,
                Bases: new([
                    ..introspection.SemanticBases
                ])
            )
            .AddProperties(state.HierarchyInfos.Select(x => FormatExtensionProperty(state.Target, x, path)));

        foreach (var semanticPath in introspection.SemanticBases.Where(x => x.Last == "Hierarchy"))
        {
            spec = spec.AddProperties(
                state.HierarchyInfos.Select(x =>
                    FormatExtensionProperty(state.Target, x, semanticPath) with
                    {
                        ExplicitInterfaceImplementation = semanticPath,
                        Expression = GetHierarchyPropertyName(state.Target, x)
                    }
                )
            );
        }

        return spec;
    }

    public IncrementalValuesProvider<NodeGeneration<Hierarchy, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent, ActorOrTraitInfo>> provider,
        ContinuationContext<Hierarchy, TParent> continuationContext)
    {
        continuationContext.AddChild(GetNode<BackLinkNode>(), x => x.Target);

        return provider
            .KeyedBy(x => x.Parameters)
            .JoinByKey(
                _hierarchyProvider!,
                (info, context, hierarchy) => context
                    .WithState(
                        new Hierarchy(info, hierarchy!.ToImmutableEquatableArray()),
                        context.Path.Add<HierarchyNode>("Hierarchy")
                    )
            )
            .ValuesProvider;
    }

    public IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, Hierarchy>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<Hierarchy>> provider
    ) => Introspect(provider, x => x.Target);
}
// public class HierarchyNode :
//     LinkNode,
//     INestedTypeProducerNode
// {
//     public readonly record struct BuildContext(
//         ActorInfo ActorInfo,
//         TypePath Path,
//         bool IsTemplate,
//         ImmutableEquatableArray<ActorInfo> Properties,
//         ImmutableEquatableArray<string> Bases,
//         ImmutableEquatableArray<string?> Overloads)
//     {
//         public TypePath Path { get; } = Path.Add<HierarchyNode>("Hierarchy");
//
//         public IEnumerable<PropertySpec> GetPropertySpecs()
//         {
//             var actor = ActorInfo.Actor;
//             var isTemplate = IsTemplate;
//             var relativePath = Path.FormatRelative();
//             var overloads = Overloads;
//
//             return Properties.SelectMany(IEnumerable<PropertySpec> (x) =>
//             [
//                 new(
//                     Type: isTemplate
//                         ? x.FormattedLink
//                         : $"{x.Actor}.{relativePath}",
//                     Name: GetFriendlyName(x.Actor)
//                 ),
//                 ..overloads.Select(path =>
//                     new PropertySpec(
//                         Type: path is null
//                             ? x.FormattedLink
//                             : $"{x.Actor}.{path}",
//                         Name: GetFriendlyName(x.Actor),
//                         ExplicitInterfaceImplementation: path is null
//                             ? $"{actor}.Hierarchy"
//                             : $"{actor}.{path}.Hierarchy",
//                         Expression: GetFriendlyName(x.Actor)
//                     )
//                 )
//             ]);
//         }
//
//         public static BuildContext Create(
//             NestedTypeProducerContext parameters,
//             ImmutableEquatableArray<ActorInfo> hierarchy)
//         {
//             var bases = new List<string>();
//             var overloads = new List<string?>();
//
//             var isTemplate = parameters.Path.Last?.Type == typeof(ActorNode);
//
//             if (isTemplate)
//             {
//                 bases.Add($"{parameters.Path}");
//                 bases.Add($"{parameters.ActorInfo.Actor}.Hierarchy");
//                 overloads.Add(null);
//
//                 for (int i = 0; i < parameters.Path.Count - 1; i++)
//                 {
//                     var path = parameters.Path.Slice(0, i);
//                     bases.Add($"{path}.Hierarchy");
//                     overloads.Add(path.ToString());
//                 }
//             }
//
//             return new(
//                 parameters.ActorInfo,
//                 parameters.Path,
//                 isTemplate,
//                 hierarchy,
//                 bases.ToImmutableEquatableArray(),
//                 overloads.ToImmutableEquatableArray()
//             );
//         }
//     }
//
//     private readonly IncrementalKeyValueProvider<ActorInfo, ImmutableEquatableArray<ActorInfo>> _hierarchyProvider;
//
//     public HierarchyNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
//     {
//         _hierarchyProvider = GetTask<ActorsTask>()
//             .ActorHierarchies
//             .JoinByKey(
//                 context
//                     .SyntaxProvider
//                     .ForAttributeWithMetadataName(
//                         "Discord.LinkHierarchicalRootAttribute",
//                         (node, _) => node is InterfaceDeclarationSyntax,
//                         (string Actor, ImmutableEquatableArray<string> UserSpecifiedTypes)? (sourceContext, _) =>
//                         {
//                             if (sourceContext.SemanticModel.GetDeclaredSymbol(sourceContext.TargetNode) is not
//                                 INamedTypeSymbol
//                                 symbol)
//                                 return null;
//
//                             if (sourceContext.Attributes.Length != 1)
//                                 return null;
//
//                             var value = sourceContext
//                                 .Attributes[0]
//                                 .NamedArguments
//                                 .FirstOrDefault(x => x.Key == "Types")
//                                 .Value;
//
//                             if (value.Kind is TypedConstantKind.Error)
//                                 return null;
//
//                             return (
//                                 symbol.ToDisplayString(),
//                                 value.Values
//                                     .Select(x => ((INamedTypeSymbol) x.Value!).ToDisplayString())
//                                     .ToImmutableEquatableArray()
//                             );
//                         }
//                     )
//                     .WhereNonNull()
//                     .KeyedBy(x => x.Actor, x => x.UserSpecifiedTypes)
//                     .TransformKeyVia(GetTask<ActorsTask>().ActorInfos),
//                 (info, hierarchy, userSpecifiedTypes) => userSpecifiedTypes.Count > 0
//                     ? userSpecifiedTypes
//                         .Select(x => GetTask<ActorsTask>().ActorInfos.GetValueOrDefault(x))
//                         .Where(x => x != default)
//                         .ToImmutableEquatableArray()
//                     : hierarchy.Children
//             );
//     }
//
//     public IncrementalValuesProvider<Branch<TypeSpec>> Create<TParent>(
//         IncrementalValuesProvider<Branch<(NestedTypeProducerContext Parameters, TParent Source)>> provider
//     )
//     {
//         return AddNestedTypes(
//             GetNode<BackLinkNode>(),
//             _hierarchyProvider
//                 .JoinByKey(
//                     provider.KeyedBy(x => x.Value.Parameters.ActorInfo),
//                     (info, hierarchy, branch) => branch
//                         .Mutate(BuildContext.Create(branch.Value.Parameters, hierarchy))
//                 )
//                 .ValuesProvider
//                 .Select(Build),
//             (context, _) =>
//                 new NestedTypeProducerContext(
//                     context.State.ActorInfo,
//                     context.State.Path
//                 ),
//             (context, specs, _) => context.Spec.AddNestedTypes(specs),
//             context => context.State
//         );
//     }
//
//     private StatefulGeneration<BuildContext> Build(BuildContext context, CancellationToken token)
//     {
//         var spec = new TypeSpec(
//             Name: "Hierarchy",
//             Kind: TypeKind.Interface,
//             Properties: new(context.GetPropertySpecs()),
//             Bases: context.Bases
//         );
//
//         return new StatefulGeneration<BuildContext>(context, spec);
//     }
// }