using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Deletable<Routes.InviteRevoke>,
    FetchableOfMany<Routes.ListGuildInvites>
]
public partial interface IGuildInviteActor :
    IInviteActor,
    IActor<string, IGuildInvite>,
    IEntityProvider<IGuildInvite, IInviteModel>,
    IGuildActor.CanonicalRelationship;