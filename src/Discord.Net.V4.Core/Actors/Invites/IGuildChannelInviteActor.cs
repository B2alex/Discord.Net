using Discord.Rest;

namespace Discord;

[
    Creatable<Routes.CreateChannelInvite, CreateChannelInviteProperties>,
    FetchableOfMany<Routes.ListChannelInvites>
]
public partial interface IGuildChannelInviteActor :
    IGuildInviteActor,
    IChannelInviteActor,
    IGuildChannelActor.CanonicalRelationship,
    IActor<string, IGuildChannelInvite>
{
    [SourceOfTruth] new IGuildChannelActor Channel { get; }
}