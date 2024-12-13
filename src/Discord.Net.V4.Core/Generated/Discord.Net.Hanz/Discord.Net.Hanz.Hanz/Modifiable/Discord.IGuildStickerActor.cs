using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildStickerActor : 
    Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.Actor<Discord.IGuildStickerActor, Discord.IGuildSticker>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => Discord.Rest.Routes.ModifyGuildSticker(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel> Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.Actor<Discord.IGuildStickerActor, Discord.IGuildSticker>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildStickerParams> Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildSticker : 
    Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.Entity<Discord.IGuildSticker>,
    Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => Discord.Rest.Routes.ModifyGuildSticker(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel> Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.Entity<Discord.IGuildSticker>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildStickerParams> Discord.IModifiable<ulong, Discord.ModifyStickerProperties, Discord.Models.Json.ModifyGuildStickerParams, Discord.Models.IGuildStickerModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyGuildStickerParams args
    ) => ModifyRoute(path, id, args);
}
