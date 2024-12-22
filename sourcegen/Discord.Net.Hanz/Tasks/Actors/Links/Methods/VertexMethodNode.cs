using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Methods;

public sealed class VertexMethodNode : Node
{
    private record Context(
        string Actor,
        MethodTemplateSpec Spec,
        string? MethodName
    )
    {
        public MethodSpec BuildMethodSpec()
            => Spec.Template with
            {
                Expression = Spec.Expression,
                Body = Spec.Body,
                Name = MethodName ?? Spec.Template.Name,
                Parameters = new([
                    Spec.Template.Parameters[0] with {Type = $"this {Spec.Template.Parameters[0].Type}"},
                    ..Spec.Template.Parameters.Skip(1)
                ])
            };
    }

    public VertexMethodNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        context.RegisterSourceOutput(
            context
                .SyntaxProvider
                .ForAttributeWithMetadataName(
                    "Discord.OnVertexAttribute",
                    (node, _) => node is MethodDeclarationSyntax,
                    Map
                )
                .WhereNotNull()
                .GroupBy(x => x.Actor)
                .TransformKeysVia(GetTask<ActorsTask>().ActorInfos)
                .MapValues((_, context) => (context.Spec.Usings, Spec: context.BuildMethodSpec()))
                .Select((actorInfo, methods) =>
                    new SourceSpec(
                        $"LinkMethods/Vertex_{actorInfo.Actor.MetadataName}",
                        actorInfo.Actor.Namespace!,
                        methods.SelectMany(x => x.Usings).Distinct().ToImmutableEquatableArray(),
                        new([
                            new TypeSpec(
                                $"{actorInfo.Actor.Name}VertexExtensions",
                                TypeKind.Class,
                                Modifiers: new([
                                    "static"
                                ]),
                                Methods: methods.Select(x => x.Spec).ToImmutableEquatableArray()
                            )
                        ])
                    )
                )
        );
    }


    private static Context? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context.TargetNode is not MethodDeclarationSyntax syntax)
            return null;

        if (syntax.Parent is not TypeDeclarationSyntax typeSyntax)
            return null;

        if (context.SemanticModel.GetDeclaredSymbol(typeSyntax) is not { } symbol)
            return null;

        if (context.TargetSymbol is not IMethodSymbol methodSymbol)
            return null;

        if (methodSymbol.Parameters.Length == 0)
            return null;

        if (syntax.Modifiers.IndexOf(SyntaxKind.StaticKeyword) == -1)
            return null;

        if (MapSpec(syntax, methodSymbol) is not { } template)
            return null;

        return new(
            symbol.ToDisplayString(),
            template,
            context.Attributes[0].ConstructorArguments.FirstOrDefault().Value as string
        );
    }

    private static MethodTemplateSpec? MapSpec(
        MethodDeclarationSyntax syntax,
        IMethodSymbol symbol
    )
    {
        var methodImpl =
            (SyntaxNode?) syntax.Body
            ?? syntax.ExpressionBody;

        if (methodImpl is null) return null;

        var template = methodImpl.ToString();

        if (syntax.Body is not null)
        {
            template = template
                .Remove(0, 1)
                .Remove(template.Length - 2, 1);

            var split = template.Split([Environment.NewLine], StringSplitOptions.None);

            if (split.Length > 0)
            {
                var max = split.Where(x => !string.IsNullOrWhiteSpace(x))
                    .Min(x => x.TakeWhile(char.IsWhiteSpace).Count());
                template = string.Join(Environment.NewLine, split.Select(x => x.Length >= max ? x.Remove(0, max) : x));
            }
        }

        return new MethodTemplateSpec(
            syntax.Body is not null
                ? template
                : null,
            syntax.ExpressionBody is not null ? template : null,
            syntax
                .GetUsingDirectivesSyntax()
                .Select(x => x.Name?.ToString())
                .Where(x => x is not null)!
                .ToImmutableEquatableArray<string>(),
            MethodSpec.From(symbol) with
            {
                Accessibility = Accessibility.Public,
                Modifiers = new([
                    "static",
                    ..syntax.Modifiers.IndexOf(SyntaxKind.AsyncKeyword) != -1 ? (string[]) ["async"] : []
                ])
            }
        );
    }
}