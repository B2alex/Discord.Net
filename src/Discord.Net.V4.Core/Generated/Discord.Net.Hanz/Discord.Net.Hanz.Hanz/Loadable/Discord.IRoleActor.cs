using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IRoleActor : 
    Discord.ILoadable<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
    Discord.IFetchable<ulong, Discord.Models.IRoleModel>
{
    static new IApiOutRoute<Discord.Models.IRoleModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildRole(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IRoleModel> Discord.IFetchable<ulong, Discord.Models.IRoleModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
