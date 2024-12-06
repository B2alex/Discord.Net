using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;
using Discord;

namespace Discord;

[
    Loadable(nameof(Routes.GetChannel), typeof(GuildStageChannel)),
    Creatable<CreateGuildStageChannelProperties>(
        nameof(Routes.CreateGuildChannel),
        WhenBackLinkingFrom = [typeof(IGuildActor)],
        RouteGenerics = [typeof(GuildStageChannel)]
    )
]
public partial interface IStageChannelActor :
    IActor<ulong, IStageChannel>,
    IEntityProvider<IStageInstance, IStageInstanceModel>,
    IVoiceChannelActor,
    IIntegrationChannelTrait.WithChannelFollower
{
    IStageInstanceActor.BackLink<IStageChannelActor> Instance { get; }
}