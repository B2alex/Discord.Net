using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildApplicationCommandPermissionsActor : 
    Discord.ILoadable<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
    Discord.IFetchable<ulong, Discord.Models.IGuildApplicationCommandPermissionsModel>
{
    static new IApiOutRoute<Discord.Models.IGuildApplicationCommandPermissionsModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetApplicationCommandPermissions(path.Require<Discord.IApplication>(), path.Require<Discord.IGuild>(), path.Require<Discord.IApplicationCommand>());

    static IApiOutRoute<Discord.Models.IGuildApplicationCommandPermissionsModel> Discord.IFetchable<ulong, Discord.Models.IGuildApplicationCommandPermissionsModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
