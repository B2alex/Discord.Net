using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildTemplateFromGuildActor : 
    Discord.IFetchableOfMany<string, Discord.Models.IGuildTemplateModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IGuildTemplateModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.GetGuildTemplates(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IGuildTemplateModel>> Discord.IFetchableOfMany<string, Discord.Models.IGuildTemplateModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
