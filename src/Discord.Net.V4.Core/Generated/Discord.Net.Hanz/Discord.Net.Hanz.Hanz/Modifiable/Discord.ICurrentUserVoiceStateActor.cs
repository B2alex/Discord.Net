using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentUserVoiceStateActor : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Actor<Discord.ICurrentUserVoiceStateActor, Discord.ICurrentUserVoiceState>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => Discord.Rest.Routes.ModifyCurrentUserVoiceState(path.Require<Discord.IGuild>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Actor<Discord.ICurrentUserVoiceStateActor, Discord.ICurrentUserVoiceState>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams> Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IVoiceStateActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface ICurrentUserVoiceState : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Entity<Discord.ICurrentUserVoiceState>,
    Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => Discord.Rest.Routes.ModifyCurrentUserVoiceState(path.Require<Discord.IGuild>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.Entity<Discord.ICurrentUserVoiceState>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentUserVoiceStateParams> Discord.IModifiable<ulong, Discord.ModifyCurrentUserVoiceStateProperties, Discord.Models.Json.ModifyCurrentUserVoiceStateParams, Discord.Models.IVoiceStateModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyUserVoiceStateParams, Discord.Models.IVoiceStateModel> Discord.IVoiceStateActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyUserVoiceStateParams args
    ) => ModifyRoute(path, id, args);
}
