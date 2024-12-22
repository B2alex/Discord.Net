using Discord.Rest;

namespace Discord;

[
    Modifiable<Routes.UpdateOriginalWebhookMessage, ModifyWebhookMessageProperties>,
    Deletable<Routes.DeleteOriginalWebhookMessage>,
]
public partial interface IInteractionCallbackResponseActor :
    IActor<ulong, IInteractionCallbackResponse>,
    ITokenPathProvider
{
    
}