using Discord.Models;
using Discord;

namespace Discord;

public partial interface IApplicationEmoteActor : 
    Discord.ICreatable<Discord.IApplicationEmoteActor, Discord.IApplicationEmote, ulong, Discord.CreateApplicationEmoteProperties, Discord.Models.Json.CreateApplicationEmojiParams, Discord.Models.ICustomEmoteModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateApplicationEmojiParams, Discord.Models.ICustomEmoteModel> CreateRoute(IPathable path, Discord.Models.Json.CreateApplicationEmojiParams args) => Discord.Rest.Routes.CreateApplicationEmoji(path.Require<Discord.IApplication>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateApplicationEmojiParams, Discord.Models.ICustomEmoteModel> Discord.ICreatable<Discord.IApplicationEmoteActor, Discord.IApplicationEmote, ulong, Discord.CreateApplicationEmoteProperties, Discord.Models.Json.CreateApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateApplicationEmojiParams args) => CreateRoute(path, args);
}
public static class CreatableApplicationEmoteExtensions
{
    public static async Task<Discord.IApplicationEmote> CreateAsync(
        this Discord.IBackLink<Discord.ICurrentApplicationActor, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel> link,
        Discord.CreateApplicationEmoteProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IApplicationEmoteActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
