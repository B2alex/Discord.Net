using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IStickerPackActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IStickerPackModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IStickerPackModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListStickerPacks;

    static IApiOutRoute<IEnumerable<Discord.Models.IStickerPackModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IStickerPackModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
