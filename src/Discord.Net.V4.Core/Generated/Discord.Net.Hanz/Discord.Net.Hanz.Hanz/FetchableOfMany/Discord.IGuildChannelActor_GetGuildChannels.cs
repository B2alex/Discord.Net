using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildChannelActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IGuildChannelModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IGuildChannelModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildChannels(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IGuildChannelModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IGuildChannelModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
