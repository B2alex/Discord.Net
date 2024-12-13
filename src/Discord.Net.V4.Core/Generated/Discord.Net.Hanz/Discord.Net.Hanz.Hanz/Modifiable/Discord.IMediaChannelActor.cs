using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMediaChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.Actor<Discord.IMediaChannelActor, Discord.IMediaChannel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel> Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.Actor<Discord.IMediaChannelActor, Discord.IMediaChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IMediaChannel : 
    Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.Entity<Discord.IMediaChannel>,
    Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel> Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.Entity<Discord.IMediaChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyMediaChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
