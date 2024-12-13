using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildScheduledEventActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.Actor<Discord.IGuildScheduledEventActor, Discord.IGuildScheduledEvent>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => Discord.Rest.Routes.ModifyGuildScheduledEvent(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.Actor<Discord.IGuildScheduledEventActor, Discord.IGuildScheduledEvent>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildScheduledEventParams> Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildScheduledEvent : 
    Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.Entity<Discord.IGuildScheduledEvent>,
    Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => Discord.Rest.Routes.ModifyGuildScheduledEvent(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.Entity<Discord.IGuildScheduledEvent>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildScheduledEventParams> Discord.IModifiable<ulong, Discord.ModifyGuildScheduledEventProperties, Discord.Models.Json.ModifyGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildScheduledEventParams args
    ) => ModifyRoute(path, id, args);
}
