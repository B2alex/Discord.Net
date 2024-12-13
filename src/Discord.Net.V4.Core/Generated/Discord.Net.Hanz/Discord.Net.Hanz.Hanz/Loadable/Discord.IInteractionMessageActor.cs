using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IInteractionMessageActor : 
    Discord.ILoadable<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
    Discord.IFetchable<ulong, Discord.Models.IMessageModel>
{
    static new IApiOutRoute<Discord.Models.IMessageModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetFollowupMessage(path.Require<Discord.IApplication>(), path.Require<Discord.ITokenPathProvider>(), id);

    static IApiOutRoute<Discord.Models.IMessageModel> Discord.IFetchable<ulong, Discord.Models.IMessageModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
