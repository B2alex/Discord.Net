using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IBanActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IBanModel, Discord.PageGuildBansParams, System.Collections.Generic.IEnumerable<Discord.Models.IBanModel>>;
