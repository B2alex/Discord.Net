using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IIncomingWebhookWithTokenActor : 
    Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
    Discord.IFetchable<ulong, Discord.Models.IIncomingWebhookModel>
{
    static new IApiOutRoute<Discord.Models.IIncomingWebhookModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetWebhookWithToken(path.Require<Discord.IWebhook>(), path.Require<Discord.ITokenPathProvider>());

    static IApiOutRoute<Discord.Models.IIncomingWebhookModel> Discord.IFetchable<ulong, Discord.Models.IIncomingWebhookModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IIncomingWebhook?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IIncomingWebhook?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IIncomingWebhook?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>).FetchAsync(options, token);

    ValueTask<Discord.IIncomingWebhook?> Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IIncomingWebhook?> Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IIncomingWebhook?> Discord.ILoadable<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IIncomingWebhook?> Discord.IIncomingWebhookActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IIncomingWebhook?> Discord.IIncomingWebhookActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IIncomingWebhook?> Discord.IIncomingWebhookActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IWebhook?> Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
