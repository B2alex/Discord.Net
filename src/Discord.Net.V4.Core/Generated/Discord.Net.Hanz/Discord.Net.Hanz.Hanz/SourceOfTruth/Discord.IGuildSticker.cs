using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Models;

namespace Discord;

public partial interface IGuildSticker
{
    Discord.Models.IGuildStickerModel IEntityOf<IGuildStickerModel>.GetModel() => GetModel();

    Discord.Models.IStickerModel IEntityOf<IStickerModel>.GetModel() => GetModel();
}
