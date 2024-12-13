using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildStickerActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IGuildStickerModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IGuildStickerModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListGuildStickers(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IGuildStickerModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IGuildStickerModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
