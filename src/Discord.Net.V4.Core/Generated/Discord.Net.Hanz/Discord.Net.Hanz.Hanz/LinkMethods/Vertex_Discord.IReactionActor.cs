using Discord.Rest;
using Discord.Models;

namespace Discord;

public static class IReactionActorVertexExtensions
{
    public static System.Threading.Tasks.Task RemoveAsync(
        this Discord.IUserActor.BackLink<Discord.IReactionActor> target,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return target.Client.RestApiClient.ExecuteAsync(
            target is ICurrentUserActor.Link
                ? Routes.DeleteOwnReaction(target.Source.Message.Channel.Id, target.Source.Message.Id, target.Source.Id)
                : Routes.DeleteUserReaction(target.Source.Message.Channel.Id, target.Source.Message.Id, target.Source.Id, target.Id),
            options ?? target.Client.DefaultRequestOptions,
            token
        );
    }
    

    public static System.Threading.Tasks.Task AddAsync(
        this Discord.ICurrentUserActor.BackLink<Discord.IReactionActor> target,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return target.Client.RestApiClient.ExecuteAsync(
            Routes.CreateReaction(
                target.Source.Message.Channel.Id,
                target.Source.Message.Id,
                target.Source.Id
            ),
            options ?? target.Client.DefaultRequestOptions,
            token
        );
    }
    
}
