using System.Collections.Immutable;
using System.Text;
using System.Text.Json.SourceGeneration;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Discord.Net.Hanz;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

using CompilationAndModels = (Microsoft.CodeAnalysis.Compilation compilation, ImmutableArray<JsonModel> Models);

public class STJSourceGeneratorNode : Node
{
    private GeneratorDriver _driver;
    private readonly JsonSourceGenerator _generator;

    private record DriverParameters(
        Compilation Compilation,
        ImmutableEquatableArray<JsonModel> Models
    );
    
    public STJSourceGeneratorNode(IncrementalGeneratorInitializationContext context, ILogger logger)
        : base(context, logger)
    {
        _generator = new();
        _driver = CSharpGeneratorDriver.Create(_generator);

        var modelsProvider = GetNode<JsonModelNode>()
            .ModelsProvider
            .Collect();

        var contextTypeProvider = modelsProvider.Select(CreateContextType);
        var stjCompilationProvider = context.CompilationProvider
            .Combine(modelsProvider)
            .Select(CreateDriverCompilation);

        var stjGeneratorResultProvider = stjCompilationProvider
            .Combine(contextTypeProvider)
            .Select((tuple, _) =>
            {
                var (compilation, contextType) = tuple;

                return compilation.AddSyntaxTrees(
                    CSharpSyntaxTree.ParseText(
                        contextType,
                        encoding: Encoding.UTF8,
                        options: (CSharpParseOptions) compilation.SyntaxTrees.First().Options
                    )!
                );
            })
            .Select(RunSTJGenerator);

        context.RegisterSourceOutput(
            stjGeneratorResultProvider,
            ProcessGenerationResult
        );

        context.RegisterSourceOutput(
            contextTypeProvider,
            (ctx, contextType) => ctx.AddSource("Json/Context.g.cs", contextType)
        );
    }

    private string CreateContextType(
        ImmutableArray<JsonModel> models,
        CancellationToken token
    )
    {
        var resolverSpec = JsonModelsTask.CreateResolverSpec();

        return
            $"""
             using System.Text.Json;
             using System.Text.Json.Serialization;
             using System.Text.Json.Serialization.Metadata;
             using Discord.Models;
             using Discord.Models.Json;

             namespace Discord.Models;


             {
                 string.Join(
                     Environment.NewLine,
                     models.Select(x =>
                         $"[System.Text.Json.Serialization.JsonSerializable(typeof({x.Type}))]"
                     )
                 )
             }
             {resolverSpec}
             """;
    }

    private Compilation CreateDriverCompilation(
        CompilationAndModels args,
        CancellationToken token
    )
    {
        var (compilation, models) = args;

        foreach (var model in models)
        {
            compilation = compilation.ReplaceSyntaxTree(model.Reference.SyntaxTree, Mutate(model, token));
        }

        return compilation;
    }

    private SyntaxTree Mutate(JsonModel model, CancellationToken token)
        => model.Mutate(token);

    private void ProcessGenerationResult(SourceProductionContext context, GeneratorDriverRunResult generatorResult)
    {
        foreach (var result in generatorResult.Results)
        foreach (var source in result.GeneratedSources)
        {
            Logger.Log($"+ {source.HintName}");

//             if (AddNoConverterInfos.TryGetValue(
//                     source.HintName.Replace("ModelJsonContext.", string.Empty).Replace(".g.cs", string.Empty),
//                     out var targetRef))
//             {
//                 var methodSyntax = source.SyntaxTree.GetRoot(context.CancellationToken)
//                     .DescendantNodes()
//                     .OfType<MethodDeclarationSyntax>()
//                     .FirstOrDefault(x => x.Identifier.ValueText == $"Create_{targetRef.Name}");
//
//                 if (methodSyntax is null) continue;
//
//                 var typeInfoInit = methodSyntax
//                     .DescendantNodes()
//                     .OfType<IfStatementSyntax>()
//                     .FirstOrDefault()
//                     ?.ChildNodes()
//                     .OfType<BlockSyntax>()
//                     .FirstOrDefault();
//
//                 if (typeInfoInit is null) continue;
//
//                 resolverSpec = resolverSpec.AddMethods(
//                     new MethodSpec(
//                         $"Create{targetRef.Name}TypeInfoNoConverter",
//                         $"global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::{targetRef}>",
//                         Accessibility.Internal,
//                         Parameters: new([
//                             ("global::System.Text.Json.JsonSerializerOptions", "options")
//                         ]),
//                         Body:
//                         $"""
//                          global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::{targetRef}> jsonTypeInfo;
//
//                          {string.Join(Environment.NewLine, typeInfoInit.Statements)}
//
//                          jsonTypeInfo.OriginatingResolver = this;
//                          return jsonTypeInfo;
//                          """
//                     )
//                 );
//             }

            context.AddSource(source.HintName, source.SourceText);
        }
    }

    private GeneratorDriverRunResult RunSTJGenerator(Compilation compilation, CancellationToken token)
    {
        _driver = _driver.RunGenerators(compilation, token);
        return _driver.GetRunResult();
    }
}