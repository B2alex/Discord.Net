using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IApplicationEmoteActor : 
    Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.Actor<Discord.IApplicationEmoteActor, Discord.IApplicationEmote>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => Discord.Rest.Routes.ModifyApplicationEmoji(path.Require<Discord.IApplication>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel> Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.Actor<Discord.IApplicationEmoteActor, Discord.IApplicationEmote>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyApplicationEmojiParams> Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IApplicationEmote : 
    Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.Entity<Discord.IApplicationEmote>,
    Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => Discord.Rest.Routes.ModifyApplicationEmoji(path.Require<Discord.IApplication>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel> Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.Entity<Discord.IApplicationEmote>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyApplicationEmojiParams> Discord.IModifiable<ulong, Discord.ModifyApplicationEmoteProperties, Discord.Models.Json.ModifyApplicationEmojiParams, Discord.Models.ICustomEmoteModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyApplicationEmojiParams args
    ) => ModifyRoute(path, id, args);
}
