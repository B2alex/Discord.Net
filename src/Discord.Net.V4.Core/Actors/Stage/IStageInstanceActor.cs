using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Loadable(nameof(Routes.GetStageInstance)),
    Modifiable<ModifyStageInstanceProperties>(nameof(Routes.ModifyStageInstance)),
    Deletable(nameof(Routes.DeleteStageInstance)),
    ActorCreatable<CreateStageInstanceProperties>(
        nameof(Routes.CreateStageInstance),
        WhenBackLinkingFrom = [typeof(IStageChannelActor)]
    ),
    Refreshable(nameof(Routes.GetStageInstance))
]
public partial interface IStageInstanceActor :
    IStageChannelActor.Relationship,
    IActor<ulong, IStageInstance>;