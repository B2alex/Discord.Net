using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGlobalApplicationCommandActor : 
    Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Actor<Discord.IGlobalApplicationCommandActor, Discord.IGlobalApplicationCommand>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => Discord.Rest.Routes.ModifyGlobalApplicationCommand(path.Require<Discord.IApplication>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Actor<Discord.IGlobalApplicationCommandActor, Discord.IGlobalApplicationCommand>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams> Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGlobalApplicationCommand : 
    Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Entity<Discord.IGlobalApplicationCommand>,
    Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => Discord.Rest.Routes.ModifyGlobalApplicationCommand(path.Require<Discord.IApplication>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Entity<Discord.IGlobalApplicationCommand>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGlobalApplicationCommandParams> Discord.IModifiable<ulong, Discord.ModifyGlobalApplicationCommandProperties, Discord.Models.Json.ModifyGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGlobalApplicationCommandParams args
    ) => ModifyRoute(path, id, args);
}
