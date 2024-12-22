using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz;

public static class ProviderLogging
{
    public static IncrementalValuesProvider<T> WithLogging<T>(
        this IncrementalValuesProvider<T> provider,
        ILogger logger,
        Func<T?, string>? valueFormat = null
    )
    {
        return provider
            .AsIntrospected()
            .Select((x, _) =>
            {
                if (x.State is not State.Cached)
                {
                    logger.Log(
                        $"{x.State}: {x.Value?.GetHashCode() ?? 0}: {valueFormat?.Invoke(x.Value) ?? x.Value?.ToString()}");
                    logger.Flush();
                }
                
                return x.Value;
            });
    }

    public static IncrementalValueProvider<T> WithLogging<T>(
        this IncrementalValueProvider<T> provider,
        ILogger logger,
        Func<T?, string>? valueFormat = null
    )
    {
        return provider.Select((value, _) =>
        {
            logger.Log($"Update: {value?.GetHashCode() ?? 0}: {valueFormat?.Invoke(value) ?? value?.ToString()}");
            logger.Flush();

            return value;
        });
    }

    public static IncrementalValueProvider<ImmutableArray<T>> WithLogging<T>(
        this IncrementalValueProvider<ImmutableArray<T>> provider,
        ILogger logger,
        Func<T?, string>? valueFormat = null
    )
    {
        return provider
            .SelectMany((x, _) => x)
            .AsIntrospected()
            .Select((x, _) =>
            {
                if (x.State is not State.Cached)
                {
                    logger.Log(
                        $"{x.State}: {x.Value?.GetHashCode() ?? 0}: {valueFormat?.Invoke(x.Value) ?? x.Value?.ToString()}");
                    logger.Flush();
                }
                
                return x.Value;
            })
            .Collect();
    }

    public static IncrementalKeyValueProvider<T, U> WithLogging<T, U>(
        this IncrementalKeyValueProvider<T, U> provider,
        ILogger logger,
        Func<T?, string>? keyFormat = null,
        Func<U?, string>? valueFormat = null
    )
    {
        return new(
            provider
                .IntrospectionProvider
                .Select((x, _) =>
                {
                    if (x.State is not State.Cached)
                    {
                        logger.Log($"{x.State}:");
                        logger.Log(
                            $" - Key: {x.Value.Key?.GetHashCode() ?? 0}: {keyFormat?.Invoke(x.Value.Key) ?? x.Value.Key?.ToString()}");
                        logger.Log(
                            $" - Value: {x.Value.Value?.GetHashCode() ?? 0}: {valueFormat?.Invoke(x.Value.Value) ?? x.Value.Value?.ToString()}");
                        logger.Flush();
                    }

                    return x;
                })
        );
    }

    public static IncrementalGroupingProvider<T, U> WithLogging<T, U>(
        this IncrementalGroupingProvider<T, U> provider,
        ILogger logger,
        Func<T?, string>? keyFormat = null,
        Func<U?, string>? valueFormat = null
    )
    {
        return new(
            provider
                .IntrospectionProvider
                .Select((x, _) =>
                {
                    if (x.State is not State.Cached)
                    {
                        logger.Log($"{x.State}:");
                        logger.Log(
                            $" - Key: {x.Value.Item1?.GetHashCode() ?? 0}: {keyFormat?.Invoke(x.Value.Item1) ?? x.Value.Item1?.ToString()}");
                        logger.Log(
                            $" - Value: {x.Value.Item2?.GetHashCode() ?? 0}: {valueFormat?.Invoke(x.Value.Item2) ?? x.Value.Item2?.ToString()}");
                        logger.Flush();
                    }

                    return x;
                })
        );
    }
}