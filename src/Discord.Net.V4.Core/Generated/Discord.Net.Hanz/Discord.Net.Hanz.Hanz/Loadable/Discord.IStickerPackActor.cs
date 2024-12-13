using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStickerPackActor : 
    Discord.ILoadable<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>;
