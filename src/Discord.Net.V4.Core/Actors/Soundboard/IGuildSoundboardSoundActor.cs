using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetGuildSoundboardSound>,
    Creatable<Routes.CreateGuildSoundboardSound, CreateGuildSoundboardSoundProperties>,
    Modifiable<Routes.UpdateGuildSoundboardSound, ModifyGuildSoundboardSoundProperties>,
    Deletable<Routes.DeleteGuildSoundboardSound>,
    FetchableOfMany<Routes.ListGuildSoundboardSounds>
]
public partial interface IGuildSoundboardSoundActor :
    ISoundboardSoundActor,
    IActor<ulong, IGuildSoundboardSound>,
    IGuildActor.CanonicalRelationship;