using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Meta;

public sealed class ExtendInterfaceDefaults : GenerationTask
{
    // private sealed record Target(
    //     TypeRef Type,
    //     ImmutableEquatableArray<>
    // );

    public ExtendInterfaceDefaults(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context,
        logger)
    {
        // context
        //     .SyntaxProvider
        //     .ForAttributeWithMetadataName(
        //         "Discord.ExtendInterfaceDefaultsAttribute",
        //         (node, _) => node is ClassDeclarationSyntax,
        //         Map
        //     )
        //     .WhereNonNull();
    }

    // private static Target? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    // {
    //     if (context.TargetSymbol is not INamedTypeSymbol symbol)
    //         return null;
    //
    //     if (context.TargetNode is not ClassDeclarationSyntax syntax)
    //         return null;
    //
    //     if (syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
    //         return null;
    //
    //     if (context.Attributes.Length != 1)
    //         return null;
    //
    //     var attribute = context.Attributes[0];
    //
    //     var toExtend = GetTypesToExtend(symbol, attribute).ToArray();
    //
    //     if (toExtend.Length == 0)
    //         return null;
    //
    //     var members = GetMembersForExtending(toExtend).ToArray();
    //
    //     if (members.Length == 0)
    //         return null;
    // }

    private static IEnumerable<ISymbol> GetMembersForExtending(INamedTypeSymbol[] symbols)
    {
        foreach (var symbol in symbols)
        foreach (var member in symbol.GetMembers())
        {
            if (member.IsStatic || !member.IsVirtual || (member.IsAbstract || member.IsVirtual))
                continue;

            switch (member)
            {
                case IPropertySymbol {ExplicitInterfaceImplementations.Length: 0}:
                    yield return member;
                    break;
                case IMethodSymbol {ExplicitInterfaceImplementations.Length: 0, MethodKind: MethodKind.Ordinary}:
                    yield return member;
                    break;
            }
        }
    }

    private static IEnumerable<INamedTypeSymbol> GetTypesToExtend(INamedTypeSymbol symbol, AttributeData attribute)
    {
        var userSpecifiedExtendedTypes = attribute.ConstructorArguments.FirstOrDefault();
        var extendAll = attribute.NamedArguments
            .FirstOrDefault(x => x.Key == "ExtendAll")
            .Value.Value as bool? ?? false;

        if (extendAll)
            return symbol.AllInterfaces;

        if (userSpecifiedExtendedTypes.Kind is TypedConstantKind.Array)
            return userSpecifiedExtendedTypes.Values.Select(x => x.Value).OfType<INamedTypeSymbol>();

        return symbol.Interfaces;
    }
}