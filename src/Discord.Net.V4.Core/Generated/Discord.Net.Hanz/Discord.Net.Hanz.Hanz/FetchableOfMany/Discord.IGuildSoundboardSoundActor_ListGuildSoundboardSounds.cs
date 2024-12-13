using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.IGuildSoundboardSoundModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.IGuildSoundboardSoundModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListGuildSoundboardSounds(path.Require<Discord.IGuild>());

    static IApiOutRoute<IEnumerable<Discord.Models.IGuildSoundboardSoundModel>> Discord.IFetchableOfMany<ulong, Discord.Models.IGuildSoundboardSoundModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
