using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildChannelInviteActor : 
    Discord.IFetchableOfMany<string, Discord.Models.IInviteModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IInviteModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetChannelInvites(path.Require<Discord.IChannel>());

    static IApiOutRoute<IEnumerable<Discord.Models.IInviteModel>> Discord.IFetchableOfMany<string, Discord.Models.IInviteModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
