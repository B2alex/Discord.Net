using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IGuildModel, Discord.PageUserGuildsParams, System.Collections.Generic.IEnumerable<Discord.Models.IPartialGuildModel>>;
