using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Modifiable<Routes.UpdateChannel, ModifyMediaChannelProperties>,
    Creatable<Routes.CreateGuildChannel, CreateGuildMediaChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    )
]
public partial interface IMediaChannelActor :
    IThreadableChannelTrait<IThreadChannelActor.Indexable.WithArchived.BackLink<IMediaChannelActor>>,
    IIntegrationChannelTrait.WithIncoming,
    IActor<ulong, IMediaChannel>;