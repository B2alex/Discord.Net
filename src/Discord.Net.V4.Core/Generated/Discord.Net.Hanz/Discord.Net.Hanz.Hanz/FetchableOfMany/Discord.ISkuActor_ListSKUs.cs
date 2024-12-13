using Discord.Rest;
using Discord;

namespace Discord;

public partial interface ISkuActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.ISkuModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.ISkuModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListSKUs(path.Require<Discord.IApplication>());

    static IApiOutRoute<IEnumerable<Discord.Models.ISkuModel>> Discord.IFetchableOfMany<ulong, Discord.Models.ISkuModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
