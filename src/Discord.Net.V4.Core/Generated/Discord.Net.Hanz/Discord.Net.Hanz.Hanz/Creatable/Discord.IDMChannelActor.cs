using Discord.Models;
using Discord;

namespace Discord;

public partial interface IDMChannelActor : 
    Discord.ICreatable<Discord.IDMChannelActor, Discord.IDMChannel, ulong, Discord.CreateDMProperties, Discord.Models.Json.CreateDMChannelParams, Discord.Models.IDMChannelModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateDMChannelParams, Discord.Models.IDMChannelModel> CreateRoute(IPathable path, Discord.Models.Json.CreateDMChannelParams args) => Discord.Rest.Routes.CreateDm(args);

    static IApiInOutRoute<Discord.Models.Json.CreateDMChannelParams, Discord.Models.IDMChannelModel> Discord.ICreatable<Discord.IDMChannelActor, Discord.IDMChannel, ulong, Discord.CreateDMProperties, Discord.Models.Json.CreateDMChannelParams, Discord.Models.IDMChannelModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateDMChannelParams args) => CreateRoute(path, args);
}
