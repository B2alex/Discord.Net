using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IIncomingWebhookWithTokenActor : 
    Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.Actor<Discord.IIncomingWebhookWithTokenActor, Discord.IIncomingWebhook>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => Discord.Rest.Routes.ModifyWebhookWithToken(id, path.Require<Discord.ITokenPathProvider>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.Actor<Discord.IIncomingWebhookWithTokenActor, Discord.IIncomingWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookWithTokenParams> Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> Discord.IIncomingWebhookActor.ModifyRoute(
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
    Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.Entity<Discord.IIncomingWebhook>,
    Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => Discord.Rest.Routes.ModifyWebhookWithToken(id, path.Require<Discord.ITokenPathProvider>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel> Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.Entity<Discord.IIncomingWebhook>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyWebhookWithTokenParams> Discord.IModifiable<ulong, Discord.ModifyWebhookWithTokenProperties, Discord.Models.Json.ModifyWebhookWithTokenParams, Discord.Models.IIncomingWebhookModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyWebhookWithTokenParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyWebhookParams, Discord.Models.IIncomingWebhookModel> Discord.IIncomingWebhookActor.ModifyRoute(
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
