using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IVoiceStateActor : 
    Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Actor<Discord.IVoiceStateActor, Discord.IVoiceState>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => Discord.Rest.Routes.ModifyUserVoiceState(path.Require<Discord.IGuild>(), path.Require<Discord.IMember>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Actor<Discord.IVoiceStateActor, Discord.IVoiceState>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyUserVoiceStateParams> Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IVoiceState : 
    Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Entity<Discord.IVoiceState>,
    Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => Discord.Rest.Routes.ModifyUserVoiceState(path.Require<Discord.IGuild>(), path.Require<Discord.IMember>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Entity<Discord.IVoiceState>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyUserVoiceStateParams> Discord.IModifiable<ulong, Discord.ModifyUserVoiceStateProperties, Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);
}
