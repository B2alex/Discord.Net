using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.ICreatable<Discord.IGuildSoundboardSoundActor, Discord.IGuildSoundboardSound, ulong, Discord.CreateGuildSoundboardSoundProperties, Discord.Models.CreateGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>
{
    internal static new IApiInOutRoute<Discord.Models.CreateGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> CreateRoute(IPathable path, Discord.Models.CreateGuildSoundboardSoundParams args) => Discord.Rest.Routes.CreateGuildSoundboardSound(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.CreateGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> Discord.ICreatable<Discord.IGuildSoundboardSoundActor, Discord.IGuildSoundboardSound, ulong, Discord.CreateGuildSoundboardSoundProperties, Discord.Models.CreateGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.CreateRoute(IPathable path, Discord.Models.CreateGuildSoundboardSoundParams args) => CreateRoute(path, args);
}
