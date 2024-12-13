using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IVoiceChannelActor : 
    Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildVoiceChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildVoiceChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildVoiceChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildVoiceChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IVoiceChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IVoiceChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IVoiceChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IVoiceChannel?> Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IVoiceChannel?> Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IVoiceChannel?> Discord.ILoadable<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
