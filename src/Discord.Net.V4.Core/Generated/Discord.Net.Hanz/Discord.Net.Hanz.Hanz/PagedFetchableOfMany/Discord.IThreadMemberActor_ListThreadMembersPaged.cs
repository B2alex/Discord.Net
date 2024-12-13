using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IThreadMemberActor : 
    Discord.IPagedFetchableOfMany<ulong, Discord.Models.IThreadMemberModel, Discord.PageThreadMembersParams, System.Collections.Generic.IEnumerable<Discord.Models.IThreadMemberModel>>;
