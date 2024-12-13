using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IWebhookMessageActor : 
    Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
    Discord.IFetchable<ulong, Discord.Models.IMessageModel>
{
    static new IApiOutRoute<Discord.Models.IMessageModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetWebhookMessage(path.Require<Discord.IWebhook>(), path.Require<Discord.ITokenPathProvider>(), id);

    static IApiOutRoute<Discord.Models.IMessageModel> Discord.IFetchable<ulong, Discord.Models.IMessageModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IWebhookMessage?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IWebhookMessage?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IWebhookMessage?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>).FetchAsync(options, token);

    ValueTask<Discord.IWebhookMessage?> Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IWebhookMessage?> Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IWebhookMessage?> Discord.ILoadable<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IMessage?> Discord.ILoadable<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IMessage?> Discord.ILoadable<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IMessage?> Discord.ILoadable<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
