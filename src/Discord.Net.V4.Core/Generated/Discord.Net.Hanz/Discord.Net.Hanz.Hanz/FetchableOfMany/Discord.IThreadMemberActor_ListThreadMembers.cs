using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IThreadMemberActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IThreadMemberModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IThreadMemberModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListThreadMembers(path.Require<Discord.IThreadChannel>());

    static IApiOutRoute<IEnumerable<Discord.Models.IThreadMemberModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IThreadMemberModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
