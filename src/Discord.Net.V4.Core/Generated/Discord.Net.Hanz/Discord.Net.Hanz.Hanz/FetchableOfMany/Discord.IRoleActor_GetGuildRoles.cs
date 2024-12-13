using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IRoleActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IRoleModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IRoleModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildRoles(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IRoleModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IRoleModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
