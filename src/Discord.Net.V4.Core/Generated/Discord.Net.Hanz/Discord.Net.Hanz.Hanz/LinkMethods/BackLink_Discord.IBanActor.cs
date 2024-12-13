using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class BanBackLinkExtensions
{
    public static System.Threading.Tasks.Task CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IUserActor> user,
        int? purgeMessageSeconds = default(int?),
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.CreateGuildBan(
                __link__.Source.Id,
                user.Id,
                new CreateGuildBanParams
                {
                    DeleteMessageSeconds = Optional.FromNullable(purgeMessageSeconds)
                }
            ),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    

    public static async System.Threading.Tasks.Task<Discord.BulkBanResult> BulkCreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel> __link__,
        System.Collections.Generic.IEnumerable<Discord.IdOrEntity<ulong, Discord.IUser>> users,
        int? purgeMessageSeconds = default(int?),
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        var userIds = users.Select(x => x.Id).ToArray();
        
        if (userIds.Length > DiscordConfig.MaxBulkBansPerBatch)
            throw new ArgumentOutOfRangeException(
                nameof(users),
                userIds.Length,
                $"A max of {DiscordConfig.MaxBulkBansPerBatch} bans can be created at a time"
            );
        
        return BulkBanResult.Construct(
            __link__.Source.Client,
            await __link__.Source.Client.RestApiClient.ExecuteRequiredAsync(
                Routes.BulkGuildBan(
                    __link__.Source.Id,
                    new BulkBanUsersParams()
                    {
                        UserIds = userIds,
                        DeleteMessageSeconds = Optional.FromNullable(purgeMessageSeconds)
                    }
                ),
                options ?? __link__.Source.Client.DefaultRequestOptions,
                token
            )
        );
    }
    
}
