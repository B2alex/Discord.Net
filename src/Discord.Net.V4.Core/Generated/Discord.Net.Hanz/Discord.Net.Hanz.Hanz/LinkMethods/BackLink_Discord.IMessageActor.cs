using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class MessageBackLinkExtensions
{
    public static System.Threading.Tasks.Task BulkDeleteAsync(
        this Discord.IBackLink<Discord.IGuildChannelActor, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel> __link__,
        System.Collections.Generic.IEnumerable<Discord.IdOrEntity<ulong, Discord.IMessageActor>> messages,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        var ids = messages.Select(x => x.Id).ToArray();
        
        if (ids.Length is < DiscordConfig.MinBulkDeleteMessages or > DiscordConfig.MaxMessagesPerBatch)
            throw new ArgumentOutOfRangeException(
                nameof(messages),
                ids.Length,
                $"{nameof(ids)} must contain at least {DiscordConfig.MinBulkDeleteMessages} ids and at most " +
                $"{DiscordConfig.MaxBulkDeleteMessages} ids."
            );
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.BulkDeleteMessages(
                new BulkDeleteMessagesParams()
                {
                    Messages = ids
                },
                __link__.Source.Id
            ),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
