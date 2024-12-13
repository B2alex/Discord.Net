using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildActor : 
    Discord.ILoadable<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildModel>
{
    static new IApiOutRoute<Discord.Models.IGuildModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuild(id);

    static IApiOutRoute<Discord.Models.IGuildModel> Discord.IFetchable<ulong, Discord.Models.IGuildModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
