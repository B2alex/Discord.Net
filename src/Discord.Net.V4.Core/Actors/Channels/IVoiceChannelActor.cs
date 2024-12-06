using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable(nameof(Routes.GetChannel), typeof(GuildVoiceChannel)),
    Modifiable<ModifyVoiceChannelProperties>(nameof(Routes.ModifyChannel)),
    Creatable<CreateGuildVoiceChannelProperties>(
        nameof(Routes.CreateGuildChannel),
        WhenBackLinkingFrom = [typeof(IGuildActor)],
        RouteGenerics = [typeof(GuildVoiceChannel)]
    )
]
public partial interface IVoiceChannelActor :
    IGuildChannelActor,
    IMessageChannelTrait,
    IInvitableTrait<IGuildChannelInviteActor, IGuildChannelInvite>,
    IIntegrationChannelTrait.WithIncoming,
    IActor<ulong, IVoiceChannel>;