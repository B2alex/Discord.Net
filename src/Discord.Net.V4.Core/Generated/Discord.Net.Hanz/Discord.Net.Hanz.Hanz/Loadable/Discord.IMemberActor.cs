using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMemberActor : 
    Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
    Discord.IFetchable<ulong, Discord.Models.IMemberModel>
{
    static new IApiOutRoute<Discord.Models.IMemberModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildMember(path.Require<Discord.IGuild>(), id);

    static IApiOutRoute<Discord.Models.IMemberModel> Discord.IFetchable<ulong, Discord.Models.IMemberModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.IMember?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.IMember?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.IMember?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>).FetchAsync(options, token);

    ValueTask<Discord.IMember?> Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.IMember?> Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.IMember?> Discord.ILoadable<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);
}
