using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IThreadChannelActor : 
    Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IThreadChannelModel>
{
    static new IApiOutRoute<Discord.Models.IThreadChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IThreadChannelModel> Discord.IFetchable<ulong, Discord.Models.IThreadChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IThreadChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IThreadChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IThreadChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IThreadChannel?> Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IThreadChannel?> Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IThreadChannel?> Discord.ILoadable<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
