using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildStickerActor : 
    Discord.ICreatable<Discord.IGuildStickerActor, Discord.IGuildSticker, ulong, Discord.CreateGuildStickerProperties, Discord.Models.Json.CreateGuildStickerParams, Discord.Models.IGuildStickerModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildStickerParams, Discord.Models.IGuildStickerModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildStickerParams args) => Discord.Rest.Routes.CreateGuildSticker(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildStickerParams, Discord.Models.IGuildStickerModel> Discord.ICreatable<Discord.IGuildStickerActor, Discord.IGuildSticker, ulong, Discord.CreateGuildStickerProperties, Discord.Models.Json.CreateGuildStickerParams, Discord.Models.IGuildStickerModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildStickerParams args) => CreateRoute(path, args);
}
public static class CreatableGuildStickerExtensions
{
    public static async Task<Discord.IGuildSticker> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel> link,
        Discord.CreateGuildStickerProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IGuildStickerActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
