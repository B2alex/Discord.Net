using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStageInstanceActor : 
    Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.Actor<Discord.IStageInstanceActor, Discord.IStageInstance>
{
    internal static new IApiInOutRoute<Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => Discord.Rest.Routes.ModifyStageInstance(path.Require<Discord.IStageChannel>(), args);

    static IApiInOutRoute<Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel> Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.Actor<Discord.IStageInstanceActor, Discord.IStageInstance>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.ModifyStageInstanceParams> Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IStageInstance : 
    Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.Entity<Discord.IStageInstance>,
    Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>
{
    internal new static IApiInOutRoute<Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => Discord.Rest.Routes.ModifyStageInstance(path.Require<Discord.IStageChannel>(), args);

    static IApiInOutRoute<Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel> Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.Entity<Discord.IStageInstance>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.ModifyStageInstanceParams> Discord.IModifiable<ulong, Discord.ModifyStageInstanceProperties, Discord.Models.ModifyStageInstanceParams, Discord.Models.IStageInstanceModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyStageInstanceParams args
    ) => ModifyRoute(path, id, args);
}
