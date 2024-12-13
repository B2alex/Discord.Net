using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildChannelActor : 
    Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IGuildChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IGuildChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IGuildChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IGuildChannel?> Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IGuildChannel?> Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IGuildChannel?> Discord.ILoadable<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
