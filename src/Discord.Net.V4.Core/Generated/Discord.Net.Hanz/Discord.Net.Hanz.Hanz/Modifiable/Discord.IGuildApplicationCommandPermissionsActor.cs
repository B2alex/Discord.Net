using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandPermissionsActor : 
    Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.Actor<Discord.IGuildApplicationCommandPermissionsActor, Discord.IGuildApplicationCommandPermissionses>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => Discord.Rest.Routes.ModifyApplicationCommandPermissions(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), path.Require<Discord.IApplicationCommand>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel> Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.Actor<Discord.IGuildApplicationCommandPermissionsActor, Discord.IGuildApplicationCommandPermissionses>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams> Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildApplicationCommandPermissionses : 
    Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.Entity<Discord.IGuildApplicationCommandPermissionses>,
    Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => Discord.Rest.Routes.ModifyApplicationCommandPermissions(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), path.Require<Discord.IApplicationCommand>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel> Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.Entity<Discord.IGuildApplicationCommandPermissionses>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyApplicationCommandPermissionsParams> Discord.IModifiable<ulong, Discord.ModifyApplicationCommandPermissionsProperties, Discord.Models.Json.ModifyApplicationCommandPermissionsParams, Discord.Models.IGuildApplicationCommandPermissionsModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationCommandPermissionsParams args
    ) => ModifyRoute(path, id, args);
}
