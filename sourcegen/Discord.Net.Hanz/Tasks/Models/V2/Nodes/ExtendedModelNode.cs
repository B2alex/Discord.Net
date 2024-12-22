using System.Collections.Immutable;
using System.Text;
using System.Text.Json.SourceGeneration;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public sealed class ExtendedModelNode : Node
{
    public record ExtendedProperty(TypeRef ContainingType, string Name, TypeRef ExtendedType);

    public record Target(
        TypeRef Type,
        ImmutableEquatableArray<ExtendedProperty> ExtendedProperties,
        ImmutableEquatableArray<JsonModelsTask.JsonProperty> JsonProperties
    );

    public IncrementalGroupingProvider<TypeRef, ExtendedProperty> ExtendedPropertiesProvider { get; }


    public ExtendedModelNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        ExtendedPropertiesProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.JsonExtendAttribute",
                (node, _) => node is PropertyDeclarationSyntax,
                MapProperty
            )
            .WhereNotNull()
            .GroupBy(x => x.ContainingType);
    }

    public static TypeSpec CreateConverter(Target target)
    {
        var spec = new TypeSpec(
            $"Extended{target.Type.Name}Converter",
            TypeKind.Class,
            Bases: new([$"JsonConverter<{target.Type}>"]),
            Methods: new([
                CreateReadMethod(target),
                CreateWriteMethod(target)
            ])
        );

        return spec;
    }

    private static MethodSpec CreateWriteMethod(Target target)
    {
        var builder = new StringBuilder();

        if (target.ExtendedProperties.Count > 1 || target.JsonProperties.Count > 0)
        {
            builder.AppendLine(
                """
                JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options) as System.Text.Json.Nodes.JsonObject;
                    
                if(node is null) return;
                """
            );

            foreach (var extendedProperty in target.ExtendedProperties)
            {
                var nodeName = $"{extendedProperty.Name.ToParameterName()}Node";

                builder.AppendLine(
                    $$"""
                      if(JsonSerializer.SerializeToNode(value.{{extendedProperty.Name}}, options) is System.Text.Json.Nodes.JsonObject {{nodeName}})
                          foreach(var prop in {{nodeName}})
                              node.Add(prop);
                      """
                );
            }

            builder.AppendLine("node.WriteTo(writer, options);");
        }
        else
        {
            builder.AppendLine(
                $"JsonSerializer.Serialize(writer, value.{target.ExtendedProperties[0].Name}, options);"
            );
        }

        return new(
            "Write",
            "void",
            Accessibility.Public,
            new(["override"]),
            new([
                ("Utf8JsonWriter", "writer"),
                (target.Type.DisplayString, "value"),
                ("JsonSerializerOptions", "options")
            ]),
            Body: builder.ToString()
        );
    }

    private static MethodSpec CreateReadMethod(Target target)
    {
        var builder = new StringBuilder();

        if (target.JsonProperties.Count > 0)
        {
            builder.AppendLine(
                """
                using var jsonDocument = JsonDocument.ParseValue(ref reader);
                var element = jsonDocument.RootElement;
                var result = element.Deserialize(GetTypeInfoWithoutConverter(options));

                if(result is null) return null;
                """
            );

            foreach (var extended in target.ExtendedProperties)
            {
                builder.AppendLine(
                    $"result.{extended.Name} = element.Deserialize<{extended.ExtendedType}>(options)!;"
                );
            }
        }
        else
        {
            builder.AppendLine(
                $"var result = new {target.Type}();"
            );

            foreach (var extended in target.ExtendedProperties)
            {
                builder.AppendLine(
                    $"result.{extended.Name} = element.Deserialize<{extended.ExtendedType}>(ref reader, options)!;"
                );
            }
        }

        builder.AppendLine("return result;");


        return new MethodSpec(
            "Read",
            $"{target.Type}?",
            Accessibility.Public,
            new(["override"]),
            new([
                ("ref Utf8JsonReader", "reader"),
                ("Type", "typeToConvert"),
                ("JsonSerializerOptions", "options")
            ]),
            Body: builder.ToString()
        );
    }

    public static ExtendedProperty? MapProperty(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.Attributes.Length != 1) return null;

        if (
            context.TargetNode is not PropertyDeclarationSyntax ||
            context.TargetSymbol is not IPropertySymbol {ContainingType: not null} symbol
        ) return null;

        var attribute = context.Attributes[0];

        return new ExtendedProperty(
            new(symbol.ContainingType),
            symbol.Name,
            new(symbol.Type)
        );
    }
}