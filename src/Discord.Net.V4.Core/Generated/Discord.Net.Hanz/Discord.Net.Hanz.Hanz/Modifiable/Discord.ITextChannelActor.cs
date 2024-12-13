using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ITextChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.Actor<Discord.ITextChannelActor, Discord.ITextChannel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel> Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.Actor<Discord.ITextChannelActor, Discord.ITextChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.ModifyRoute(
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
public partial interface ITextChannel : 
    Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.Entity<Discord.ITextChannel>,
    Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel> Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.Entity<Discord.ITextChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyTextChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildTextChannelModel>.ModifyRoute(
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
