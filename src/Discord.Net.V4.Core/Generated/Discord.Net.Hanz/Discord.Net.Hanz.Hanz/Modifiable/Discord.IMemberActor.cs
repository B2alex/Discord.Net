using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMemberActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.Actor<Discord.IMemberActor, Discord.IMember>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => Discord.Rest.Routes.ModifyGuildMember(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.Actor<Discord.IMemberActor, Discord.IMember>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildMemberParams> Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IMember : 
    Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.Entity<Discord.IMember>,
    Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => Discord.Rest.Routes.ModifyGuildMember(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.Entity<Discord.IMember>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildMemberParams> Discord.IModifiable<ulong, Discord.ModifyGuildUserProperties, Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);
}
