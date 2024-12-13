using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMediaChannelActor : 
    Discord.ICreatable<Discord.IMediaChannelActor, Discord.IMediaChannel, ulong, Discord.CreateGuildMediaChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildMediaChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildMediaChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildMediaChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildMediaChannelModel> Discord.ICreatable<Discord.IMediaChannelActor, Discord.IMediaChannel, ulong, Discord.CreateGuildMediaChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildMediaChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableMediaChannelExtensions
{
    public static async Task<Discord.IMediaChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> link,
        Discord.CreateGuildMediaChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IMediaChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
