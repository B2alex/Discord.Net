using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IVoiceStateActor : 
    Discord.ILoadable<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
    Discord.IFetchable<ulong, Discord.Models.IVoiceStateModel>
{
    static new IApiOutRoute<Discord.Models.IVoiceStateModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetUserVoiceState(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IVoiceStateModel> Discord.IFetchable<ulong, Discord.Models.IVoiceStateModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
