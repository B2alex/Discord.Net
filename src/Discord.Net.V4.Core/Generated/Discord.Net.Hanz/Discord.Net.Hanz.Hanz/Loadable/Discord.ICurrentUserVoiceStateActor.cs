using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface ICurrentUserVoiceStateActor : 
    Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
    Discord.IFetchable<ulong, Discord.Models.IVoiceStateModel>
{
    static new IApiOutRoute<Discord.Models.IVoiceStateModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetCurrentUserVoiceState(path.Require<Discord.IGuild>());

    static IApiOutRoute<Discord.Models.IVoiceStateModel> Discord.IFetchable<ulong, Discord.Models.IVoiceStateModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);

    new ValueTask<Discord.ICurrentUserVoiceState?> GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>).GetOrFetchAsync(options, token);

    new ValueTask<Discord.ICurrentUserVoiceState?> GetAsync(CancellationToken token = default) => default;

    new ValueTask<Discord.ICurrentUserVoiceState?> FetchAsync(RequestOptions? options = null, CancellationToken token = default) => (this as Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>).FetchAsync(options, token);

    ValueTask<Discord.ICurrentUserVoiceState?> Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => GetOrFetchAsync(options, token);

    ValueTask<Discord.ICurrentUserVoiceState?> Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.GetAsync(CancellationToken token = default) => GetAsync(token);

    ValueTask<Discord.ICurrentUserVoiceState?> Discord.ILoadable<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => FetchAsync(options, token);

    async ValueTask<Discord.IVoiceState?> Discord.ILoadable<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.GetOrFetchAsync(RequestOptions? options = null, CancellationToken token = default) => await GetOrFetchAsync(options, token);

    async ValueTask<Discord.IVoiceState?> Discord.ILoadable<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.GetAsync(CancellationToken token = default) => await GetAsync(token);

    async ValueTask<Discord.IVoiceState?> Discord.ILoadable<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.FetchAsync(RequestOptions? options = null, CancellationToken token = default) => await FetchAsync(options, token);
}
