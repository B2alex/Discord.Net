using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildTemplateActor : 
    Discord.ICreatable<Discord.IGuildTemplateActor, Discord.IGuildTemplate, string, Discord.CreateGuildTemplateProperties, Discord.Models.Json.CreateTemplateParams, Discord.Models.IGuildTemplateModel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.CreateTemplateParams, Discord.Models.IGuildTemplateModel> CreateRoute(IPathable path, Discord.Models.Json.CreateTemplateParams args) => Discord.Rest.Routes.CreateGuildTemplate(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateTemplateParams, Discord.Models.IGuildTemplateModel> Discord.ICreatable<Discord.IGuildTemplateActor, Discord.IGuildTemplate, string, Discord.CreateGuildTemplateProperties, Discord.Models.Json.CreateTemplateParams, Discord.Models.IGuildTemplateModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateTemplateParams args) => CreateRoute(path, args);
}
public static class CreatableGuildTemplateExtensions
{
    public static async Task<Discord.IGuildTemplate> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel> link,
        Discord.CreateGuildTemplateProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IGuildTemplateActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
