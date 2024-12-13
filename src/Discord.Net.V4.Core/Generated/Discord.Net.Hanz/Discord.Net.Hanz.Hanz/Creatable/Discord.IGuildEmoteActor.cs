using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildEmoteActor : 
    Discord.ICreatable<Discord.IGuildEmoteActor, Discord.IGuildEmote, ulong, Discord.CreateGuildEmoteProperties, Discord.Models.Json.CreateGuildEmojiParams, Discord.Models.ICustomEmoteModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildEmojiParams, Discord.Models.ICustomEmoteModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildEmojiParams args) => Discord.Rest.Routes.CreateGuildEmoji(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildEmojiParams, Discord.Models.ICustomEmoteModel> Discord.ICreatable<Discord.IGuildEmoteActor, Discord.IGuildEmote, ulong, Discord.CreateGuildEmoteProperties, Discord.Models.Json.CreateGuildEmojiParams, Discord.Models.ICustomEmoteModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildEmojiParams args) => CreateRoute(path, args);
}
public static class CreatableGuildEmoteExtensions
{
    public static async Task<Discord.IGuildEmote> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel> link,
        Discord.CreateGuildEmoteProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IGuildEmoteActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
