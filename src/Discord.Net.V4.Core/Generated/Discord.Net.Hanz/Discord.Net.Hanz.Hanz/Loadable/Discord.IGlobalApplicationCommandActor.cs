using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGlobalApplicationCommandActor : 
    Discord.ILoadable<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
    Discord.IFetchable<ulong, Discord.Models.IApplicationCommandModel>
{
    static new IApiOutRoute<Discord.Models.IApplicationCommandModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGlobalApplicationCommand(path.Require<Discord.IApplication>(), path.Require<Discord.IApplicationCommand>());

    static IApiOutRoute<Discord.Models.IApplicationCommandModel> Discord.IFetchable<ulong, Discord.Models.IApplicationCommandModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
