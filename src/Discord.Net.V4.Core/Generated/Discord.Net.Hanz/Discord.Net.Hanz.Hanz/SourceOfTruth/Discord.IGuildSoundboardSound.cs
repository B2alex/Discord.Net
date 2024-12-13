using Discord.Rest;
using Discord.Models;

namespace Discord;

public partial interface IGuildSoundboardSound
{
    Discord.Models.ISoundboardSoundModel IEntityOf<ISoundboardSoundModel>.GetModel() => GetModel();

    Discord.Models.IGuildSoundboardSoundModel IEntityOf<IGuildSoundboardSoundModel>.GetModel() => GetModel();
}
