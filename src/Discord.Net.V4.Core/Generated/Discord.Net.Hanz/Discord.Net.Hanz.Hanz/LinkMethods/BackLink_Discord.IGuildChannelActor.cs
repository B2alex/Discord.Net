using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class GuildChannelBackLinkExtensions
{
    public static System.Threading.Tasks.Task ModifyPositionsAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel> __link__,
        System.Collections.Generic.IEnumerable<Discord.ModifyGuildChannelPositionProperties> positions,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return __link__.Source.Client.RestApiClient.ExecuteAsync(
            Routes.ModifyGuildChannelPositions(
                __link__.Source.Id,
                positions.Select(x => x.ToApiModel()).ToArray()
            ),
            options ?? __link__.Source.Client.DefaultRequestOptions,
            token
        );
    }
    
}
