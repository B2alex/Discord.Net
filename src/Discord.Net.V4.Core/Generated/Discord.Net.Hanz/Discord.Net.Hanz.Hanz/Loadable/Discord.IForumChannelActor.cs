using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IForumChannelActor : 
    Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildForumChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildForumChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildForumChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildForumChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IForumChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IForumChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IForumChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IForumChannel?> Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IForumChannel?> Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IForumChannel?> Discord.ILoadable<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
