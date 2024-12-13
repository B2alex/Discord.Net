using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ITextChannelActor : 
    Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildTextChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildTextChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildTextChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildTextChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.ITextChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.ITextChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.ITextChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.ITextChannel?> Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.ITextChannel?> Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.ITextChannel?> Discord.ILoadable<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
