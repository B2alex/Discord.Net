namespace Discord.Net.Hanz;

public record LogContext(
    Type Owner,
    params object[] Details
);

file sealed class LoggerProxy : ILogger
{
    private readonly LogContext _context;
    private ILogger _logger;
    private readonly Action<LoggerProxy> _onDispose;

    public LoggerProxy(LogContext context, ILogger logger, Action<LoggerProxy> onDispose)
    {
        _context = context;
        _logger = logger;
        _onDispose = onDispose;
    }

    public void Update()
        => _logger = Logging.GetLogger(_context);

    public void Dispose()
    {
        _onDispose(this);
        _logger.Dispose();
    }

    public LogContext Context => _logger.Context;

    public bool IsEnabled(LogLevel logLevel)
    {
        return _logger.IsEnabled(logLevel);
    }

    public void Log(LogLevel logLevel, string message)
    {
        _logger.Log(logLevel, message);
    }

    public void Clean()
    {
        _logger.Clean();
    }

    public void Flush()
    {
        _logger.Flush();
    }
}

public static class Logging
{
    private static Func<LogContext, ILogger>? _loggerFactory = null;

    
    private static readonly HashSet<ILogger> _proxies = [];
    
    public static void InitializeFileLogging(
        string path,
        LogLevel level
    )
    {
        _loggerFactory = (ctx) =>
        {
            var detailsPath = ctx.Details.Select(x => x.ToString());

            var filePath = Path.Combine([path, ..detailsPath, $"{ctx.Owner.Name}.log"]);
            
            return FileLogger.TryCreate(filePath, level, ctx, out var logger)
                    ? logger
                    : NullLogger.Instance;
        };

        UpdateProxies();
    }

    private static void UpdateProxies()
    {
        if (_proxies.Count == 0 || _loggerFactory is null) return;

        foreach (var proxy in _proxies.OfType<LoggerProxy>().ToArray())
        {
            proxy.Update();
        }
    }

    public static ILogger GetLogger<T>()
        => GetLogger(new(typeof(T)));
    
    public static ILogger GetLogger<T>(params object[] details)
        => GetLogger(new(typeof(T), details));

    public static ILogger GetLogger(LogContext context)
    {
        if (_loggerFactory is null)
        {
            return new LoggerProxy(
                context,
                NullLogger.Instance,
                proxy => _proxies.Remove(proxy)
            );
        }

        return _loggerFactory(context);
    }
}