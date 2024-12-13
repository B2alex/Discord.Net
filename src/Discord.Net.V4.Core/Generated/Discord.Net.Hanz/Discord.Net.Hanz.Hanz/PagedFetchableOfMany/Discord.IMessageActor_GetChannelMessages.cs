using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IMessageActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IMessageModel, Discord.PageChannelMessagesParams, System.Collections.Generic.IEnumerable<Discord.Models.IMessageModel>>;
