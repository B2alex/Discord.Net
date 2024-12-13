using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IIntegrationActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IIntegrationModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IIntegrationModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildIntegrations(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IIntegrationModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IIntegrationModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
