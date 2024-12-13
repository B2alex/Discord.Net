using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IVoiceChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.Actor<Discord.IVoiceChannelActor, Discord.IVoiceChannel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.Actor<Discord.IVoiceChannelActor, Discord.IVoiceChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.ModifyRoute(
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
public partial interface IVoiceChannel : 
    Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.Entity<Discord.IVoiceChannel>,
    Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.Entity<Discord.IVoiceChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildChannelParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildChannelParams> Discord.IModifiable<ulong, Discord.ModifyVoiceChannelProperties, Discord.Models.Json.ModifyGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.ModifyRoute(
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
