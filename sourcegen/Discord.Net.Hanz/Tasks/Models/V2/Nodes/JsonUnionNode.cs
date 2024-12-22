using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public sealed class JsonUnionNode : Node
{
    public const string UnionPropertyAttribute = "Discord.DiscriminatedUnionAttribute";
    public const string UnionEntryAttribute = "Discord.DiscriminatedUnionEntryAttribute";
    public const string UnionTypeRootAttribute = "Discord.DiscriminatedUnionRootTypeAttribute";
    public const string UnionTypeAttribute = "Discord.DiscriminatedUnionTypeAttribute";

    public record UnionProperty(
        TypeRef ContainingType,
        TypeRef UnionRoot,
        string PropertyName,
        string UnionPropertyName,
        ImmutableEquatableArray<UnionEntry> Entries
    );

    public record UnionEntry(TypeRef Type, object[] Cases);

    public IncrementalGroupingProvider<TypeRef, UnionProperty> UnionsProvider { get; }

    public JsonUnionNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        UnionsProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                UnionPropertyAttribute,
                (node, _) => node is PropertyDeclarationSyntax,
                MapUnionProperty
            )
            .WhereNotNull()
            .GroupBy(x => x.ContainingType);
    }

    private UnionProperty? MapUnionProperty(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.TargetSymbol is not IPropertySymbol {ContainingType: { } containingTypeSymbol} symbol)
            return null;

        if (symbol.ExplicitInterfaceImplementations.Length > 0) return null;

        if (context.Attributes.Length != 1)
            return null;

        var attribute = context.Attributes[0];

        if (attribute.ConstructorArguments.Length != 1)
            return null;

        var targetPropertyName = attribute.ConstructorArguments[0].Value?.ToString();

        if (targetPropertyName is null || !HasTargetProperty(targetPropertyName)) return null;

        if (!TryGetEntries(out var entries))
            return null;

        return new(
            new(containingTypeSymbol),
            new(symbol.Type),
            symbol.Name,
            targetPropertyName,
            entries
        );

        bool HasTargetProperty(string name)
            => TypeUtils
                .GetBaseTypesAndThis(containingTypeSymbol)
                .SelectMany(x => x.GetMembers().OfType<IPropertySymbol>())
                .Any(x => x.Name == name && x.ExplicitInterfaceImplementations.Length == 0);

        bool TryGetEntries(out ImmutableEquatableArray<UnionEntry> entries)
        {
            entries = symbol
                .GetAttributes()
                .Where(x =>
                    x.AttributeClass?.ToDisplayString() == UnionEntryAttribute &&
                    x.AttributeClass.TypeArguments.Length == 1 &&
                    x.ConstructorArguments.Length == 1
                )
                .Select(x =>
                    new UnionEntry(
                        new(x.AttributeClass!.TypeArguments[0]),
                        x.ConstructorArguments[0].Values.Select(x => x.Value).ToArray()!
                    )
                )
                .ToImmutableEquatableArray();

            return entries.Count > 0;
        }
    }
}