using Discord.Models;
using Discord;

namespace Discord;

public partial interface IIntegrationChannelTrait
{
    public interface WithIncoming : 
        IIntegrationChannelTrait
    {
        new Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming Webhooks { get; }
    
        Discord.IGuildChannelWebhookActor.Enumerable.Indexable IIntegrationChannelTrait.Webhooks => Webhooks;
    
    
        public interface WithChannelFollower : 
            IIntegrationChannelTrait.WithIncoming,
            IIntegrationChannelTrait.WithChannelFollower
        {
            new Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.WithChannelFollower Webhooks { get; }
        
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming IIntegrationChannelTrait.WithIncoming.Webhooks => Webhooks;
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower IIntegrationChannelTrait.WithChannelFollower.Webhooks => Webhooks;
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable IIntegrationChannelTrait.Webhooks => Webhooks;
        }
    }

    public interface WithChannelFollower : 
        IIntegrationChannelTrait
    {
        new Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower Webhooks { get; }
    
        Discord.IGuildChannelWebhookActor.Enumerable.Indexable IIntegrationChannelTrait.Webhooks => Webhooks;
    
    
        public interface WithIncoming : 
            IIntegrationChannelTrait.WithChannelFollower,
            IIntegrationChannelTrait.WithIncoming
        {
            new Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.WithIncoming Webhooks { get; }
        
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower IIntegrationChannelTrait.WithChannelFollower.Webhooks => Webhooks;
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming IIntegrationChannelTrait.WithIncoming.Webhooks => Webhooks;
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable IIntegrationChannelTrait.Webhooks => Webhooks;
        }
    }
}
