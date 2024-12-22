using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetWebhookMessage>,
    Modifiable<Routes.UpdateWebhookMessage, ModifyWebhookMessageProperties>,
    Deletable<Routes.DeleteWebhookMessage>
]
public partial interface IWebhookMessageActor :
    IMessageActor,
    IWebhookActor.CanonicalRelationship,
    IActor<ulong, IWebhookMessage>,
    ITokenPathProvider
{
    [SourceOfTruth]
    new ulong Id { get; }
}
