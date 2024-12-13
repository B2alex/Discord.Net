using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildScheduledEventActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IGuildScheduledEventModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IGuildScheduledEventModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListGuildScheduledEvents(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IGuildScheduledEventModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IGuildScheduledEventModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
