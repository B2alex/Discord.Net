using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMediaChannelActor : 
    Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildMediaChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildMediaChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildMediaChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildMediaChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IMediaChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IMediaChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IMediaChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IMediaChannel?> Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IMediaChannel?> Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IMediaChannel?> Discord.ILoadable<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
