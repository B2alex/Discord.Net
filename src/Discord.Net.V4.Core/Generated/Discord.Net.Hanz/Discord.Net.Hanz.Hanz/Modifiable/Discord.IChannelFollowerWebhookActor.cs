using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IChannelFollowerWebhookActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.Actor<Discord.IChannelFollowerWebhookActor, Discord.IChannelFollowerWebhook>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.Actor<Discord.IChannelFollowerWebhookActor, Discord.IChannelFollowerWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.ModifyRoute(
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
public partial interface IChannelFollowerWebhook : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.Entity<Discord.IChannelFollowerWebhook>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => Discord.Rest.Routes.ModifyWebhook(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.Entity<Discord.IChannelFollowerWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookParams> Discord.IModifiable<ulong, Discord.ModifyWebhookProperties, Discord.Models.Json.ModifyWebhookParams, Discord.Models.IChannelFollowerWebhookModel>.ModifyRoute(
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
