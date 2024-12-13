using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMessageActor : 
    Discord.ILoadable<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
    Discord.IFetchable<ulong, Discord.Models.IMessageModel>
{
    static new IApiOutRoute<Discord.Models.IMessageModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetChannelMessage(path.Require<Discord.IChannel>(), id);

    static IApiOutRoute<Discord.Models.IMessageModel> Discord.IFetchable<ulong, Discord.Models.IMessageModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
