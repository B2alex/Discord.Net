using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICategoryChannelActor : 
    Discord.ICreatable<Discord.ICategoryChannelActor, Discord.ICategoryChannel, ulong, Discord.CreateGuildCategoryChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildCategoryChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildCategoryChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildCategoryChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildCategoryChannelModel> Discord.ICreatable<Discord.ICategoryChannelActor, Discord.ICategoryChannel, ulong, Discord.CreateGuildCategoryChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildCategoryChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableCategoryChannelExtensions
{
    public static async Task<Discord.ICategoryChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> link,
        Discord.CreateGuildCategoryChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.ICategoryChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
