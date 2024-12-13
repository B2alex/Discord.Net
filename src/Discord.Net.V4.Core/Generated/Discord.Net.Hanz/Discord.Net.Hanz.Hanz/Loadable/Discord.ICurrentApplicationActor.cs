using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentApplicationActor : 
    Discord.ILoadable<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
    Discord.IFetchable<ulong, Discord.Models.IApplicationModel>
{
    static new IApiOutRoute<Discord.Models.IApplicationModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetCurrentApplication;

    static IApiOutRoute<Discord.Models.IApplicationModel> Discord.IFetchable<ulong, Discord.Models.IApplicationModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
