using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IAnnouncementChannelActor : 
    Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildNewsChannelModel>
{
    static new IApiOutRoute<Discord.Models.IGuildNewsChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IGuildNewsChannelModel> Discord.IFetchable<ulong, Discord.Models.IGuildNewsChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IAnnouncementChannel?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IAnnouncementChannel?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IAnnouncementChannel?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>).FetchAsync(options, token);

    ValueTask<Discord.IAnnouncementChannel?> Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IAnnouncementChannel?> Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IAnnouncementChannel?> Discord.ILoadable<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IGuildChannel?> Discord.IGuildChannelActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IChannel?> Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
