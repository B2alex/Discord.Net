using Discord.Models;
using Discord.Rest;

namespace Discord;

[FetchableOfMany<Routes.ListChannelInvites>]
public partial interface IChannelInviteActor :
    IInviteActor,
    IChannelActor.CanonicalRelationship,
    IEntityProvider<IChannelInvite, IInviteModel>,
    IActor<string, IChannelInvite>;
