using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IWebhookMessageActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IWebhookMessageActor, Discord.IWebhookMessage>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyWebhookMessage(path.Require<Discord.IWebhook>(), path.Require<Discord.ITokenPathProvider>(), id, body, path.Require<Discord.IThreadChannel>());

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IWebhookMessageActor, Discord.IWebhookMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> Discord.IMessageActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IWebhookMessage : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IWebhookMessage>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyWebhookMessage(path.Require<Discord.IWebhook>(), path.Require<Discord.ITokenPathProvider>(), id, body, path.Require<Discord.IThreadChannel>());

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IWebhookMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> Discord.IMessageActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);
}
