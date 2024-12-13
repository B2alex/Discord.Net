using Discord.Models;
using Discord;

namespace Discord;

public partial interface IAnnouncementChannelActor : 
    Discord.ICreatable<Discord.IAnnouncementChannelActor, Discord.IAnnouncementChannel, ulong, Discord.CreateGuildAnnouncementChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildNewsChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildNewsChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildAnnouncementChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildNewsChannelModel> Discord.ICreatable<Discord.IAnnouncementChannelActor, Discord.IAnnouncementChannel, ulong, Discord.CreateGuildAnnouncementChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildNewsChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableAnnouncementChannelExtensions
{
    public static async Task<Discord.IAnnouncementChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> link,
        Discord.CreateGuildAnnouncementChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IAnnouncementChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
