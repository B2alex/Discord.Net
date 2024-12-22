using Discord.Models;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetGuildTemplate>,
    Creatable<Routes.CreateGuildTemplate, CreateGuildTemplateProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    )
]
public partial interface IGuildTemplateActor :
    IActor<string, IGuildTemplate>
{
    async Task<IGuild> CreateGuildAsync(
        CreateGuildFromTemplateProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .CreateGuildFromTemplate
        .Create(this)
        .AsPipeline(
            args.ToApiModel(),
            options
        )
        .Deserialize<IGuildModel>()
        .Required()
        .Transform(Client.Guilds.CreateEntityAsync)
        .RunAsync(Client, token);
}