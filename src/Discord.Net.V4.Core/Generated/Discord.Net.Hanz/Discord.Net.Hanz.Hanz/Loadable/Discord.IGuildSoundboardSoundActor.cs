using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.ILoadable<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>;
