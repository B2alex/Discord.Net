using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IThreadableChannelTrait : 
    Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.Actor<Discord.IThreadableChannelTrait, Discord.IThreadableChannel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>(path.Require<Discord.IChannel>(), args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel> Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.Actor<Discord.IThreadableChannelTrait, Discord.IThreadableChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IThreadableChannel : 
    Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.Entity<Discord.IThreadableChannel>,
    Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>(path.Require<Discord.IChannel>(), args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel> Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.Entity<Discord.IThreadableChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyThreadableChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IThreadableChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);
}
