using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildEmoteActor : 
    Discord.ILoadable<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
    Discord.IFetchable<ulong, Discord.Models.ICustomEmoteModel>
{
    static new IApiOutRoute<Discord.Models.ICustomEmoteModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildEmoji(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.ICustomEmoteModel> Discord.IFetchable<ulong, Discord.Models.ICustomEmoteModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
