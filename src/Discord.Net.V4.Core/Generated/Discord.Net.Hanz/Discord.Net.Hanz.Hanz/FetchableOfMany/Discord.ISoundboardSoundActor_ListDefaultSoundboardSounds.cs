using Discord.Rest;
using Discord;

namespace Discord;

public partial interface ISoundboardSoundActor : 
    Discord.IFetchableOfMany<ulong, Discord.Models.ISoundboardSoundModel>
{
    static new IApiOutRoute<IEnumerable<Discord.Models.ISoundboardSoundModel>> FetchManyRoute(IPathable path) => Discord.Rest.Routes.ListDefaultSoundboardSounds;

    static IApiOutRoute<IEnumerable<Discord.Models.ISoundboardSoundModel>> Discord.IFetchableOfMany<ulong, Discord.Models.ISoundboardSoundModel>.FetchManyRoute(IPathable path) => FetchManyRoute(path);
}
