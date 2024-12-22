using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Modifiable<Routes.UpdateGuildTemplate, ModifyGuildTemplateProperties>,
    Deletable<Routes.DeleteGuildTemplate>, 
    Refreshable<Routes.GetGuildTemplate>,
    FetchableOfMany<Routes.ListGuildTemplates>
]
public partial interface IGuildTemplateFromGuildActor :
    IGuildTemplateActor,
    IGuildActor.CanonicalRelationship
{
    async ValueTask SyncAsync(
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .SyncGuildTemplate
        .Create(this)
        .AsPipeline(options)
        .RunAsync(Client, token);
}