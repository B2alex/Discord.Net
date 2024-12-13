using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildInviteActor : 
    Discord.IFetchableOfMany<string, Discord.Models.IInviteModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IInviteModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildInvites(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IInviteModel>> Discord.IFetchableOfMany<string, Discord.Models.IInviteModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
