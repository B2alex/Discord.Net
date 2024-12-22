using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Collections.Immutable;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetGuild>,
    Modifiable<Routes.UpdateGuild, ModifyGuildProperties>,
    Deletable<Routes.DeleteGuild>,
    Refreshable,
    PagedFetchableOfMany<Routes.ListMyGuilds, PageUserGuildsParams, IPartialGuild>
]
public partial interface IGuildActor :
    IActor<ulong, IGuild>,
    IHasThreadsTrait<
        IThreadChannelActor.Indexable.WithActive.BackLink<IGuildActor>
    >,
    IInvitableTrait<IGuildInviteActor, IGuildInvite>
{
    [return: TypeHeuristic(nameof(Sounds))]
    IGuildSoundboardSoundActor Sound(ulong id) => Sounds[id];

    IGuildSoundboardSoundActor.Enumerable.Indexable Sounds { get; }

    [return: TypeHeuristic(nameof(Templates))]
    IGuildTemplateFromGuildActor Template(string code) => Templates[code];

    IGuildTemplateFromGuildActor.Enumerable.Indexable.BackLink<IGuildActor> Templates { get; }

    [return: TypeHeuristic(nameof(Channels))]
    IGuildChannelActor Channel(ulong id) => Channels[id];

    IGuildChannelActor.Enumerable.Indexable.Hierarchy.BackLink<IGuildActor> Channels { get; }

    [return: TypeHeuristic(nameof(Integrations))]
    IIntegrationActor Integration(ulong id) => Integrations[id];

    IIntegrationActor.Enumerable.Indexable Integrations { get; }

    [return: TypeHeuristic(nameof(Bans))]
    IBanActor Ban(ulong userId) => Bans[userId];

    IBanActor.Paged<PageGuildBansParams>.Indexable.BackLink<IGuildActor> Bans { get; }

    [return: TypeHeuristic(nameof(Members))]
    IMemberActor Member(ulong id) => Members[id];

    IMemberActor.Paged<PageGuildMembersParams>.Indexable.WithCurrent Members { get; }

    [return: TypeHeuristic(nameof(Emotes))]
    IGuildEmoteActor Emote(ulong id) => Emotes[id];

    IGuildEmoteActor.Enumerable.Indexable.BackLink<IGuildActor> Emotes { get; }

    [return: TypeHeuristic(nameof(Roles))]
    IRoleActor Role(ulong id) => Roles[id];

    IRoleActor.Enumerable.Indexable.BackLink<IGuildActor> Roles { get; }

    [return: TypeHeuristic(nameof(Stickers))]
    IGuildStickerActor Sticker(ulong id) => Stickers[id];

    IGuildStickerActor.Enumerable.Indexable.BackLink<IGuildActor> Stickers { get; }

    [return: TypeHeuristic(nameof(ScheduledEvents))]
    IGuildScheduledEventActor ScheduledEvent(ulong id) => ScheduledEvents[id];

    IGuildScheduledEventActor.Enumerable.Indexable.BackLink<IGuildActor> ScheduledEvents { get; }

    [return: TypeHeuristic(nameof(Webhooks))]
    IWebhookActor Webhook(ulong id) => Webhooks[id];

    IWebhookActor.Enumerable.Indexable Webhooks { get; }

    #region Methods

    async ValueTask LeaveAsync(
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .LeaveGuild
        .Create(this)
        .AsPipeline(options)
        .RunAsync(Client, token);

    async ValueTask<MfaLevel> ModifyMFALevelAsync(
        MfaLevel level,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .SetGuildMfaLevel
        .Create(this)
        .AsPipeline(
            new ModifyGuildMfaLevelParams {Level = (int) level},
            options
        )
        .Deserialize<MfaLevel>()
        .RunAsync(Client, token);

    ValueTask<int> GetPruneCountAsync(
        int? days = null,
        IEnumerable<IdOrEntity<ulong, IRole>>? includeRoles = null,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => Routes
        .PreviewPruneGuild
        .Create(this)
        .WithDays(days.AsOptional())
        .WithIncludeRoles(
            includeRoles
                .AsOptional()
                .Map(x =>
                    new CSVString(
                        x.Select(x => x.Id.ToString())
                    ).ToString()
                )
        )
        .AsPipeline(options)
        .Deserialize<GuildPruneCount>()
        .Required()
        .Transform(x => x.Pruned)
        .RunAsync(Client, token);

    ValueTask<int> BeginPruneAsync(
        int? days = null,
        bool? computePruneCount = null,
        IEnumerable<IdOrEntity<ulong, IRole>>? includedRoles = null,
        string? reason = null,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => Routes
        .PruneGuild
        .Create(this)
        .AsPipeline(
            new BeginGuildPruneParams()
            {
                Days = days.AsOptional(),
                ComputePruneCount = computePruneCount.AsOptional(),
                IncludeRoleIds = includedRoles
                    .AsOptional()
                    .Map(x => x
                        .Select(x => x.Id)
                        .ToArray()
                    ),
                Reason = reason.AsOptional()
            },
            options
        )
        .Deserialize<GuildPruneCount>()
        .Required()
        .Transform(x => x.Pruned)
        .RunAsync(Client, token);

    ValueTask<IReadOnlyCollection<IVoiceRegion>> GetGuildVoiceRegionsAsync(
        RequestOptions? options = null,
        CancellationToken token = default
    ) => Routes
        .ListGuildVoiceRegions
        .Create(this)
        .AsPipeline(options)
        .Deserialize<IEnumerable<IVoiceRegionModel>>()
        .Required()
        .Transform(static (models, client, token) => models
            .MapAsync(client.VoiceRegions.CreateEntityAsync, token)
        )
        .RunAsync(Client, token);

    #endregion

    [LinkExtension]
    private interface WithTemplatesExtension
    {
        IGuildTemplateActor.Indexable Templates { get; }
    }
}