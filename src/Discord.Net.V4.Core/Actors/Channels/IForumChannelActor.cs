using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Modifiable<Routes.UpdateChannel, ModifyForumChannelProperties>,
    Creatable<Routes.CreateGuildChannel, CreateGuildForumChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    ),
]
public partial interface IForumChannelActor :
    IThreadableChannelTrait
    <
        IThreadChannelActor.Indexable.WithArchived.BackLink<IForumChannelActor>
    >,
    IIntegrationChannelTrait.WithIncoming,
    IActor<ulong, IForumChannel>;