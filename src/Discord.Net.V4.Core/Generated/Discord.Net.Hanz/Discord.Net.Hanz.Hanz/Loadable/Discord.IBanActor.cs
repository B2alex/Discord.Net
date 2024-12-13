using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IBanActor : 
    Discord.ILoadable<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
    Discord.IFetchable<ulong, Discord.Models.IBanModel>
{
    static new IApiOutRoute<Discord.Models.IBanModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildBan(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IBanModel> Discord.IFetchable<ulong, Discord.Models.IBanModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
