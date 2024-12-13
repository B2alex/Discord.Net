using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IApplicationEmoteActor : 
    Discord.ILoadable<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
    Discord.IFetchable<ulong, Discord.Models.ICustomEmoteModel>
{
    static new IApiOutRoute<Discord.Models.ICustomEmoteModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetApplicationEmoji(path.Require<Discord.IApplication>(), id);

    static IApiOutRoute<Discord.Models.ICustomEmoteModel> Discord.IFetchable<ulong, Discord.Models.ICustomEmoteModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
