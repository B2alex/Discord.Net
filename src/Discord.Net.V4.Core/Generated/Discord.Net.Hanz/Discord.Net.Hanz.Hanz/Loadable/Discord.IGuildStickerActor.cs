using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildStickerActor : 
    Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildStickerModel>
{
    static new IApiOutRoute<Discord.Models.IGuildStickerModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildSticker(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IGuildStickerModel> Discord.IFetchable<ulong, Discord.Models.IGuildStickerModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IGuildSticker?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IGuildSticker?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IGuildSticker?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>).FetchAsync(options, token);

    ValueTask<Discord.IGuildSticker?> Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IGuildSticker?> Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IGuildSticker?> Discord.ILoadable<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.ISticker?> Discord.ILoadable<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.ISticker?> Discord.ILoadable<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.ISticker?> Discord.ILoadable<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
