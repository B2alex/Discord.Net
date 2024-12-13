using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildTemplateActor : 
    Discord.ILoadable<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
    Discord.IFetchable<string, Discord.Models.IGuildTemplateModel>
{
    static new IApiOutRoute<Discord.Models.IGuildTemplateModel> FetchRoute(IPathable path, string id) => Discord.Rest.Routes.GetGuildTemplate(id);

    static IApiOutRoute<Discord.Models.IGuildTemplateModel> Discord.IFetchable<string, Discord.Models.IGuildTemplateModel>.FetchRoute(IPathable path, string id) => FetchRoute(path, id);
}
