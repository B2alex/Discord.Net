namespace Discord.Models;

internal static class RequestParamsExtensions
{
    public static CollectionBodyParams<T> AsCollectionParams<T>(this IEnumerable<T> body)
        where T : IBodyParams
        => new(body);
}