using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public record JsonModel(
    TypeRef Type,
    ImmutableEquatableArray<JsonProperty> Properties,
    ImmutableEquatableArray<TypeRef> ModelInterfaces,
    SyntaxReference Reference
)
{
    public SyntaxTree Mutate(CancellationToken token)
    {
        var syntax = (ClassDeclarationSyntax) Reference.GetSyntax(token);

        var propertySyntaxTable = syntax.Members
            .OfType<PropertyDeclarationSyntax>()
            .Where(x => x.ExplicitInterfaceSpecifier is null)
            .ToDictionary(x => x.Identifier.ValueText);

        var newPropertiesSyntax = new Dictionary<string, PropertyDeclarationSyntax>();

        foreach (var property in Properties)
        {
            if (!propertySyntaxTable.TryGetValue(property.Name, out var propertySyntax))
                continue;

            property.Process(ref propertySyntax);

            if (propertySyntax != propertySyntaxTable[property.Name])
                newPropertiesSyntax[property.Name] = propertySyntax;
        }

        if (newPropertiesSyntax.Count == 0)
            return Reference.SyntaxTree;

        var root = Reference.SyntaxTree.GetCompilationUnitRoot(token);

        return root
            .ReplaceNode(
                syntax,
                syntax.ReplaceNodes(
                    propertySyntaxTable.Values,
                    (_, node) =>
                        newPropertiesSyntax.TryGetValue(node.Identifier.ValueText, out var newNode)
                            ? newNode
                            : node
                )
            )
            .SyntaxTree;
    }
}

public record JsonProperty(
    string Name,
    string? JsonName,
    TypeRef Type,
    TypeRef? OptionalInnerType = null
)
{
    public bool IsOptional => Type.Name is "Optional" && OptionalInnerType is not null;

    public void Process(ref PropertyDeclarationSyntax syntax)
    {
        if (IsOptional)
        {
            ProcessOptional(ref syntax);
            return;
        }
    }

    private void ProcessOptional(ref PropertyDeclarationSyntax syntax)
    {
        syntax = syntax
            .WithAttributeLists(
                syntax.AttributeLists.Add(
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SeparatedList([
                            SyntaxFactory.Attribute(
                                SyntaxFactory.IdentifierName("JsonIgnore"),
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SeparatedList([
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.NameEquals("Condition"),
                                            null,
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                SyntaxFactory.IdentifierName("JsonIgnoreCondition"),
                                                SyntaxFactory.IdentifierName("WhenWritingDefault")
                                            )
                                        )
                                    ])
                                )
                            ),
                            SyntaxFactory.Attribute(
                                SyntaxFactory.IdentifierName("JsonConverter"),
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SeparatedList([
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.TypeOfExpression(
                                                SyntaxFactory.ParseTypeName($"Discord.Converters.OptionalConverter<{OptionalInnerType}>")
                                            )
                                        )
                                    ])
                                )
                            ),
                        ])
                    )
                )
            );
    }
}

public sealed class JsonModelNode : Node
{
    public IncrementalValuesProvider<JsonModel> ModelsProvider { get; }

    public JsonModelNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        ModelsProvider = context.SyntaxProvider
            .CreateSyntaxProvider(
                (node, _) => node is ClassDeclarationSyntax,
                MapModel
            )
            .WhereNotNull();
    }

    private static JsonModel? MapModel(GeneratorSyntaxContext context, CancellationToken token)
    {
        if (context.Node is not ClassDeclarationSyntax syntax)
            return null;

        if (context.SemanticModel.GetDeclaredSymbol(syntax, token) is not INamedTypeSymbol symbol)
            return null;

        if (context.SemanticModel.Compilation.Assembly.Name is not "Discord.Net.Models")
            return null;

        if (!HasIModelInterface(symbol))
            return null;

        var props = symbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x =>
                x.DeclaredAccessibility is Accessibility.Public &&
                x.GetAttributes()
                    .All(x => x.AttributeClass?.Name is not "JsonIgnore" || x.ConstructorArguments.Length == 0)
            )
            .Select(x =>
                new JsonProperty(
                    x.Name,
                    GetJsonName(x),
                    new(x.Type),
                    x.Type is INamedTypeSymbol {Name: "Optional", TypeArguments.Length: 1} opt
                        ? new(opt.TypeArguments[0])
                        : null
                )
            )
            .ToImmutableEquatableArray();

        if (props.Count == 0) return null;

        return new(
            new(symbol),
            props,
            symbol.AllInterfaces.Where(IsModelingInterface).Select(x => new TypeRef(x)).ToImmutableEquatableArray(),
            syntax.GetReference()
        );
    }

    private static string? GetJsonName(IPropertySymbol symbol)
        => symbol
            .GetAttributes()
            .FirstOrDefault(x => x.AttributeClass?.Name is "JsonPropertyName")
            ?.ConstructorArguments
            .FirstOrDefault()
            .Value as string;

    private static bool IsModelingInterface(ITypeSymbol symbol)
        => symbol.TypeKind is TypeKind.Interface && HasIModelInterface(symbol) &&
           symbol.Name is not "IEntityModel" and "IModel";

    private static bool HasIModelInterface(ITypeSymbol symbol)
        => symbol.AllInterfaces.Any(x => x.ToDisplayString() == "Discord.Models.IModel");
}