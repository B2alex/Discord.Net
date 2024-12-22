using Discord.Rest;

namespace Discord;

public class DiscordHttpException : Exception
{
    public IRouteOperation Route { get; }
    public RequestOptions? Options { get; }

    public DiscordHttpException(
        IRouteOperation route,
        RequestOptions? options,
        string message = "A HTTP exception has occurred.",
        Exception? innerException = null
    ) : base(message, innerException)
    {
        Route = route;
        Options = options;
    }
}