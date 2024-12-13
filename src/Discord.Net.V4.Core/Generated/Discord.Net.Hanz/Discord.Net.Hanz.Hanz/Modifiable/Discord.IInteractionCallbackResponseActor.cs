using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IInteractionCallbackResponseActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.Actor<Discord.IInteractionCallbackResponseActor, Discord.IInteractionCallbackResponse>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyOriginalInteractionResponse(path.Require<Discord.IApplication>(), path.Require<Discord.ITokenPathProvider>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.Actor<Discord.IInteractionCallbackResponseActor, Discord.IInteractionCallbackResponse>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IInteractionCallbackResponse : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.Entity<Discord.IInteractionCallbackResponse>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => Discord.Rest.Routes.ModifyOriginalInteractionResponse(path.Require<Discord.IApplication>(), path.Require<Discord.ITokenPathProvider>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.Entity<Discord.IInteractionCallbackResponse>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookMessageParams> Discord.IModifiable<ulong, Discord.ModifyWebhookMessageProperties, Discord.Models.Json.ModifyWebhookMessageParams, Discord.Models.IInteractionCallbackResponseModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookMessageParams args
    ) => ModifyRoute(path, id, args);
}
