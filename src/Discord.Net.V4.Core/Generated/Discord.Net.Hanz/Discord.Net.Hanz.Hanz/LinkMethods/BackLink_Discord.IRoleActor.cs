using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class RoleBackLinkExtensions
{
    public static async System.Threading.Tasks.Task AddAsync(
        this Discord.IBackLink<Discord.IMemberActor, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IRoleActor> role,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        await __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.AddGuildMemberRole(__link__.Source.Guild.Id, __link__.Source.Id, role.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    

    public static async System.Threading.Tasks.Task RemoveAsync(
        this Discord.IBackLink<Discord.IMemberActor, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IRoleActor> role,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        await __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.RemoveGuildMemberRole(__link__.Source.Guild.Id, __link__.Source.Id, role.Id),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
