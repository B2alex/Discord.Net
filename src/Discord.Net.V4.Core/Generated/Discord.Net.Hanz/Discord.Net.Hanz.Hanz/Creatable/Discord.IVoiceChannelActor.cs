using Discord.Models;
using Discord;

namespace Discord;

public partial interface IVoiceChannelActor : 
    Discord.ICreatable<Discord.IVoiceChannelActor, Discord.IVoiceChannel, ulong, Discord.CreateGuildVoiceChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildVoiceChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildVoiceChannelModel> Discord.ICreatable<Discord.IVoiceChannelActor, Discord.IVoiceChannel, ulong, Discord.CreateGuildVoiceChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildVoiceChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableVoiceChannelExtensions
{
    public static async Task<Discord.IVoiceChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> link,
        Discord.CreateGuildVoiceChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IVoiceChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
