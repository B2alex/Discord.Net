using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IStickerPackActor : 
    Discord.IFetchable<ulong, Discord.Models.IStickerPackModel>
{
    static new IApiOutRoute<Discord.Models.IStickerPackModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetStickerPack(id);

    static IApiOutRoute<Discord.Models.IStickerPackModel> Discord.IFetchable<ulong, Discord.Models.IStickerPackModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
