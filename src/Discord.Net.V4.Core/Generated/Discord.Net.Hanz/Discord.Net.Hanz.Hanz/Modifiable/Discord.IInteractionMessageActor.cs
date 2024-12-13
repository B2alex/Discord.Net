using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IInteractionMessageActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IInteractionMessageActor, Discord.IMessage>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyFollowupMessage(path.Require<Discord.IApplication>(), path.Require<Discord.ITokenPathProvider>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IInteractionMessageActor, Discord.IMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IMessage : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IMessage>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyFollowupMessage(path.Require<Discord.IApplication>(), path.Require<Discord.ITokenPathProvider>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);
}
