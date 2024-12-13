using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IChannelFollowerWebhookActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelWebhookActor.Paged<TParams>,
        Discord.IWebhookActor.Paged<TParams>,
        Discord.IChannelFollowerWebhookActor.Link,
        Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IChannelFollowerWebhook> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IChannelFollowerWebhook> Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.IGuildChannelWebhookActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
            IChannelFollowerWebhookActor.Paged<TParams>,
            IChannelFollowerWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelFollowerWebhookActor.Paged<TParams>,
            IChannelFollowerWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable,
            Discord.IWebhookActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                IChannelFollowerWebhookActor.Paged<TParams>.Indexable,
                IChannelFollowerWebhookActor.Paged<TParams>.BackLink<TSource>,
                IChannelFollowerWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>,
        Discord.IWebhookActor.Paged<TPaged, TParams>,
        Discord.IChannelFollowerWebhookActor.Link,
        Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
            IChannelFollowerWebhookActor.Paged<TPaged, TParams>,
            IChannelFollowerWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelFollowerWebhookActor.Paged<TPaged, TParams>,
            IChannelFollowerWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
            Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                IChannelFollowerWebhookActor.Paged<TPaged, TParams>.Indexable,
                IChannelFollowerWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IChannelFollowerWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelWebhookActor.Defined,
        Discord.IWebhookActor.Defined,
        Discord.IChannelFollowerWebhookActor.Link,
        Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelWebhookActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
            IChannelFollowerWebhookActor.Defined,
            IChannelFollowerWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Defined.BackLink<TSource>,
            Discord.IWebhookActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelFollowerWebhookActor.Defined,
            IChannelFollowerWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Defined.Indexable,
            Discord.IWebhookActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                IChannelFollowerWebhookActor.Defined.Indexable,
                IChannelFollowerWebhookActor.Defined.BackLink<TSource>,
                IChannelFollowerWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IChannelFollowerWebhookActor.Defined,
            IChannelFollowerWebhookActor.Enumerable,
            Discord.IGuildChannelWebhookActor.Defined.Enumerable,
            Discord.IWebhookActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                IChannelFollowerWebhookActor.Defined.Enumerable,
                IChannelFollowerWebhookActor.Defined.BackLink<TSource>,
                IChannelFollowerWebhookActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IChannelFollowerWebhookActor.Defined.Enumerable,
                IChannelFollowerWebhookActor.Defined.Indexable,
                IChannelFollowerWebhookActor.Enumerable.Indexable,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                Discord.IWebhookActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                    IChannelFollowerWebhookActor.Defined.Enumerable.Indexable,
                    IChannelFollowerWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IChannelFollowerWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IChannelFollowerWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelWebhookActor.Enumerable,
        Discord.IWebhookActor.Enumerable,
        Discord.IChannelFollowerWebhookActor.Link,
        Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IChannelFollowerWebhook>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IChannelFollowerWebhook>> Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.IGuildChannelWebhookActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
            IChannelFollowerWebhookActor.Enumerable,
            IChannelFollowerWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
            Discord.IWebhookActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelFollowerWebhookActor.Enumerable,
            IChannelFollowerWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable,
            Discord.IWebhookActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
                IChannelFollowerWebhookActor.Enumerable.Indexable,
                IChannelFollowerWebhookActor.Enumerable.BackLink<TSource>,
                IChannelFollowerWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelWebhookActor.Indexable,
        Discord.IWebhookActor.Indexable,
        Discord.IChannelFollowerWebhookActor.Link,
        Discord.ILinkType<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.Indexable
    {
        internal new Discord.IChannelFollowerWebhookActor this[Discord.IIdentifiable<ulong, Discord.IChannelFollowerWebhook, Discord.IChannelFollowerWebhookActor, Discord.Models.IChannelFollowerWebhookModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IChannelFollowerWebhookActor this[ulong id] => (this as Discord.IActorProvider<Discord.IChannelFollowerWebhookActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.this[ulong id] => this[id];
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IChannelFollowerWebhookActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IChannelFollowerWebhookActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
            IChannelFollowerWebhookActor.Indexable,
            IChannelFollowerWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
            Discord.IWebhookActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
        Discord.IGuildChannelWebhookActor.BackLink<TSource>,
        Discord.IWebhookActor.BackLink<TSource>,
        Discord.IChannelFollowerWebhookActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.IWebhookActor.Link
    {
        Discord.IChannelFollowerWebhookActor Discord.IActorProvider<Discord.IChannelFollowerWebhookActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannelFollowerWebhook Discord.IEntityProvider<Discord.IChannelFollowerWebhook, Discord.Models.IChannelFollowerWebhookModel>.CreateEntity(Discord.Models.IChannelFollowerWebhookModel model) => CreateEntity(model);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IGuildChannelWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    
        Discord.IWebhookActor Discord.IWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
