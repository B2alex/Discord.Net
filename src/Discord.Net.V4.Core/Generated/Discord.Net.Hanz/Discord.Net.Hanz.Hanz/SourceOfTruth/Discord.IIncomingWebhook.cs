using Discord.Rest;
using Discord.Models;

namespace Discord;

public partial interface IIncomingWebhook
{
    Discord.Models.IWebhookModel IEntityOf<IWebhookModel>.GetModel() => GetModel();

    Discord.Models.IIncomingWebhookModel IEntityOf<IIncomingWebhookModel>.GetModel() => GetModel();
}
