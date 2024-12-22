using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetWebhookMessage>,
    Modifiable<Routes.UpdateWebhookMessage, ModifyWebhookMessageProperties>,
    Deletable<Routes.DeleteWebhookMessage>
]
public partial interface IInteractionMessageActor :
    IActor<ulong, IMessage>,
    IApplicationActor.CanonicalRelationship,
    ITokenPathProvider
{

    [LinkExtension]
    private interface WithOriginalExtension
    {
        IInteractionCallbackResponseActor Original { get; }
    }
}