using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable(nameof(Routes.GetChannel), typeof(GuildCategoryChannel)),
    Creatable<CreateGuildCategoryChannelProperties>(
        nameof(Routes.CreateGuildChannel),
        WhenBackLinkingFrom = [typeof(IGuildActor)],
        RouteGenerics = [typeof(GuildCategoryChannel)]
    )
]
public partial interface ICategoryChannelActor :
    IGuildChannelActor,
    IActor<ulong, ICategoryChannel>;