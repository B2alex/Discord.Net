using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Modifiable<Routes.UpdateChannel, ModifyTextChannelProperties>,
    Creatable<Routes.CreateGuildChannel, CreateGuildTextChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    )
]
public partial interface ITextChannelActor :
    IMessageChannelTrait,
    IThreadableChannelTrait<IThreadChannelActor.Indexable.WithArchived.BackLink<ITextChannelActor>>,
    IIntegrationChannelTrait.WithIncoming.WithChannelFollower,
    IActor<ulong, ITextChannel>;