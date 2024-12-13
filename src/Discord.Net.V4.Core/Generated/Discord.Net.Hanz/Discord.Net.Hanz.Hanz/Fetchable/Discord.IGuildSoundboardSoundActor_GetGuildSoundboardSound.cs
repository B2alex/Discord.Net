using Discord.Rest;
using Discord;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.IFetchable<ulong, Discord.Models.IGuildSoundboardSoundModel>
{
    static new IApiOutRoute<Discord.Models.IGuildSoundboardSoundModel> FetchRoute(IPathable path, ulong id) => Discord.Rest.Routes.GetGuildSoundboardSound(path.Require<Discord.IGuild>(), path.Require<Discord.ISoundboardSound>());

    static IApiOutRoute<Discord.Models.IGuildSoundboardSoundModel> Discord.IFetchable<ulong, Discord.Models.IGuildSoundboardSoundModel>.FetchRoute(IPathable path, ulong id) => FetchRoute(path, id);
}
