using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IMemberActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IMemberModel, Discord.PageGuildMembersParams, System.Collections.Generic.IEnumerable<Discord.Models.IMemberModel>>;
