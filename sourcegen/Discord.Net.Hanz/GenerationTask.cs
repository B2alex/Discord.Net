using System.Diagnostics;
using System.Reflection;
using Discord.Net.Hanz.Nodes;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz;

public abstract class GenerationTask
{
    private static readonly Dictionary<Type, GenerationTask> _tasks = [];
    
    public ILogger Logger { get; }
    
    public GenerationTask(IncrementalGeneratorInitializationContext context, ILogger logger)
    {
        Logger = logger;
    }

    public static void Initialize(IncrementalGeneratorInitializationContext context)
    {
        _tasks.Clear();

        var queue = new Queue<Type>(
            typeof(GenerationTask).Assembly.GetTypes()
                .Where(x => !x.IsAbstract && typeof(GenerationTask).IsAssignableFrom(x))
        );
            
        while (queue.Count > 0)
        {
            var type = queue.Dequeue();

            GetOrCreate(type, context);
        }
    }

    public T GetTask<T>(IncrementalGeneratorInitializationContext context) where T : GenerationTask
        => GetOrCreate<T>(context);

    private static T GetOrCreate<T>(IncrementalGeneratorInitializationContext context) where T : GenerationTask
        => (T)GetOrCreate(typeof(T), context);

    private static GenerationTask GetOrCreate(Type type, IncrementalGeneratorInitializationContext context)
    {
        lock (_tasks)
        {
            if (_tasks.TryGetValue(type, out var rawTask))
                return rawTask;

            var logger = Logging.GetLogger(new(type, typeof(Node).IsAssignableFrom(type) ? "Nodes" : "Tasks"));
        
            var instance = (GenerationTask) Activator.CreateInstance(type, context, logger);
            _tasks[type] = instance;
        
            logger.Flush();
        
            return instance;
        }
    }
}