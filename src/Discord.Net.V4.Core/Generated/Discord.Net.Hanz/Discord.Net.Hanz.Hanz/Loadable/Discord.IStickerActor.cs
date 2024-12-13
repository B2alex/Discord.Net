using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStickerActor : 
    Discord.ILoadable<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
    Discord.IFetchable<ulong, Discord.Models.IStickerModel>
{
    static new IApiOutRoute<Discord.Models.IStickerModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetSticker(id);

    static IApiOutRoute<Discord.Models.IStickerModel> Discord.IFetchable<ulong, Discord.Models.IStickerModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
