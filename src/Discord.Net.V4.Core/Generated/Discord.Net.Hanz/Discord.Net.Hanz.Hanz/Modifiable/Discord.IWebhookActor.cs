using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IWebhookActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.Actor<Discord.IWebhookActor, Discord.IWebhook>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.Actor<Discord.IWebhookActor, Discord.IWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IWebhook : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.Entity<Discord.IWebhook>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.Entity<Discord.IWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);
}
