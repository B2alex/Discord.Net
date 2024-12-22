using System.Collections.Immutable;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Meta;

public sealed class InterfaceProxy : GenerationTask
{
    private sealed record Target(
        string PropertyName,
        ImmutableEquatableArray<string> Usings,
        TypeRef ContainingType,
        ImmutableEquatableArray<Proxied> Proxies
    );

    private sealed record Proxied(
        TypeRef Interface,
        ImmutableEquatableArray<OverrideTarget> Overrides
    );

    private abstract record OverrideTarget();

    private sealed record PropertyOverrdeTarget(
        PropertySpec Spec
    ) : OverrideTarget
    {
        public PropertySpec MapTo(TypeRef interfaceRef, string propertyName)
        {
            var spec = Spec with
            {
                ExplicitInterfaceImplementation = interfaceRef.ReferenceName
            };

            if (Spec.HasGetter && Spec.HasSetter)
                return spec with
                {
                    Getter = $"{propertyName}.{Spec.Name}",
                    Setter = $"{propertyName}.{Spec.Name} = value"
                };

            return spec with {Expression = $"{propertyName}.{Spec.Name}"};
        }
    }

    private sealed record MethodOverrideTarget(
        MethodSpec Spec,
        bool IsAsync
    ) : OverrideTarget
    {
        public MethodSpec MapTo(TypeRef interfaceRef, string propertyName)
        {
            var invocation = $"{propertyName}.{Spec.ToInvocationString()}";

            var modifiers = Spec
                .Modifiers
                .Intersect(["static"])
                .ToImmutableEquatableArray();

            if (IsAsync)
            {
                invocation = $"await {invocation}";
                modifiers = modifiers.Add("async");
            }

            var spec = Spec with
            {
                ExplicitInterfaceImplementation = interfaceRef.ReferenceName,
                Modifiers = modifiers,
                Expression = invocation
            };

            return spec;
        }
    }

    public InterfaceProxy(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        context.RegisterSourceOutput(
            context
                .SyntaxProvider
                .ForAttributeWithMetadataName(
                    "Discord.ProxyInterfaceAttribute",
                    (node, _) => node is PropertyDeclarationSyntax,
                    Map
                )
                .WhereNotNull()
                .GroupBy(x => x.ContainingType)
                .Select(CreateSourceSpec)
        );
    }

    private static SourceSpec CreateSourceSpec(TypeRef type, ImmutableArray<Target> targets)
    {
        var spec = TypeSpec.From(type).AddModifiers("partial");

        foreach (var target in targets)
        foreach (var proxy in target.Proxies)
        {
            AddProxy(ref spec, target.PropertyName, proxy);
        }

        return new SourceSpec(
            $"InterfaceProxy/{type.MetadataName}",
            type.Namespace,
            targets.SelectMany(x => x.Usings).Distinct().ToImmutableEquatableArray(),
            new([spec])
        );


        static void AddProxy(ref TypeSpec spec, string property, Proxied proxy)
        {
            spec = spec
                .AddProperties(proxy
                    .Overrides
                    .OfType<PropertyOverrdeTarget>()
                    .Select(x => x.MapTo(proxy.Interface, property))
                )
                .AddMethods(proxy
                    .Overrides
                    .OfType<MethodOverrideTarget>()
                    .Select(x => x.MapTo(proxy.Interface, property))
                );
        }
    }

    private static Target? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (
            context.TargetSymbol is not IPropertySymbol
            {
                ContainingType: not null,
                ExplicitInterfaceImplementations.Length: 0
            } propertySymbol
        ) return null;

        if (context.TargetNode is not PropertyDeclarationSyntax {Parent: TypeDeclarationSyntax parent})
            return null;

        if (parent.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
            return null;

        if (context.Attributes.Length != 1)
            return null;

        var interfacesParameter = context.Attributes[0].ConstructorArguments.FirstOrDefault();

        var targetInterfaces = interfacesParameter.Kind is TypedConstantKind.Array
            ? interfacesParameter.Values
                .Select(x => x.Value)
                .OfType<INamedTypeSymbol>()
                .ToArray()
            : propertySymbol.Type.AllInterfaces
                .Intersect(propertySymbol.ContainingType.AllInterfaces)
                .ToArray();

        if (targetInterfaces.Length == 0)
            return null;

        var proxies = CreateProxiedTargets(targetInterfaces).ToImmutableEquatableArray();

        if (proxies.Count == 0)
            return null;

        return new Target(
            propertySymbol.Name,
            context.TargetNode.GetUsingDirectivesSyntax()
                .Select(x => x.Name?.ToString())
                .Where(x => x is not null)
                .ToImmutableEquatableArray(),
            new(propertySymbol.ContainingType),
            proxies
        );
    }

    private static IEnumerable<Proxied> CreateProxiedTargets(INamedTypeSymbol[] symbols)
    {
        var actualSymbols = symbols
            .SelectMany(IEnumerable<INamedTypeSymbol> (x) => [x, ..x.AllInterfaces])
            .Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default)
            .ToArray();

        var overrideTargets = new List<OverrideTarget>();

        foreach (var symbol in actualSymbols)
        {
            overrideTargets.Clear();

            foreach (var member in symbol.GetMembers())
            {
                if (member.IsSealed || !(member.IsAbstract || member.IsVirtual))
                    continue;

                switch (member)
                {
                    case IPropertySymbol {ExplicitInterfaceImplementations.Length: 0} property:
                        overrideTargets.Add(new PropertyOverrdeTarget(
                            PropertySpec.From(property)
                        ));
                        break;
                    case IMethodSymbol
                    {
                        ExplicitInterfaceImplementations.Length: 0,
                        MethodKind: MethodKind.Ordinary
                    } method:
                        overrideTargets.Add(new MethodOverrideTarget(
                            MethodSpec.From(method),
                            method.ReturnType is {Name: "Task" or "ValueTask"}
                        ));
                        break;
                }
            }

            if (overrideTargets.Count > 0)
                yield return new Proxied(new(symbol), overrideTargets.ToImmutableEquatableArray());

            overrideTargets.Clear();
        }
    }
}