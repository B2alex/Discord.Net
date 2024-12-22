using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetGuildScheduledEvent>,
    Deletable<Routes.DeleteGuildScheduledEvent>,
    Creatable<Routes.CreateGuildScheduledEvent, CreateGuildScheduledEventProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    ),
    Modifiable<Routes.UpdateGuildScheduledEvent, ModifyGuildScheduledEventProperties>,
    FetchableOfMany<Routes.ListGuildScheduledEvents>, 
    Refreshable
]
public partial interface IGuildScheduledEventActor :
    IGuildActor.CanonicalRelationship,
    IActor<ulong, IGuildScheduledEvent>
{
    IGuildScheduledEventUserActor.Paged<PageGuildScheduledEventUsersParams> RSVPs { get; }
}