using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMessageActor : 
    Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IMessageActor, Discord.IMessage>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => Discord.Rest.Routes.ModifyMessage(path.Require<Discord.IChannel>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.Actor<Discord.IMessageActor, Discord.IMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyMessageParams> Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IMessage : 
    Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IMessage>,
    Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => Discord.Rest.Routes.ModifyMessage(path.Require<Discord.IChannel>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel> Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.Entity<Discord.IMessage>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyMessageParams> Discord.IModifiable<ulong, Discord.ModifyMessageProperties, Discord.Models.Json.ModifyMessageParams, Discord.Models.IMessageModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyMessageParams args
    ) => ModifyRoute(path, id, args);
}
