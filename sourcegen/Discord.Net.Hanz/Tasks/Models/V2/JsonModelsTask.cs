using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2;

public class JsonModelsTask : GenerationTask
{
    public record JsonProperty(
        TypeRef ContainingType,
        string JsonName,
        string Name,
        TypeRef Type
    );

    public IncrementalGroupingProvider<TypeRef, JsonProperty> JsonModels { get; }
    
    public JsonModelsTask(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        JsonModels = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "System.Text.Json.Serialization.JsonPropertyNameAttribute",
                (node, _) => node is PropertyDeclarationSyntax,
                MapProperty
            )
            .WhereNotNull()
            .GroupBy(x => x.ContainingType);
    }

    public static JsonProperty? MapProperty(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.Attributes.Length != 1) return null;

        if (
            context.TargetNode is not PropertyDeclarationSyntax ||
            context.TargetSymbol is not IPropertySymbol {ContainingType: not null} symbol
        ) return null;

        var attribute = context.Attributes[0];

        if (attribute.ConstructorArguments.Length == 0) return null;

        var jsonName = attribute.ConstructorArguments[0].Value?.ToString();

        if (string.IsNullOrWhiteSpace(jsonName)) return null;

        return new JsonProperty(
            new(symbol.ContainingType),
            jsonName!,
            symbol.Name,
            new(symbol.Type)
        );
    }

    public static TypeSpec CreateResolverSpec()
    {
        return new TypeSpec(
            "ModelJsonContext",
            TypeKind.Class,
            Modifiers: new(["sealed", "partial"]),
            Bases: new(["JsonSerializerContext"])
        );
    }
}