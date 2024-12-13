using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGroupChannelActor : 
    Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGroupDMChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGroupDMChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGroupDMChannelModel> Discord.IFetchable<ulong, Discord.Models.IGroupDMChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IGroupChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IGroupChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IGroupChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IGroupChannel?> Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IGroupChannel?> Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IGroupChannel?> Discord.ILoadable<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
