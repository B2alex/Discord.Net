using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetGuildEmoji>,
    Deletable<Routes.DeleteGuildEmoji>,
    Creatable<Routes.CreateGuildEmoji, CreateGuildEmoteProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    ),
    Modifiable<Routes.UpdateGuildEmoji, ModifyGuildEmoteProperties>,
    Refreshable,
    FetchableOfMany<Routes.ListGuildEmojis>,
]
public partial interface IGuildEmoteActor :
    IActor<ulong, IGuildEmote>,
    IGuildActor.CanonicalRelationship;