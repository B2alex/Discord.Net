using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIncomingWebhookActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelWebhookActor.Paged<TParams>,
        Discord.IWebhookActor.Paged<TParams>,
        Discord.IIncomingWebhookActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IIncomingWebhook> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IIncomingWebhook> Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.IGuildChannelWebhookActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookActor.Paged<TParams>,
            IIncomingWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookActor.Paged<TParams>,
            IIncomingWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable,
            Discord.IWebhookActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookActor.Paged<TParams>.Indexable,
                IIncomingWebhookActor.Paged<TParams>.BackLink<TSource>,
                IIncomingWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>,
        Discord.IWebhookActor.Paged<TPaged, TParams>,
        Discord.IIncomingWebhookActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookActor.Paged<TPaged, TParams>,
            IIncomingWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookActor.Paged<TPaged, TParams>,
            IIncomingWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
            Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookActor.Paged<TPaged, TParams>.Indexable,
                IIncomingWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IIncomingWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelWebhookActor.Defined,
        Discord.IWebhookActor.Defined,
        Discord.IIncomingWebhookActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelWebhookActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookActor.Defined,
            IIncomingWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Defined.BackLink<TSource>,
            Discord.IWebhookActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookActor.Defined,
            IIncomingWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Defined.Indexable,
            Discord.IWebhookActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookActor.Defined.Indexable,
                IIncomingWebhookActor.Defined.BackLink<TSource>,
                IIncomingWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IIncomingWebhookActor.Defined,
            IIncomingWebhookActor.Enumerable,
            Discord.IGuildChannelWebhookActor.Defined.Enumerable,
            Discord.IWebhookActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookActor.Defined.Enumerable,
                IIncomingWebhookActor.Defined.BackLink<TSource>,
                IIncomingWebhookActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IIncomingWebhookActor.Defined.Enumerable,
                IIncomingWebhookActor.Defined.Indexable,
                IIncomingWebhookActor.Enumerable.Indexable,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                Discord.IWebhookActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                    IIncomingWebhookActor.Defined.Enumerable.Indexable,
                    IIncomingWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IIncomingWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IIncomingWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelWebhookActor.Enumerable,
        Discord.IWebhookActor.Enumerable,
        Discord.IIncomingWebhookActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IIncomingWebhook>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IIncomingWebhook>> Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.IGuildChannelWebhookActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookActor.Enumerable,
            IIncomingWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
            Discord.IWebhookActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookActor.Enumerable,
            IIncomingWebhookActor.Indexable,
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable,
            Discord.IWebhookActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookActor.Enumerable.Indexable,
                IIncomingWebhookActor.Enumerable.BackLink<TSource>,
                IIncomingWebhookActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelWebhookActor.Indexable,
        Discord.IWebhookActor.Indexable,
        Discord.IIncomingWebhookActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Indexable
    {
        internal new Discord.IIncomingWebhookActor this[Discord.IIdentifiable<ulong, Discord.IIncomingWebhook, Discord.IIncomingWebhookActor, Discord.Models.IIncomingWebhookModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IIncomingWebhookActor this[ulong id] => (this as Discord.IActorProvider<Discord.IIncomingWebhookActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.this[ulong id] => this[id];
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IIncomingWebhookActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IIncomingWebhookActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookActor.Indexable,
            IIncomingWebhookActor.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
            Discord.IWebhookActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
        Discord.IGuildChannelWebhookActor.BackLink<TSource>,
        Discord.IWebhookActor.BackLink<TSource>,
        Discord.IIncomingWebhookActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.IWebhookActor.Link
    {
        Discord.IIncomingWebhookActor Discord.IActorProvider<Discord.IIncomingWebhookActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IIncomingWebhook Discord.IEntityProvider<Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.CreateEntity(Discord.Models.IIncomingWebhookModel model) => CreateEntity(model);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IGuildChannelWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    
        Discord.IWebhookActor Discord.IWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
