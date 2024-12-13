using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Actor<Discord.IGuildApplicationCommandActor, Discord.IGuildApplicationCommand>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => Discord.Rest.Routes.ModifyGuildApplicationCommand(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Actor<Discord.IGuildApplicationCommandActor, Discord.IGuildApplicationCommand>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams> Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildApplicationCommand : 
    Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Entity<Discord.IGuildApplicationCommand>,
    Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => Discord.Rest.Routes.ModifyGuildApplicationCommand(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.Entity<Discord.IGuildApplicationCommand>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildApplicationCommandParams> Discord.IModifiable<ulong, Discord.ModifyGuildApplicationCommandProperties, Discord.Models.Json.ModifyGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildApplicationCommandParams args
    ) => ModifyRoute(path, id, args);
}
