using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class MemberBackLinkExtensions
{
    public static async System.Threading.Tasks.Task<Discord.IMember> AddAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel> __link__,
        MemberLink link,
        Discord.IdOrEntity<ulong, Discord.IUser> user,
        string accessToken,
        string? nickname = default(string?),
        System.Collections.Generic.IEnumerable<Discord.IdOrEntity<ulong, Discord.IRole>>? roles = default(System.Collections.Generic.IEnumerable<Discord.IdOrEntity<ulong, Discord.IRole>>?),
        bool? mute = default(bool?),
        bool? deaf = default(bool?),
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return await link.CreateEntityAsync(
            await link.Client.RestApiClient.ExecuteRequiredAsync(
                Routes.AddGuildMember(
                    __link__.Source.Id,
                    user.Id,
                    new AddGuildMemberParams
                    {
                        AccessToken = accessToken,
                        Nickname = Optional.FromNullable(nickname),
                        IsDeaf = Optional.FromNullable(deaf),
                        IsMute = Optional.FromNullable(mute),
                        RoleIds = Optional.FromNullable(roles)
                            .Map(v => v
                                .Select(v => v.Id)
                                .ToArray()
                            )
                    }
                ),
                options,
                token
            ),
            token
        );
    }
    

    public static async System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyCollection<Discord.IMember>> SearchAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel> __link__,
        MemberLink link,
        string query,
        int limit = (int)(1000),
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        var result = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Routes.SearchGuildMembers(
                __link__.Source.Id,
                query,
                limit
            ),
            options,
            token
        );
        
        return await result.MapAsync(link.CreateEntityAsync, token);
    }
    
}
