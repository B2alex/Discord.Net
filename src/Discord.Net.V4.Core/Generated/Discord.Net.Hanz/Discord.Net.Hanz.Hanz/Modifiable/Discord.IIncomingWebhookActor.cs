using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IIncomingWebhookActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.Actor<Discord.IIncomingWebhookActor, Discord.IIncomingWebhook>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.Actor<Discord.IIncomingWebhookActor, Discord.IIncomingWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> Discord.IWebhookActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IIncomingWebhook : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.Entity<Discord.IIncomingWebhook>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.Entity<Discord.IIncomingWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IWebhookModel> Discord.IWebhookActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);
}
