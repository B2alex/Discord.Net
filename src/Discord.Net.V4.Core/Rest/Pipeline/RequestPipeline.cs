using Discord.Models;

namespace Discord.Rest.Pipeline;

public record RequestPipeline<TRoute>(
    TRoute Route,
    RequestOptions? Options
) : IRestPipeline<IRestResponse>
    where TRoute : IRouteOperation<TRoute>
{
    public ValueTask<IRestResponse> RunAsync(IDiscordClient client, CancellationToken token)
        => client.RestApiClient.ExecuteAsync(Route, null, Options, token);
}

public record RequestPipeline<TRoute, TParams>(
    TRoute Route,
    TParams? Params,
    RequestOptions? Options
) : IRestPipeline<IRestResponse>
    where TRoute : IRouteOperation<TRoute>
    where TParams : IRequestParams
{
    public ValueTask<IRestResponse> RunAsync(IDiscordClient client, CancellationToken token)
        => client.RestApiClient.ExecuteAsync(Route, Params, Options, token);
}