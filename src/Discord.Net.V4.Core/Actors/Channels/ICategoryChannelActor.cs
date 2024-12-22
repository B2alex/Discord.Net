using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Creatable<Routes.CreateGuildChannel, CreateGuildCategoryChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    )
]
public partial interface ICategoryChannelActor :
    IGuildChannelActor,
    IActor<ulong, ICategoryChannel>;