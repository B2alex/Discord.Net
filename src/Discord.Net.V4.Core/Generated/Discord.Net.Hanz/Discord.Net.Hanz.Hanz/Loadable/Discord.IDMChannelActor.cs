using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IDMChannelActor : 
    Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IDMChannelModel>
{
    static new IApiOutRoute<Discord.Models.IDMChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IDMChannelModel> Discord.IFetchable<ulong, Discord.Models.IDMChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IDMChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IDMChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IDMChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IDMChannel?> Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IDMChannel?> Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IDMChannel?> Discord.ILoadable<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
