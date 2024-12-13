using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.Actor<Discord.IGuildChannelActor, Discord.IGuildChannel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.Actor<Discord.IGuildChannelActor, Discord.IGuildChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildChannel : 
    Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.Entity<Discord.IGuildChannel>,
    Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.Entity<Discord.IGuildChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyGuildChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
