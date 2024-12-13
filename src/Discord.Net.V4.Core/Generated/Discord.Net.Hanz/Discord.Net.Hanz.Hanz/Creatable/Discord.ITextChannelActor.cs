using Discord.Models;
using Discord;

namespace Discord;

public partial interface ITextChannelActor : 
    Discord.ICreatable<Discord.ITextChannelActor, Discord.ITextChannel, ulong, Discord.CreateGuildTextChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildTextChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildTextChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => Discord.Rest.Routes.CreateGuildChannel<Discord.Models.Json.GuildTextChannel>(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildTextChannelModel> Discord.ICreatable<Discord.ITextChannelActor, Discord.ITextChannel, ulong, Discord.CreateGuildTextChannelProperties, Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildTextChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildChannelParams, Discord.Models.IGuildChannelModel> Discord.IGuildChannelActor.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildChannelParams args) => CreateRoute(path, args);
}
public static class CreatableTextChannelExtensions
{
    public static async Task<Discord.ITextChannel> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> link,
        Discord.CreateGuildTextChannelProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.ITextChannelActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
