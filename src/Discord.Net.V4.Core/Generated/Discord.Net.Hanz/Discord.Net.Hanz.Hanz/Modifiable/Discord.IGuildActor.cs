using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.Actor<Discord.IGuildActor, Discord.IGuild>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => Discord.Rest.Routes.ModifyGuild(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel> Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.Actor<Discord.IGuildActor, Discord.IGuild>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildParams> Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuild : 
    Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.Entity<Discord.IGuild>,
    Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => Discord.Rest.Routes.ModifyGuild(id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel> Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.Entity<Discord.IGuild>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildParams> Discord.IModifiable<ulong, Discord.ModifyGuildProperties, Discord.Models.Json.ModifyGuildParams, Discord.Models.IGuildModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildParams args
    ) => ModifyRoute(path, id, args);
}
