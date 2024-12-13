using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGroupChannelActor : 
    Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.Actor<Discord.IGroupChannelActor, Discord.IGroupChannel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel> Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.Actor<Discord.IGroupChannelActor, Discord.IGroupChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGroupDmParams> Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGroupChannel : 
    Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.Entity<Discord.IGroupChannel>,
    Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => Discord.Rest.Routes.ModifyChannel<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>(id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel> Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.Entity<Discord.IGroupChannel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGroupDmParams> Discord.IModifiable<ulong, Discord.ModifyGroupDMProperties, Discord.Models.Json.ModifyGroupDmParams, Discord.Models.IGroupDMChannelModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGroupDmParams args
    ) => ModifyRoute(path, id, args);
}
