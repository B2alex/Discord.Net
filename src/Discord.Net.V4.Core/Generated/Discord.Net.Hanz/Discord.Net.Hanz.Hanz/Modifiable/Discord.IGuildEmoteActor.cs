using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildEmoteActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.Actor<Discord.IGuildEmoteActor, Discord.IGuildEmote>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => Discord.Rest.Routes.ModifyGuildEmoji(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel> Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.Actor<Discord.IGuildEmoteActor, Discord.IGuildEmote>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyEmojiParams> Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildEmote : 
    Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.Entity<Discord.IGuildEmote>,
    Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => Discord.Rest.Routes.ModifyGuildEmoji(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel> Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.Entity<Discord.IGuildEmote>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyEmojiParams> Discord.IModifiable<ulong, Discord.ModifyGuildEmoteProperties, Discord.Models.Json.ModifyEmojiParams, Discord.Models.ICustomEmoteModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyEmojiParams args
    ) => ModifyRoute(path, id, args);
}
