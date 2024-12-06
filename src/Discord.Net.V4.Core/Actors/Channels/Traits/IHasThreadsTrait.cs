using Discord.Models;

namespace Discord;

[Trait]
public partial interface IHasThreadsTrait<out TThreadLink> :
    IHasThreadsTrait
    where TThreadLink : class, 
    ThreadChannelLinkType.Indexable
{
    [SourceOfTruth]
    new TThreadLink Threads { get; }
}

[Trait]
public partial interface IHasThreadsTrait
{
    ThreadChannelLinkType.Indexable Threads { get; }
}
