using Discord.Models;
using Discord;

namespace Discord;

public partial interface IRoleActor : 
    Discord.ICreatable<Discord.IRoleActor, Discord.IRole, ulong, Discord.CreateRoleProperties, Discord.Models.Json.CreateGuildRoleParams, Discord.Models.IRoleModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildRoleParams, Discord.Models.IRoleModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildRoleParams args) => Discord.Rest.Routes.CreateGuildRole(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildRoleParams, Discord.Models.IRoleModel> Discord.ICreatable<Discord.IRoleActor, Discord.IRole, ulong, Discord.CreateRoleProperties, Discord.Models.Json.CreateGuildRoleParams, Discord.Models.IRoleModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildRoleParams args) => CreateRoute(path, args);
}
