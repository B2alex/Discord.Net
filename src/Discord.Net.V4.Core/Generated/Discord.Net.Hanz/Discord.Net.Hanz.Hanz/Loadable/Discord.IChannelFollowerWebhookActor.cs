using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IChannelFollowerWebhookActor : 
    Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
    Discord.IFetchable<ulong, Discord.Models.IChannelFollowerWebhookModel>
{
    static new IApiOutRoute<Discord.Models.IChannelFollowerWebhookModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetWebhook(path.Require<Discord.IWebhook>());

    static IApiOutRoute<Discord.Models.IChannelFollowerWebhookModel> Discord.IFetchable<ulong, Discord.Models.IChannelFollowerWebhookModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IChannelFollowerWebhook?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IChannelFollowerWebhook?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IChannelFollowerWebhook?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>).FetchAsync(options, token);

    ValueTask<Discord.IChannelFollowerWebhook?> Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IChannelFollowerWebhook?> Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IChannelFollowerWebhook?> Discord.ILoadable<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
