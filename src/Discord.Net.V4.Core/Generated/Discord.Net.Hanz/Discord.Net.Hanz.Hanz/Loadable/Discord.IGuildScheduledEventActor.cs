using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildScheduledEventActor : 
    Discord.ILoadable<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildScheduledEventModel>
{
    static new IApiOutRoute<Discord.Models.IGuildScheduledEventModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildScheduledEvent(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IGuildScheduledEventModel> Discord.IFetchable<ulong, Discord.Models.IGuildScheduledEventModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
