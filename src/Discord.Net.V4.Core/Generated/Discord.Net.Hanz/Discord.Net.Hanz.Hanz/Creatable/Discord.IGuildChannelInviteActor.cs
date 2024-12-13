using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildChannelInviteActor : 
    Discord.ICreatable<Discord.IGuildChannelInviteActor, Discord.IGuildChannelInvite, string, Discord.CreateChannelInviteProperties, Discord.Models.Json.CreateChannelInviteParams, Discord.Models.IInviteModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateChannelInviteParams, Discord.Models.IInviteModel> CreateRoute(IPathable path, Discord.Models.Json.CreateChannelInviteParams args) => Discord.Rest.Routes.CreateChannelInvite(path.Require<Discord.IChannel>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateChannelInviteParams, Discord.Models.IInviteModel> Discord.ICreatable<Discord.IGuildChannelInviteActor, Discord.IGuildChannelInvite, string, Discord.CreateChannelInviteProperties, Discord.Models.Json.CreateChannelInviteParams, Discord.Models.IInviteModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateChannelInviteParams args) => CreateRoute(path, args);
}
