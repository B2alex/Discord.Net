using Discord.Rest;
using Discord.Models;

namespace Discord;

public partial interface IWebhookMessageActor
{
    ulong IIdentifiable<ulong>.Id => Id;
}
