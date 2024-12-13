using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IThreadChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.Actor<Discord.IThreadChannelActor, Discord.IThreadChannel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel> Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.Actor<Discord.IThreadChannelActor, Discord.IThreadChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyThreadChannelParams> Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IThreadChannel : 
    Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.Entity<Discord.IThreadChannel>,
    Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel> Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.Entity<Discord.IThreadChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyThreadChannelParams> Discord.IModifiable<ulong, Discord.ModifyThreadChannelProperties, Discord.Models.Json.ModifyThreadChannelParams, Discord.Models.IThreadChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyThreadChannelParams args
    ) => ModifyRoute(path, id, args);
}
