using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildChannelActor : 
    Discord.ICreatable<Discord.IGuildChannelActor, Discord.IGuildChannel, ulong, Discord.CreateGuildChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.ICreatable<Discord.IGuildChannelActor, Discord.IGuildChannel, ulong, Discord.CreateGuildChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableGuildChannelExtensions
{
    public static async Task<Discord.IGuildChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel> link,
        Discord.CreateGuildChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IGuildChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
