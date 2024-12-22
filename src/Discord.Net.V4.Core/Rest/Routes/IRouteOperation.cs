using Discord.Models;

namespace Discord.Rest;

public interface IRouteOperation : IRoute
{
    static abstract string OperationName { get; }
    static abstract RequestMethod Method { get; }
    static abstract bool RequiresBotToken { get; }

    string BuildRoute();
}

public interface IRouteOperation<out TSelf> : IRouteOperation
    where TSelf : IRouteOperation<TSelf>
{
    internal static abstract TSelf Create(IPathable path);
}