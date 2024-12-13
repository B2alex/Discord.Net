using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStageChannelActor : 
    Discord.ICreatable<Discord.IStageChannelActor, Discord.IStageChannel, ulong, Discord.CreateGuildStageChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildStageChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildStageChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildStageChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildStageChannelModel> Discord.ICreatable<Discord.IStageChannelActor, Discord.IStageChannel, ulong, Discord.CreateGuildStageChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildStageChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> Discord.IVoiceChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableStageChannelExtensions
{
    public static async Task<Discord.IStageChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> link,
        Discord.CreateGuildStageChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IStageChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
