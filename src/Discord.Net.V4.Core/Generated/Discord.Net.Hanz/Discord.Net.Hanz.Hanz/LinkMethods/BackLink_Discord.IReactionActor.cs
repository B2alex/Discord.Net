using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public static class ReactionBackLinkExtensions
{
    public static System.Threading.Tasks.Task RemoveAllAsync(
        this Discord.IBackLink<Discord.IMessageActor, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel> __link__,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.DeleteAllReactions(__link__.Source.Channel.Id, __link__.Source.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
