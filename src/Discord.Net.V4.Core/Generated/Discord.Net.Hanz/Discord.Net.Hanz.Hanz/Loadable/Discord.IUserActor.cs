using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IUserActor : 
    Discord.ILoadable<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
    Discord.IFetchable<ulong, Discord.Models.IUserModel>
{
    static new IApiOutRoute<Discord.Models.IUserModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetUser(id);

    static IApiOutRoute<Discord.Models.IUserModel> Discord.IFetchable<ulong, Discord.Models.IUserModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
