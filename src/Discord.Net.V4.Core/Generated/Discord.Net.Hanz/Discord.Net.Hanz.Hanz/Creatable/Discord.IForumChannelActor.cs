using Discord.Models;
using Discord;

namespace Discord;

public partial interface IForumChannelActor : 
    Discord.ICreatable<Discord.IForumChannelActor, Discord.IForumChannel, ulong, Discord.CreateGuildForumChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildForumChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildForumChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildForumChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildForumChannelModel> Discord.ICreatable<Discord.IForumChannelActor, Discord.IForumChannel, ulong, Discord.CreateGuildForumChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildForumChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableForumChannelExtensions
{
    public static async Task<Discord.IForumChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> link,
        Discord.CreateGuildForumChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IForumChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
