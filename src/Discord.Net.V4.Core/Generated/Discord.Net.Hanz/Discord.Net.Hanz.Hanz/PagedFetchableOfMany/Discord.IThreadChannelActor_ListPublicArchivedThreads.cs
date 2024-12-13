using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IThreadChannelActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IThreadChannelModel, Discord.PagePublicArchivedThreadsParams, Discord.Models.Json.ChannelThreads>;
