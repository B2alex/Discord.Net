using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IWebhookActor : 
    Discord.ILoadable<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
    Discord.IFetchable<ulong, Discord.Models.IWebhookModel>
{
    static new IApiOutRoute<Discord.Models.IWebhookModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetWebhook(id);

    static IApiOutRoute<Discord.Models.IWebhookModel> Discord.IFetchable<ulong, Discord.Models.IWebhookModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
