using Discord.Rest;
using Discord.Rest.Pipeline;
using Discord.Models;

namespace Discord;

public partial interface IApplicationRoleConnectionMetadataActor :
    IActor<string, IApplicationRoleConnectionMetadata>,
    IApplicationActor.CanonicalRelationship
{
    [BackLink<IApplicationActor>]
    private static async Task<IReadOnlyCollection<IApplicationRoleConnectionMetadata>> UpdateAsync(
        IApplicationActor application,
        Link link,
        IEnumerable<ModifyApplicationRoleConnectionMetadataProperties> metadatas,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes.UpdateApplicationRoleConnectionsMetadata
        .Create(application)
        .AsPipeline(
            metadatas.Select(x => x.ToApiModel()).AsCollectionParams(),
            options
        )
        .Deserialize<IEnumerable<IApplicationRoleConnectionMetadataModel>>()
        .Required()
        .Transform(
            (models, token) => models.MapAsync(link.CreateEntityAsync, token)
        )
        .RunAsync(link.Client, token);
}