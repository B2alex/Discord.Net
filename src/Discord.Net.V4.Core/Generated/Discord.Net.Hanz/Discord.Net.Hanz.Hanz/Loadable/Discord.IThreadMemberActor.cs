using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IThreadMemberActor : 
    Discord.ILoadable<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
    Discord.IFetchable<ulong, Discord.Models.IThreadMemberModel>
{
    static new IApiOutRoute<Discord.Models.IThreadMemberModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetThreadMember(path.Require<Discord.IThreadChannel>(), id);

    static IApiOutRoute<Discord.Models.IThreadMemberModel> Discord.IFetchable<ulong, Discord.Models.IThreadMemberModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
