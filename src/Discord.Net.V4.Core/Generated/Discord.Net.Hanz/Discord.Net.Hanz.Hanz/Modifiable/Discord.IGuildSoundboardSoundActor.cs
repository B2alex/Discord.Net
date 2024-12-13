using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.Actor<Discord.IGuildSoundboardSoundActor, Discord.IGuildSoundboardSound>
{
    internal static new IApiInOutRoute<Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => Discord.Rest.Routes.ModifyGuildSoundboardSound(path.Require<Discord.IGuild>(), id, args);

    static IApiInOutRoute<Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.Actor<Discord.IGuildSoundboardSoundActor, Discord.IGuildSoundboardSound>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.ModifyGuildSoundboardSoundParams> Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildSoundboardSound : 
    Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.Entity<Discord.IGuildSoundboardSound>,
    Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>
{
    internal new static IApiInOutRoute<Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => Discord.Rest.Routes.ModifyGuildSoundboardSound(path.Require<Discord.IGuild>(), id, args);

    static IApiInOutRoute<Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel> Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.Entity<Discord.IGuildSoundboardSound>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.ModifyGuildSoundboardSoundParams> Discord.IModifiable<ulong, Discord.ModifyGuildSoundboardSoundProperties, Discord.Models.ModifyGuildSoundboardSoundParams, Discord.Models.IGuildSoundboardSoundModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.ModifyGuildSoundboardSoundParams args
    ) => ModifyRoute(path, id, args);
}
