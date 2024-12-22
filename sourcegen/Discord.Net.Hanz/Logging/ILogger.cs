namespace Discord.Net.Hanz;

public enum LogLevel
{
    Trace = 0,
    Debug = 1,
    Information = 2,
    Warning = 3,
    Error = 4,
    None = 5
}

public readonly struct FlushScope(ILogger logger) : IDisposable
{
    public void Dispose() => logger?.Flush();
}

public interface ILogger : IDisposable
{
    LogContext Context { get; }
    
    bool IsEnabled(LogLevel logLevel);
    void Log(LogLevel logLevel, string message);

    void Clean();
    void Flush();
}

// does what it supposed to do - nothing
public sealed class NullLogger(LogContext context) : ILogger
{
    public static readonly ILogger Instance = new NullLogger(new(typeof(NullLogger)));

    public LogContext Context { get; } = context;
    public bool IsEnabled(LogLevel logLevel) => false;
    public void Log(LogLevel logLevel, string message) { }
    public void Clean(){}
    public void Flush() {}
    public void Dispose() { }
}

public static class LoggerExtensions
{
    public static void Log(this ILogger logger, string message) => logger.Log(LogLevel.Information, message);
    public static void Warn(this ILogger logger, string message) => logger.Log(LogLevel.Warning, message);

    public static FlushScope FlushScope(this ILogger logger) => new(logger);

    // public static ILogger GetSubLogger<T>(this ILogger logger, params object[] details)
    //     => Discord.Net.Hanz.Logging.GetLogger(new(typeof(T), [..logger.Context.Details, ..details]));
    
    // public static ILogger GetSubLogger(this ILogger logger, Type type, params object[] details)
    //     => Discord.Net.Hanz.Logging.GetLogger(new(type, [..logger.Context.Details, ..details]));
}
