using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGlobalApplicationCommandActor : 
    Discord.ICreatable<Discord.IGlobalApplicationCommandActor, Discord.IGlobalApplicationCommand, ulong, Discord.CreateGlobalApplicationCommandProperties, Discord.Models.Json.CreateGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGlobalApplicationCommandParams args) => Discord.Rest.Routes.CreateGlobalApplicationCommand(path.Require<Discord.IApplication>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel> Discord.ICreatable<Discord.IGlobalApplicationCommandActor, Discord.IGlobalApplicationCommand, ulong, Discord.CreateGlobalApplicationCommandProperties, Discord.Models.Json.CreateGlobalApplicationCommandParams, Discord.Models.IApplicationCommandModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGlobalApplicationCommandParams args) => CreateRoute(path, args);
}
