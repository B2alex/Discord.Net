using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class UserBackLinkExtensions
{
    public static async System.Threading.Tasks.Task AddAsync(
        this Discord.IBackLink<Discord.IGroupChannelActor, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IUserActor> user,
        string accessToken,
        string nickname,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        await __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.GroupDmAddRecipient(__link__.Source.Id, user.Id, new GroupDmAddRecipientParams()
            {
                Nick = nickname,
                AccessToken = accessToken
            }),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    

    public static async System.Threading.Tasks.Task RemoveAsync(
        this Discord.IBackLink<Discord.IGroupChannelActor, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IUserActor> user,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        await __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.GroupDmRemoveRecipient(__link__.Source.Id, user.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
