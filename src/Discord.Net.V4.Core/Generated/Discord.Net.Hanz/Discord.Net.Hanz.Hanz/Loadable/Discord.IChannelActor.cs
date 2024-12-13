using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IChannelActor : 
    Discord.ILoadable<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IChannelModel>
{
    static new IApiOutRoute<Discord.Models.IChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(id);

    static IApiOutRoute<Discord.Models.IChannelModel> Discord.IFetchable<ulong, Discord.Models.IChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
