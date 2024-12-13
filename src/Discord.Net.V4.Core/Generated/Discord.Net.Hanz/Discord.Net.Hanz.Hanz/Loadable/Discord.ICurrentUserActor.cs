using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentUserActor : 
    Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
    Discord.IFetchable<ulong, Discord.Models.ISelfUserModel>
{
    static new IApiOutRoute<Discord.Models.ISelfUserModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetCurrentUser;

    static IApiOutRoute<Discord.Models.ISelfUserModel> Discord.IFetchable<ulong, Discord.Models.ISelfUserModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.ICurrentUser?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.ICurrentUser?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.ICurrentUser?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>).FetchAsync(options, token);

    ValueTask<Discord.ICurrentUser?> Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.ICurrentUser?> Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.ICurrentUser?> Discord.ILoadable<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IUser?> Discord.ILoadable<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IUser?> Discord.ILoadable<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IUser?> Discord.ILoadable<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
