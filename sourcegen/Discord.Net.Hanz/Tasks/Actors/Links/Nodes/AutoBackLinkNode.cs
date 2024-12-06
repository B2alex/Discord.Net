using System.Text.RegularExpressions;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes;

using LinkPropertiesTree = (
    ImmutableEquatableArray<AutoBackLinkNode.LinkProperty> Properties,
    ImmutableEquatableArray<AutoBackLinkNode.AncestorProperty> AncestorProperties
    );

public sealed class AutoBackLinkNode : LinkNode
{
    private static readonly Regex _backLinkRegex = new("BackLink<(.*)>$");

    public record LinkProperty(
        string Target,
        string Type,
        string Name,
        string? ExplicitInterfaceImplementation
    );

    public record LinkPropertyOverride(
        string NewType,
        AncestorProperty Target
    );

    public record AncestorProperty(
        ActorInfo Ancestor,
        LinkProperty Property
    );

    private readonly IncrementalKeyValueProvider<
        ActorInfo,
        ImmutableEquatableArray<LinkPropertyOverride>
    > _linkPropertiesOverrideProvider;

    public AutoBackLinkNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        var provider = GetTask<ActorsTask>()
            .Actors
            .KeyedBy(x => x.Actor.ToDisplayString(), GetLinkProperties)
            .PairKeys(GetTask<ActorsTask>().ActorInfos);

        var linkPropertiesProvider = provider
            .JoinByKey(
                GetTask<ActorsTask>().ActorAncestors!,
                (info, properties, ancestors) => (
                    Properties: properties,
                    AncestorProperties: ancestors!
                        .SelectMany(ancestor => provider
                            .GetValueOrDefault(ancestor.ActorInfo, ImmutableEquatableArray<LinkProperty>.Empty)!
                            .Select(x => new AncestorProperty(ancestor.ActorInfo, x))
                        )
                        .Distinct()
                        .ToImmutableEquatableArray()
                )
            );

        _linkPropertiesOverrideProvider = linkPropertiesProvider
            .MaybeMapValues(GetPropertiesToBackLink);

        context.RegisterSourceOutput(
            _linkPropertiesOverrideProvider
                .JoinByKey(
                    GetTask<ActorsTask>().ActorAncestors!,
                    CreateSpec!
                )
                .ValuesProvider
        );
    }

    private SourceSpec CreateSpec(
        ActorInfo actorInfo,
        ImmutableEquatableArray<LinkPropertyOverride> overrides,
        ImmutableEquatableArray<AncestorInfo> ancestors)
    {
        var typeSpec = TypeSpec.From(actorInfo.Actor).AddModifiers("partial");

        foreach (var (newType, target) in overrides)
        {
            typeSpec = typeSpec
                .AddProperties([
                    new PropertySpec(
                        newType,
                        target.Property.Name,
                        Modifiers: new(["new"])
                    ),
                    new PropertySpec(
                        target.Property.Type,
                        target.Property.Name,
                        ExplicitInterfaceImplementation: target.Ancestor.Actor.DisplayString,
                        Expression: target.Property.Name
                    ),
                    ..ancestors
                        .SelectMany(ancestor =>
                            _linkPropertiesOverrideProvider
                                .GetValueOrDefault(
                                    ancestor.ActorInfo,
                                    ImmutableEquatableArray<LinkPropertyOverride>.Empty
                                )!
                                .Where(x => x.Target == target)
                                .Select(x =>
                                    new PropertySpec(
                                        x.NewType,
                                        target.Property.Name,
                                        ExplicitInterfaceImplementation: ancestor.ActorInfo.Actor.DisplayString,
                                        Expression: target.Property.Name
                                    )
                                )
                        )
                ]);
        }

        return new SourceSpec(
            $"AutoBackLinks/{actorInfo.Actor.MetadataName}",
            actorInfo.Actor.Namespace!,
            Usings: new(["Discord"]),
            Types: new([typeSpec])
        );
    }

    private Optional<ImmutableEquatableArray<LinkPropertyOverride>> GetPropertiesToBackLink(
        ActorInfo actorInfo,
        LinkPropertiesTree tree
    )
    {
        if (tree.AncestorProperties.Count == 0) return default;

        var overrides = new List<LinkPropertyOverride>();

        foreach (var ancestorProperty in tree.AncestorProperties)
        {
            if (
                tree.Properties.Any(x =>
                    x.Name == ancestorProperty.Property.Name &&
                    x.ExplicitInterfaceImplementation == ancestorProperty.Ancestor.Actor.DisplayString)
            ) continue;

            var match = _backLinkRegex.Match(ancestorProperty.Property.Type);

            var overrideType = match.Success
                ? ancestorProperty.Property.Type
                    .Remove(match.Groups[1].Index, match.Groups[1].Length)
                    .Insert(match.Groups[1].Index, actorInfo.Actor.DisplayString)
                : $"{ancestorProperty.Property.Type}.BackLink<{actorInfo.Actor}>";

            overrides.Add(new(overrideType, ancestorProperty));
        }

        return overrides.Count == 0 ? default : overrides.ToImmutableEquatableArray().Some();
    }

    private ImmutableEquatableArray<LinkProperty> GetLinkProperties(ActorsTask.ActorSymbols symbols)
    {
        using var logger = Logger.GetSubLogger(symbols.Actor.ToFullMetadataName()).WithCleanLogFile();

        var properties = new List<LinkProperty>();

        foreach
        (
            var property
            in symbols.Actor
                .GetMembers()
                .OfType<IPropertySymbol>()
                .Where(x =>
                    x.Type.Kind is SymbolKind.ErrorType
                )
        )
        {
            logger.Log($" - {property.Type}: {property.Name} ({property.Type.Kind})");

            var parts = property.Type.ToDisplayParts();

            var target = parts
                .FirstOrDefault(x => x.Kind is SymbolDisplayPartKind.InterfaceName);

            if (target.Symbol is null) continue;

            properties.Add(
                new LinkProperty(
                    target.Symbol.ToDisplayString(),
                    property.Type.ToDisplayString(),
                    property.Name,
                    property
                        .ExplicitInterfaceImplementations
                        .FirstOrDefault()?
                        .ContainingType
                        .ToDisplayString()
                )
            );
        }

        return properties.ToImmutableEquatableArray();
    }
}