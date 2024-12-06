using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable(nameof(Routes.GetChannel), typeof(GuildMediaChannel)),
    Modifiable<ModifyMediaChannelProperties>(nameof(Routes.ModifyChannel)),
    Creatable<CreateGuildMediaChannelProperties>(
        nameof(Routes.CreateGuildChannel),
        WhenBackLinkingFrom = [typeof(IGuildActor)],
        RouteGenerics = [typeof(GuildMediaChannel)]
    )
]
public partial interface IMediaChannelActor :
    IThreadableChannelTrait<IThreadChannelActor.Indexable.WithArchived.BackLink<IMediaChannelActor>>,
    IIntegrationChannelTrait.WithIncoming,
    IActor<ulong, IMediaChannel>;