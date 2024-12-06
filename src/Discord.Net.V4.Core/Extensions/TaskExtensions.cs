using MorseCode.ITask;

namespace Discord;

public static class TaskExtensions
{
    public static Task<IReadOnlyCollection<U>> MapAsync<T, U>(this IEnumerable<T> source, Func<T, Task<U>> mapper)
        => source.Select(mapper).Await();

    public static Task<IReadOnlyCollection<U>> MapAsync<T, U>(this IEnumerable<T> source, Func<T, ITask<U>> mapper)
        => source.Select(mapper).Await();

    public static Task<IReadOnlyCollection<U>> MapAsync<T, U>(
        this IEnumerable<T> source,
        Func<T, CancellationToken, Task<U>> mapper,
        CancellationToken token
    ) => source.Select(x => mapper(x, token)).Await();

    public static Task<IReadOnlyCollection<U>> MapAsync<T, U>(
        this IEnumerable<T> source,
        Func<T, CancellationToken, ITask<U>> mapper,
        CancellationToken token
    ) => source.Select(x => mapper(x, token)).Await();

    public static async Task<IReadOnlyCollection<T>> Await<T>(this IEnumerable<Task<T>> source)
    {
        var tasks = source as Task<T>[] ?? source.ToArray();

        await Task.WhenAll(tasks);

        return tasks.Select(x => x.Result).ToList().AsReadOnly();
    }

    public static Task<IReadOnlyCollection<T>> Await<T>(this IEnumerable<ITask<T>> source)
        => source.Select(async Task<T> (task) => await task).Await();
}