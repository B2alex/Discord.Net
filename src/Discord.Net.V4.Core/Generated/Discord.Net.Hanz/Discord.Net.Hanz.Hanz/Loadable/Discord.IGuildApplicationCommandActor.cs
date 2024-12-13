using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandActor : 
    Discord.ILoadable<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
    Discord.IFetchable<ulong, Discord.Models.IApplicationCommandModel>
{
    static new IApiOutRoute<Discord.Models.IApplicationCommandModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildApplicationCommand(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), path.Require<Discord.IApplicationCommand>());

    static IApiOutRoute<Discord.Models.IApplicationCommandModel> Discord.IFetchable<ulong, Discord.Models.IApplicationCommandModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
