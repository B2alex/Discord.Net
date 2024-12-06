using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable(nameof(Routes.GetChannel), typeof(GuildForumChannel)),
    Modifiable<ModifyForumChannelProperties>(nameof(Routes.ModifyChannel)),
    Creatable<CreateGuildForumChannelProperties>(
        nameof(Routes.CreateGuildChannel),
        WhenBackLinkingFrom = [typeof(IGuildActor)],
        RouteGenerics = [typeof(GuildForumChannel)]
    ),
]
public partial interface IForumChannelActor :
    IThreadableChannelTrait
    <
        IThreadChannelActor.Indexable.WithArchived.BackLink<IForumChannelActor>
    >,
    IIntegrationChannelTrait.WithIncoming,
    IActor<ulong, IForumChannel>;