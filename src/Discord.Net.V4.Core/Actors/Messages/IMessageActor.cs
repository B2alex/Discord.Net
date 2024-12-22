using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[
    Loadable<Routes.GetMessage>,
    Deletable<Routes.DeleteMessage>,
    Creatable<Routes.CreateMessage, CreateMessageProperties>
    (
        WhenBackLinkingFrom = [typeof(IMessageChannelTrait)]
    ),
    Modifiable<Routes.UpdateMessage, ModifyMessageProperties>,
    PagedFetchableOfMany<Routes.ListMessages, PageChannelMessagesParams>,
    Refreshable
]
public partial interface IMessageActor :
    IMessageChannelTrait.CanonicalRelationship,
    IActor<ulong, IMessage>
{
    IPollActor Poll { get; }
    IReactionActor.Indexable.BackLink<IMessageActor> Reactions { get; }

    [BackLink<IGuildChannelActor>]
    private static async ValueTask BulkDeleteAsync(
        IGuildChannelActor channel,
        IEnumerable<IdOrEntity<ulong, IMessageActor>> messages,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .BulkDeleteMessages
        .Create(channel)
        .AsPipeline(
            new BulkDeleteMessagesParams()
            {
                Messages = messages.Ids().ToArray()
            },
            options
        )
        .RunAsync(channel, token);
}