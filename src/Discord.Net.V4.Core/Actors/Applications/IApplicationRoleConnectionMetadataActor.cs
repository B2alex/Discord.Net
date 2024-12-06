using Discord.Rest;

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
        CancellationToken token = default)
    {
        var result = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Routes.ModifyApplicationRoleConnectionMetadata(
                application.Id,
                metadatas.Select(x => x.ToApiModel())
            ),
            options,
            token
        );

        return await result.MapAsync(link.CreateEntityAsync, token);
    }
}