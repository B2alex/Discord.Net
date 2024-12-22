using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetGuildBan>,
    Deletable<Routes.UnbanUserFromGuild>,
    Refreshable,
    PagedFetchableOfMany<Routes.ListGuildBans, PageGuildBansParams>
]
public partial interface IBanActor :
    IGuildActor.CanonicalRelationship,
    IUserActor.Relationship,
    IActor<ulong, IBan>
{
    [BackLink<IGuildActor>]
    private static async ValueTask CreateAsync(
        IGuildActor guild,
        IdOrEntity<ulong, IUserActor> user,
        int? purgeMessageSeconds = null,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .BanUserFromGuild
        .Create(guild.Id, user.Id)
        .AsPipeline(
            new CreateGuildBanParams()
            {
                DeleteMessageSeconds = purgeMessageSeconds.AsOptional()
            }
        )
        .RunAsync(guild.Client, token);

    [BackLink<IGuildActor>]
    private static ValueTask<BulkBanResult> BulkCreateAsync(
        IGuildActor guild,
        IEnumerable<IdOrEntity<ulong, IUser>> users,
        int? purgeMessageSeconds = null,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => Routes
        .BulkBanUsersFromGuild
        .Create(guild)
        .AsPipeline(
            new BulkBanUsersParams()
            {
                UserIds = users.Ids().ToArray(),
                DeleteMessageSeconds = purgeMessageSeconds.AsOptional()
            },
            options
        )
        .Deserialize<BulkBanResponse>()
        .Required()
        .Construct(default(BulkBanResult))
        .RunAsync(guild, token);
}