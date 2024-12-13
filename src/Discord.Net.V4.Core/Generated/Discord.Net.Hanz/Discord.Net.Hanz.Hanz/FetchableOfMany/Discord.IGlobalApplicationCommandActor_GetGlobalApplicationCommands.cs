using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGlobalApplicationCommandActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IApplicationCommandModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IApplicationCommandModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGlobalApplicationCommands(path.Require<Discord.IApplication>());

    static IApiOutRoute<IEnumerable<Discord.Models.IApplicationCommandModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IApplicationCommandModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
