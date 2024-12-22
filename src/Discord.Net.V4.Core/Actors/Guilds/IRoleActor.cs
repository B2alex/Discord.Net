using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetGuildRole>,
    Deletable<Routes.DeleteGuildRole>,
    Creatable<Routes.CreateGuildRole, CreateRoleProperties>,
    Modifiable<Routes.UpdateGuildRole, ModifyRoleProperties>,
    FetchableOfMany<Routes.ListGuildRoles>
]
public partial interface IRoleActor :
    IGuildActor.CanonicalRelationship,
    IActor<ulong, IRole>
{
    [BackLink<IMemberActor>]
    private static async ValueTask AddAsync(
        IMemberActor member,
        IdOrEntity<ulong, IRoleActor> role,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .AddGuildMemberRole
        .Create(member.Guild.Id, member.Id, role.Id)
        .AsPipeline(options)
        .RunAsync(member, token);

    [BackLink<IMemberActor>]
    private static async ValueTask RemoveAsync(
        IMemberActor member,
        IdOrEntity<ulong, IRoleActor> role,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .DeleteGuildMemberRole
        .Create(member.Guild.Id, member.Id, role.Id)
        .AsPipeline(options)
        .RunAsync(member, token);
}