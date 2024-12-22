using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;
using Discord;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Creatable<Routes.CreateGuildChannel, CreateGuildStageChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
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