using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IWebhookMessageActor
{
    public new interface Paged<in TParams> : 
        Discord.IMessageActor.Paged<TParams>,
        Discord.IWebhookMessageActor.Link,
        Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IWebhookMessage> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IWebhookMessage> Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IMessage> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
            IWebhookMessageActor.Paged<TParams>,
            IWebhookMessageActor.BackLink<TSource>,
            Discord.IMessageActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookMessageActor.Paged<TParams>,
            IWebhookMessageActor.Indexable,
            Discord.IMessageActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                IWebhookMessageActor.Paged<TParams>.Indexable,
                IWebhookMessageActor.Paged<TParams>.BackLink<TSource>,
                IWebhookMessageActor.Indexable.BackLink<TSource>,
                Discord.IMessageActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IMessageActor.Paged<TPaged, TParams>,
        Discord.IWebhookMessageActor.Link,
        Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
            IWebhookMessageActor.Paged<TPaged, TParams>,
            IWebhookMessageActor.BackLink<TSource>,
            Discord.IMessageActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookMessageActor.Paged<TPaged, TParams>,
            IWebhookMessageActor.Indexable,
            Discord.IMessageActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                IWebhookMessageActor.Paged<TPaged, TParams>.Indexable,
                IWebhookMessageActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IWebhookMessageActor.Indexable.BackLink<TSource>,
                Discord.IMessageActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IMessageActor.Defined,
        Discord.IWebhookMessageActor.Link,
        Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
            IWebhookMessageActor.Defined,
            IWebhookMessageActor.BackLink<TSource>,
            Discord.IMessageActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookMessageActor.Defined,
            IWebhookMessageActor.Indexable,
            Discord.IMessageActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                IWebhookMessageActor.Defined.Indexable,
                IWebhookMessageActor.Defined.BackLink<TSource>,
                IWebhookMessageActor.Indexable.BackLink<TSource>,
                Discord.IMessageActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IWebhookMessageActor.Defined,
            IWebhookMessageActor.Enumerable,
            Discord.IMessageActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                IWebhookMessageActor.Defined.Enumerable,
                IWebhookMessageActor.Defined.BackLink<TSource>,
                IWebhookMessageActor.Enumerable.BackLink<TSource>,
                Discord.IMessageActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IWebhookMessageActor.Defined.Enumerable,
                IWebhookMessageActor.Defined.Indexable,
                IWebhookMessageActor.Enumerable.Indexable,
                Discord.IMessageActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                    IWebhookMessageActor.Defined.Enumerable.Indexable,
                    IWebhookMessageActor.Defined.Enumerable.BackLink<TSource>,
                    IWebhookMessageActor.Defined.Indexable.BackLink<TSource>,
                    IWebhookMessageActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IMessageActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IMessageActor.Enumerable,
        Discord.IWebhookMessageActor.Link,
        Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IWebhookMessage>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IWebhookMessage>> Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IMessage>> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
            IWebhookMessageActor.Enumerable,
            IWebhookMessageActor.BackLink<TSource>,
            Discord.IMessageActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookMessageActor.Enumerable,
            IWebhookMessageActor.Indexable,
            Discord.IMessageActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
                IWebhookMessageActor.Enumerable.Indexable,
                IWebhookMessageActor.Enumerable.BackLink<TSource>,
                IWebhookMessageActor.Indexable.BackLink<TSource>,
                Discord.IMessageActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IMessageActor.Indexable,
        Discord.IWebhookMessageActor.Link,
        Discord.ILinkType<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>.Indexable
    {
        internal new Discord.IWebhookMessageActor this[Discord.IIdentifiable<ulong, Discord.IWebhookMessage, Discord.IWebhookMessageActor, Discord.Models.IMessageModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IWebhookMessageActor this[ulong id] => (this as Discord.IActorProvider<Discord.IWebhookMessageActor, ulong>).GetActor(id);
    
        Discord.IMessageActor Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IWebhookMessageActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IWebhookMessageActor, ulong>).GetActor(id);
    
        Discord.IMessageActor Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
            IWebhookMessageActor.Indexable,
            IWebhookMessageActor.BackLink<TSource>,
            Discord.IMessageActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
        Discord.IMessageActor.BackLink<TSource>,
        Discord.IWebhookMessageActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage, Discord.Models.IMessageModel>,
        Discord.IMessageActor.Link
    {
        Discord.IWebhookMessageActor Discord.IActorProvider<Discord.IWebhookMessageActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhookMessage Discord.IEntityProvider<Discord.IWebhookMessage, Discord.Models.IMessageModel>.CreateEntity(Discord.Models.IMessageModel model) => CreateEntity(model);
    
        Discord.IMessageActor Discord.IMessageActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IMessage Discord.IMessageActor.Link.CreateEntity(Discord.Models.IMessageModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
