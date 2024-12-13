using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStageInstanceActor : 
    Discord.ILoadable<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
    Discord.IFetchable<ulong, Discord.Models.IStageInstanceModel>
{
    static new IApiOutRoute<Discord.Models.IStageInstanceModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetStageInstance(path.Require<Discord.IStageChannel>());

    static IApiOutRoute<Discord.Models.IStageInstanceModel> Discord.IFetchable<ulong, Discord.Models.IStageInstanceModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
