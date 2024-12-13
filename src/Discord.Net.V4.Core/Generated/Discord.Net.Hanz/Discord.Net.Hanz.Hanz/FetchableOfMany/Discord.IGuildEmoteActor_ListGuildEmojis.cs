using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildEmoteActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.ICustomEmoteModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.ICustomEmoteModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListGuildEmojis(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.ICustomEmoteModel>> Discord.IFetchableOfMany<ulong, Discord.Models.ICustomEmoteModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
