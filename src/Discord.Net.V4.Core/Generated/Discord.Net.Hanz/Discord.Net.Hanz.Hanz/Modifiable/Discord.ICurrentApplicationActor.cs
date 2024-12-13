using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentApplicationActor : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.Actor<Discord.ICurrentApplicationActor, Discord.ICurrentApplication>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => Discord.Rest.Routes.ModifyCurrentApplication(body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel> Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.Actor<Discord.ICurrentApplicationActor, Discord.ICurrentApplication>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentApplicationParams> Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface ICurrentApplication : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.Entity<Discord.ICurrentApplication>,
    Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => Discord.Rest.Routes.ModifyCurrentApplication(body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel> Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.Entity<Discord.ICurrentApplication>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentApplicationParams> Discord.IModifiable<ulong, Discord.ModifyCurrentApplicationProperties, Discord.Models.Json.ModifyCurrentApplicationParams, Discord.Models.IApplicationModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentApplicationParams args
    ) => ModifyRoute(path, id, args);
}
