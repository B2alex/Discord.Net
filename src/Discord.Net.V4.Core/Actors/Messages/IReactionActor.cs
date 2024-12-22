using Discord.Models;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[Deletable<Routes.DeleteAllMessageReactionsByEmoji>]
public partial interface IReactionActor :
    IActor<DiscordEmojiId, IReaction>,
    IMessageActor.CanonicalRelationship,
    IEntityProvider<IReaction, IReactionModel>
{
    IUserActor.Paged<PageUserReactionsParams>.Indexable.WithCurrent.BackLink<IReactionActor> Users { get; }

    [OnVertex]
    private static async ValueTask AddAsync(
        ICurrentUserActor.BackLink<IReactionActor> target,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .AddMyMessageReaction
        .Create(target)
        .AsPipeline(options)
        .RunAsync(target, token);

    [BackLink<IMessageActor>]
    private static async ValueTask RemoveAllAsync(
        IMessageActor message,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .DeleteAllMessageReactions
        .Create(message)
        .AsPipeline(options)
        .RunAsync(message, token);

    [OnVertex]
    private static async ValueTask RemoveAsync(
        IUserActor.BackLink<IReactionActor> target,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        if (target is ICurrentUserActor.Link)
        {
            await Routes
                .DeleteMyMessageReaction
                .Create(target)
                .AsPipeline(options)
                .RunAsync(target, token);
        }
        else
        {
            await Routes
                .DeleteUserMessageReaction
                .Create(target)
                .AsPipeline(options)
                .RunAsync(target, token);
        }
    }
}