using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IThreadableChannelTrait : 
    Discord.ILoadable<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
    Discord.IFetchable<ulong, Discord.Models.IThreadableChannelModel>
{
    static new IApiOutRoute<Discord.Models.IThreadableChannelModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannel(path.Require<Discord.IChannel>());

    static IApiOutRoute<Discord.Models.IThreadableChannelModel> Discord.IFetchable<ulong, Discord.Models.IThreadableChannelModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
