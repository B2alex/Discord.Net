using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IRoleActor : 
    Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.Actor<Discord.IRoleActor, Discord.IRole>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => Discord.Rest.Routes.ModifyGuildRole(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel> Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.Actor<Discord.IRoleActor, Discord.IRole>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildRoleParams> Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IRole : 
    Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.Entity<Discord.IRole>,
    Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => Discord.Rest.Routes.ModifyGuildRole(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel> Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.Entity<Discord.IRole>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildRoleParams> Discord.IModifiable<ulong, Discord.ModifyRoleProperties, Discord.Models.Json.ModifyGuildRoleParams, Discord.Models.IRoleModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildRoleParams args
    ) => ModifyRoute(path, id, args);
}
