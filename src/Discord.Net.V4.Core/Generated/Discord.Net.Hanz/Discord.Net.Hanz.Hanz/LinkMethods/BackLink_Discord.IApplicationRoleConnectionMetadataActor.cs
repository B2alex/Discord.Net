using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public static class ApplicationRoleConnectionMetadataBackLinkExtensions
{
    public static async System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyCollection<Discord.IApplicationRoleConnectionMetadata>> UpdateAsync(
        this Discord.IBackLink<Discord.IApplicationActor, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel> __link__,
        System.Collections.Generic.IEnumerable<Discord.ModifyApplicationRoleConnectionMetadataProperties> metadatas,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        var result = await __link__.Client.RestApiClient.ExecuteRequiredAsync(
            Routes.ModifyApplicationRoleConnectionMetadata(
                __link__.Source.Id,
                metadatas.Select(x => x.ToApiModel())
            ),
            options,
            token
        );
        
        return await result.MapAsync(__link__.CreateEntityAsync, token);
    }
    
}
