using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IWebhookActor
{
    public new interface Paged<in TParams> : 
        Discord.IWebhookActor.Link,
        Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IWebhook> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IWebhookActor.Paged<TParams>,
            IWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookActor.Paged<TParams>,
            IWebhookActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IWebhookActor.Paged<TParams>.Indexable,
                IWebhookActor.Paged<TParams>.BackLink<TSource>,
                IWebhookActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IWebhookActor.Link,
        Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IWebhookActor.Paged<TPaged, TParams>,
            IWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookActor.Paged<TPaged, TParams>,
            IWebhookActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IWebhookActor.Paged<TPaged, TParams>.Indexable,
                IWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IWebhookActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IWebhookActor.Link,
        Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IWebhookActor.Defined,
            IWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookActor.Defined,
            IWebhookActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IWebhookActor.Defined.Indexable,
                IWebhookActor.Defined.BackLink<TSource>,
                IWebhookActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IWebhookActor.Defined,
            IWebhookActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IWebhookActor.Defined.Enumerable,
                IWebhookActor.Defined.BackLink<TSource>,
                IWebhookActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IWebhookActor.Defined.Enumerable,
                IWebhookActor.Defined.Indexable,
                IWebhookActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IWebhookActor.Defined.Enumerable.Indexable,
                    IWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IWebhookActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IWebhookActor.Link,
        Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IWebhook>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IWebhookActor.Enumerable,
            IWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IWebhookActor.Enumerable,
            IWebhookActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IWebhookActor.Enumerable.Indexable,
                IWebhookActor.Enumerable.BackLink<TSource>,
                IWebhookActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IWebhookActor.Link,
        Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable
    {
        internal Discord.IWebhookActor this[Discord.IIdentifiable<ulong, Discord.IWebhook, Discord.IWebhookActor, Discord.Models.IWebhookModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IWebhookActor.Indexable,
            IWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
        Discord.IWebhookActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>
    {
        Discord.IWebhookActor Discord.IActorProvider<Discord.IWebhookActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IEntityProvider<Discord.IWebhook, Discord.Models.IWebhookModel>.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
