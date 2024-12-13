using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IInviteActor : 
    Discord.ILoadable<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
    Discord.IFetchable<string, Discord.Models.IInviteModel>
{
    static new IApiOutRoute<Discord.Models.IInviteModel> FetchRoute(IPathable path, string id) => Discord.Rest.Routes.GetInvite(id);

    static IApiOutRoute<Discord.Models.IInviteModel> Discord.IFetchable<string, Discord.Models.IInviteModel>.FetchRoute(IPathable path, string id) => FetchRoute(path, id);
}
