using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentMemberActor : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.Actor<Discord.ICurrentMemberActor, Discord.ICurrentMember>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => Discord.Rest.Routes.ModifyCurrentMember(path.Require<Discord.IGuild>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel> Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.Actor<Discord.ICurrentMemberActor, Discord.ICurrentMember>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentMemberParams> Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> Discord.IMemberActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> Discord.ICurrentUserActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface ICurrentMember : 
    Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.Entity<Discord.ICurrentMember>,
    Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => Discord.Rest.Routes.ModifyCurrentMember(path.Require<Discord.IGuild>(), body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel> Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.Entity<Discord.ICurrentMember>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentMemberParams> Discord.IModifiable<ulong, Discord.ModifyCurrentMemberProperties, Discord.Models.Json.ModifyCurrentMemberParams, Discord.Models.IMemberModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildMemberParams, Discord.Models.IMemberModel> Discord.IMemberActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildMemberParams args
    ) => ModifyRoute(path, id, args);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> Discord.ICurrentUserActor.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);
}
