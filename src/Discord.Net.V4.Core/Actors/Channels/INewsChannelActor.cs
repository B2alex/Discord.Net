using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;
using Discord.Models;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetChannel>,
    Creatable<Routes.CreateGuildChannel, CreateGuildAnnouncementChannelProperties>
    (
        WhenBackLinkingFrom = [typeof(IGuildActor)]
    )
]
public partial interface IAnnouncementChannelActor :
    IMessageChannelTrait,
    IIntegrationChannelTrait.WithIncoming.WithChannelFollower,
    IThreadableChannelTrait<IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<
        IAnnouncementChannelActor>>,
    IActor<ulong, IAnnouncementChannel>
{
    async Task<FollowedChannel> FollowAnnouncementChannelAsync(
        IdOrEntity<ulong, ITextChannel> channel,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes.FollowChannel
        .Create(this)
        .AsPipeline(
            new FollowAnnouncementChannelParams()
            {
                WebhookChannelId = channel.Id
            },
            options
        )
        .Deserialize<Models.Json.FollowedChannel>()
        .Required()
        .Transform((model, client, _) => ValueTask.FromResult(FollowedChannel.Construct(client, model)))
        .RunAsync(Client, token);
}