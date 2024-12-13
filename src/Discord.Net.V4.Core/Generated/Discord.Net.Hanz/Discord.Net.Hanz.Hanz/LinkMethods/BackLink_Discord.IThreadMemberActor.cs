using Discord.Rest;
using Discord.Models;
using Discord;

namespace Discord;

public static class ThreadMemberBackLinkExtensions
{
    public static System.Threading.Tasks.Task AddAsync(
        this Discord.IBackLink<Discord.IThreadChannelActor, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IUserActor> user,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.AddThreadMember(__link__.Source.Id, user.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    

    public static System.Threading.Tasks.Task RemoveAsync(
        this Discord.IBackLink<Discord.IThreadChannelActor, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IUserActor> user,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.RemoveThreadMember(__link__.Source.Id, user.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
