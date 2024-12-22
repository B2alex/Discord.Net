using System.Collections;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.EntityProperties;

public sealed class EntityPropertiesTask : GenerationTask
{
    public readonly record struct EntityProperties(
        TypeRef Type,
        TypeRef ParamsType,
        ImmutableEquatableArray<EntityProperty> Properties,
        ImmutableEquatableArray<string> Inherited
    );

    public readonly record struct EntityProperty(
        string Name,
        TypeRef Type,
        bool IsRequired
    );

    public readonly record struct EntityPropertiesWithInheritance(
        EntityProperties Source,
        ImmutableEquatableArray<EntityProperties> Inherited
    ) : IEnumerable<EntityProperties>
    {
        public IEnumerable<EntityProperty> AllProperties
            => [..Source.Properties, ..Inherited.SelectMany(x => x.Properties)];

        public IEnumerator<EntityProperties> GetEnumerator()
        {
            yield return Source;

            foreach (var inherited in Inherited)
            {
                yield return inherited;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public IncrementalKeyValueProvider<string, EntityProperties> Properties { get; }

    public IncrementalKeyValueProvider<string, EntityPropertiesWithInheritance> PropertiesWithInherited { get; }

    public EntityPropertiesTask(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context,
        logger)
    {
        Properties = context.SyntaxProvider
            .CreateSyntaxProvider(
                IsValid,
                Map
            )
            .WhereNotNull()
            .KeyedBy(x => x.Type.DisplayString);

        PropertiesWithInherited = Properties
            .MapValues((key, value) =>
                new EntityPropertiesWithInheritance(
                    value,
                    value.Inherited
                        .Where(Properties.ContainsKey)
                        .Select(Properties.GetValueOrDefault)
                        .ToImmutableEquatableArray()
                )
            );
    }

    private EntityProperties? Map(GeneratorSyntaxContext context, CancellationToken token)
    {
        if (context.SemanticModel.GetDeclaredSymbol(context.Node, token) is not INamedTypeSymbol symbol)
            return null;

        if (!IsEntityProperties(symbol))
        {
            return null;
        }

        var properties = symbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x => x.DeclaredAccessibility is Accessibility.Public)
            .Select(x => new EntityProperty(x.Name, new(x.Type), x.IsRequired))
            .ToImmutableEquatableArray();

        if (
            !symbol.HierarchyDFS(
                x => x is {Name: "IEntityProperties", TypeArguments.Length: 1},
                out var entityProperties
            )
        )
        {
            Logger.Warn($"Missing IEntityProperties for {symbol}");
            Logger.Flush();
            return null;
        }
        
        var result = new EntityProperties(
            new(symbol),
            new(entityProperties.TypeArguments[0]),
            properties,
            TypeUtils.GetBaseTypes(symbol)
                .Where(IsEntityProperties)
                .Select(x => x.ToDisplayString())
                .ToImmutableEquatableArray()
        );


        Logger.Log($"{symbol} mapped to {result}");
        Logger.Flush();

        return result;
    }

    private static bool IsEntityProperties(ITypeSymbol symbol)
    {
        return symbol.AllInterfaces.Any(x => x is {Name: "IEntityProperties", TypeArguments.Length: 1});
    }

    private static bool IsValid(SyntaxNode node, CancellationToken token)
    {
        return node is ClassDeclarationSyntax;
    }
}