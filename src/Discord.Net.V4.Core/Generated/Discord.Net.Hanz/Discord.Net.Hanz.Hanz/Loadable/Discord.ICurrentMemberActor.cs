using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentMemberActor : 
    Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
    Discord.IFetchable<ulong, Discord.Models.IMemberModel>
{
    static new IApiOutRoute<Discord.Models.IMemberModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetCurrentUserGuildMember(path.Require<Discord.IGuild>());

    static IApiOutRoute<Discord.Models.IMemberModel> Discord.IFetchable<ulong, Discord.Models.IMemberModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.ICurrentMember?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.ICurrentMember?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.ICurrentMember?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>).FetchAsync(options, token);

    ValueTask<Discord.ICurrentMember?> Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.ICurrentMember?> Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.ICurrentMember?> Discord.ILoadable<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IMember?> Discord.IMemberActor.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IMember?> Discord.IMemberActor.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IMember?> Discord.IMemberActor.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
