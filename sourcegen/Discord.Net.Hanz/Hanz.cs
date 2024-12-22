using Discord.Net.Hanz.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using Discord.Net.Hanz.Nodes;

namespace Discord.Net.Hanz;

[Generator(LanguageNames.CSharp)]
public sealed class Hanz : IIncrementalGenerator
{
    private readonly MethodInfo _registerTaskMethod = typeof(Hanz).GetMethods(BindingFlags.Static | BindingFlags.Public)
        .First(x => x.Name.StartsWith("RegisterTask"));

    private readonly MethodInfo _registerCombineTaskMethod = typeof(Hanz)
        .GetMethods(BindingFlags.Static | BindingFlags.Public).First(x => x.Name.StartsWith("RegisterCombineTask"));

    public static void RegisterTask<T>(IncrementalGeneratorInitializationContext context, ISyntaxGenerationTask<T> task)
        where T : class, IEquatable<T>
    {
        var logger = Logging.GetLogger<T>();

        var provider = context.SyntaxProvider.CreateSyntaxProvider(
            predicate: task.IsValid,
            transform: (syntaxContext, token) => task.GetTargetForGeneration(
                syntaxContext,
                logger,
                token
            )
        );

        context.RegisterSourceOutput(provider, (context, state) => task.Execute(context, state, logger));
    }

    public static void RegisterCombineTask<T>(IncrementalGeneratorInitializationContext context,
        ISyntaxGenerationCombineTask<T> task)
        where T : class, IEquatable<T>
    {
        var logger = Logging.GetLogger<T>();

        var provider = context.SyntaxProvider.CreateSyntaxProvider(
            predicate: task.IsValid,
            transform: (syntaxContext, token) => task.GetTargetForGeneration(
                syntaxContext,
                logger,
                token
            )
        ).Collect();

        context.RegisterSourceOutput(provider, (productionContext, array) =>
        {
            logger.Clean();
            task.Execute(productionContext, array, logger);
        });
    }

    private static bool IsGenerationTask(Type type)
    {
        return type.IsGenericType && (
            type.GetGenericTypeDefinition() == typeof(ISyntaxGenerationTask<>) ||
            type.GetGenericTypeDefinition() == typeof(ISyntaxGenerationCombineTask<>)
        );
    }

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        try
        {
            SetupLogger(context);

            GenerationTask.Initialize(context);

            var generationTasks = typeof(Hanz).Assembly.GetTypes()
                .Where(x => x
                    .GetInterfaces()
                    .Any(IsGenerationTask)
                );

            foreach (var task in generationTasks)
            {
                var generationInterface = task.GetInterfaces().FirstOrDefault(IsGenerationTask);

                if (generationInterface is null) continue;

                if (generationInterface.GetGenericTypeDefinition() == typeof(ISyntaxGenerationTask<>))
                    _registerTaskMethod.MakeGenericMethod(generationInterface.GenericTypeArguments[0])
                        .Invoke(null, [context, Activator.CreateInstance(task)]);
                else if (generationInterface.GetGenericTypeDefinition() == typeof(ISyntaxGenerationCombineTask<>))
                    _registerCombineTaskMethod.MakeGenericMethod(generationInterface.GenericTypeArguments[0])
                        .Invoke(null, [context, Activator.CreateInstance(task)]);
            }

            // context.RegisterSourceOutput(
            //     context.SyntaxProvider
            //         .CreateSyntaxProvider(
            //             (node, _) => node is ClassDeclarationSyntax,
            //             (context, _) => JsonModels.GetTarget(context)
            //         )
            //         .Collect()
            //         .Combine(context.CompilationProvider)
            //         .Combine(context.AnalyzerConfigOptionsProvider.Select((options, _) =>
            //         {
            //             TryGetProjectName(options, out var projectName);
            //             options.GlobalOptions.TryGetValue("build_property.RootNamespace", out var rootNameSpace);
            //             return (ProjectName: projectName, RootNameSpace: rootNameSpace);
            //         })),
            //     (productionContext, data) =>
            //     {
            //         var friendlyName = data.Right.ProjectName ?? data.Right.RootNameSpace;
            //
            //         JsonModels.Execute(
            //             productionContext,
            //             data.Left,
            //             data.Right.ProjectName,
            //             data.Right.RootNameSpace,
            //             logger.WithCleanLogFile()
            //         );
            //         logger.Flush();
            //     }
            // );
        }
        catch (Exception x)
        {
            SelfLog.Write($"Failed to initialize {x}");
            throw;
        }
    }

    private void SetupLogger(
        IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(
            context
                .AnalyzerConfigOptionsProvider
                .Select((options, _) =>
                {
                    if (!options.GlobalOptions.TryGetValue("build_property.HanzLogLevel",
                            out var logLevelValue)
                        || !Enum.TryParse(logLevelValue, true, out LogLevel logLevel))
                    {
                        logLevel = LogLevel.Information;
                    }

                    if (!options.GlobalOptions.TryGetValue("build_property.ProjectDir", out var dir))
                        dir = null;

                    return (logLevel, dir);
                }),
            (_, opt) =>
            {
                if (opt.dir is not null)
                    Logging.InitializeFileLogging(Path.Combine(opt.dir, ".hanz"), opt.logLevel);
            }
        );
    }
}