using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public static class ChannelFollowerWebhookBackLinkExtensions
{
    public static async System.Threading.Tasks.Task<Discord.FollowedChannel> FollowAsync(
        this Discord.IBackLink<Discord.IAnnouncementChannelActor, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel> __link__,
        Discord.IdOrEntity<ulong, Discord.IChannelActor> channel,
        Discord.RequestOptions? options = default(Discord.RequestOptions?),
        System.Threading.CancellationToken token = default(System.Threading.CancellationToken)
    )
    {
        
        return FollowedChannel
            .Construct(
                __link__.Source.Client,
                await __link__.Source.Client.RestApiClient.ExecuteRequiredAsync(
                    Routes.FollowAnnouncementChannel(
                        __link__.Source.Id,
                        new FollowAnnouncementChannelParams()
                        {
                            WebhookChannelId = channel.Id
                        }
                    ),
                    options ?? __link__.Source.Client.DefaultRequestOptions,
                    token
                )
            );
    }
    
}
