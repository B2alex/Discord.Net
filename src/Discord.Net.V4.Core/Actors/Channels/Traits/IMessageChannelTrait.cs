using Discord.Models;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[Trait]
public partial interface IMessageChannelTrait :
    IChannelActor,
    IActorTrait<ulong, IMessageChannel>
{
    IMessageActor.Paged<PageChannelMessagesParams>.Indexable Messages { get; }
}
