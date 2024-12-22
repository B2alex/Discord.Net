using System.Diagnostics.Tracing;
using Discord.Net.Hanz;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using ILogger = Serilog.ILogger;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .MinimumLevel.Verbose()
    .WriteTo.Console(
        outputTemplate: "{Timestamp:HH:mm:ss} | {Level} - [{SourceContext}]: {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

var logger = Log.Logger.ForContext<Program>();

var listener = new Listener();

MSBuildLocator.RegisterDefaults();

using var workspace = MSBuildWorkspace.Create();

var proj = await workspace.OpenProjectAsync(
    @"C:\Users\lynch\Documents\GitHub\Discord.Net\src\Discord.Net.V4.Core\Discord.Net.V4.Core.csproj");

logger.Information("Loaded project {Proj}", proj.Id);

Console.WriteLine($"Loaded {proj.Id}");

var hanz = new Hanz();

GeneratorDriver driver = CSharpGeneratorDriver.Create(hanz);


var compilation = await proj.GetCompilationAsync();

logger.Information("Created compilation with {Trees} trees", compilation?.SyntaxTrees.Count());

if (compilation is null) return;

driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var newCompilation, out var diagnostics);

logger.Information("{Diag} diagnostics", diagnostics.Length);

foreach (var diag in diagnostics)
{
    logger.Information("{ID}: {Msg}", diag.Id, diag.GetMessage());
}

var result = driver.GetRunResult();

logger.Information("New trees: {Trees}", result.GeneratedTrees.Length);



class Listener : EventListener
{
    private static string[] _enabledSources =
    [
        "Microsoft-CodeAnalysis-General"
    ];
    
    private readonly Dictionary<Guid, ILogger> _loggers = [];
    private readonly object _loggersLock = new object();

    private readonly ILogger _logger = Log.Logger.ForContext<Listener>();

    protected override void OnEventSourceCreated(EventSource eventSource)
    {
        _logger.Information("New event source: {Id} : {Name}", eventSource.Guid, eventSource.Name);

        if (!_enabledSources.Contains(eventSource.Name)) return;
        
        GetForSource(eventSource);
        EnableEvents(eventSource, EventLevel.Verbose);

        base.OnEventSourceCreated(eventSource);
    }

    private ILogger GetForSource(EventSource source)
    {
        lock (_loggersLock)
        {
            if (_loggers.TryGetValue(source.Guid, out var logger))
                return logger;

            return _loggers[source.Guid] = Log.Logger.ForContext(Constants.SourceContextPropertyName, source.Name);
        }
    }

    protected override void OnEventWritten(EventWrittenEventArgs eventData)
    {
        if (eventData.Message is null) return;
        
        var logger = GetForSource(eventData.EventSource);
        
        logger.Write(
            eventData.Level switch
            {
                EventLevel.Critical => LogEventLevel.Fatal,
                EventLevel.Error => LogEventLevel.Error,
                EventLevel.Informational => LogEventLevel.Information,
                EventLevel.Verbose => LogEventLevel.Verbose,
                EventLevel.Warning => LogEventLevel.Warning,
                _ => LogEventLevel.Information
            },
            eventData.Message,
            propertyValues: eventData.Payload?.ToArray()
        );
    }
}