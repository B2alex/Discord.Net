using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IForumChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.Actor<Discord.IForumChannelActor, Discord.IForumChannel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel> Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.Actor<Discord.IForumChannelActor, Discord.IForumChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.ModifyRoute(
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
public partial interface IForumChannel : 
    Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.Entity<Discord.IForumChannel>,
    Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel> Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.Entity<Discord.IForumChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyForumChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildForumChannelModel>.ModifyRoute(
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
