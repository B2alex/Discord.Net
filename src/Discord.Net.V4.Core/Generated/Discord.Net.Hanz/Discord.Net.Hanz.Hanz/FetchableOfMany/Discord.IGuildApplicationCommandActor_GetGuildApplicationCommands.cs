using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IApplicationCommandModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IApplicationCommandModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildApplicationCommands(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IApplicationCommandModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IApplicationCommandModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
