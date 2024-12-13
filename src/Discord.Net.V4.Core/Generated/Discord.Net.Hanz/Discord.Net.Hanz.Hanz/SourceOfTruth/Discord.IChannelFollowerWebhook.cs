using Discord.Rest;
using Discord.Models;

namespace Discord;

public partial interface IChannelFollowerWebhook
{
    Discord.Models.IWebhookModel IEntityOf<IWebhookModel>.GetModel() => GetModel();

    Discord.Models.IChannelFollowerWebhookModel IEntityOf<IChannelFollowerWebhookModel>.GetModel() => GetModel();
}
