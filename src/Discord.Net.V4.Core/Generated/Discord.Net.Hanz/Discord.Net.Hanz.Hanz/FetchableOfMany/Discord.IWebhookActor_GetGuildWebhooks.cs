using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IWebhookActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IWebhookModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IWebhookModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildWebhooks(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IWebhookModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IWebhookModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
