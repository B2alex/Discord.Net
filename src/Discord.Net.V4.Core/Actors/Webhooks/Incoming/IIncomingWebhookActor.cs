using Discord.Rest;
using System.Diagnostics.CodeAnalysis;
using Discord.Models;

namespace Discord;

[
    Loadable(nameof(Routes.GetWebhook), typeof(IIncomingWebhookModel)),
    Modifiable<ModifyWebhookProperties>(nameof(Routes.ModifyWebhook))
]
public partial interface IIncomingWebhookActor :
    IGuildChannelWebhookActor,
    IActor<ulong, IIncomingWebhook>
{
    IIncomingWebhookWithTokenActor this[string token] { get; }
}