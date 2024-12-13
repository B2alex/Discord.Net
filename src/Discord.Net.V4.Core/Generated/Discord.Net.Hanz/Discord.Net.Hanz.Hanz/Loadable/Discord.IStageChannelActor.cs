using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStageChannelActor : 
    Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildStageChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildStageChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildStageChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildStageChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IStageChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IStageChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IStageChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IStageChannel?> Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IStageChannel?> Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IStageChannel?> Discord.ILoadable<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IVoiceChannel?> Discord.IVoiceChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IVoiceChannel?> Discord.IVoiceChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IVoiceChannel?> Discord.IVoiceChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
