using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandActor : 
    Discord.ICreatable<Discord.IGuildApplicationCommandActor, Discord.IGuildApplicationCommand, ulong, Discord.CreateGuildApplicationCommandProperties, Discord.Models.Json.CreateGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildApplicationCommandParams args) => Discord.Rest.Routes.CreateGuildApplicationCommand(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.ICreatable<Discord.IGuildApplicationCommandActor, Discord.IGuildApplicationCommand, ulong, Discord.CreateGuildApplicationCommandProperties, Discord.Models.Json.CreateGuildApplicationCommandParams, Discord.Models.IApplicationCommandModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildApplicationCommandParams args) => CreateRoute(path, args);
}
