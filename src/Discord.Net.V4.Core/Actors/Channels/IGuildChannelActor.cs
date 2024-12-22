using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Modifiable<Routes.UpdateChannel, ModifyGuildChannelProperties>,
    Deletable<Routes.DeleteChannel>,
    Creatable<Routes.CreateGuildChannel, CreateGuildChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    ),
    FetchableOfMany<Routes.ListGuildChannels>,
    LinkHierarchicalRoot
]
public partial interface IGuildChannelActor :
    IGuildActor.CanonicalRelationship,
    IChannelActor,
    IActor<ulong, IGuildChannel>
{
    [BackLink<IGuildActor>]
    private static async Task ModifyPositionsAsync(
        IGuildActor guild,
        IEnumerable<ModifyGuildChannelPositionProperties> positions,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes.BulkUpdateGuildChannels
        .Create(guild)
        .AsPipeline(
            positions
                .Select(x => x.ToApiModel())
                .AsCollectionParams(),
            options
        )
        .RunAsync(guild.Client, token);
}