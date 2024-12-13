using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICategoryChannelActor : 
    Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildCategoryChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildCategoryChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildCategoryChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildCategoryChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.ICategoryChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.ICategoryChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.ICategoryChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.ICategoryChannel?> Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.ICategoryChannel?> Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.ICategoryChannel?> Discord.ILoadable<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
