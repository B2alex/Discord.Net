using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

[
    Trait,
    Loadable(nameof(Routes.GetChannel), typeof(ThreadableChannelBase)),
    Modifiable<ModifyThreadableChannelProperties>(nameof(Routes.ModifyChannel)),
]
public partial interface IThreadableChannelTrait :
    IGuildChannelActor,
    IInvitableTrait<IGuildChannelInviteActor, IGuildChannelInvite>,
    IHasThreadsTrait,
    IActorTrait<ulong, IThreadableChannel>;

[Trait]
public partial interface IThreadableChannelTrait<TLink> :
    IThreadableChannelTrait,
    IHasThreadsTrait<TLink>
    where TLink : class, IThreadChannelActor.Indexable;