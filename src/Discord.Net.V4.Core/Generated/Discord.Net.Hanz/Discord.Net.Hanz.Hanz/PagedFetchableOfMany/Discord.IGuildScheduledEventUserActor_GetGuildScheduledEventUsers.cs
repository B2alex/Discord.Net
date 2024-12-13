using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildScheduledEventUserActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IGuildScheduledEventUserModel, Discord.PageGuildScheduledEventUsersParams, System.Collections.Generic.IEnumerable<Discord.Models.IGuildScheduledEventUserModel>>;
