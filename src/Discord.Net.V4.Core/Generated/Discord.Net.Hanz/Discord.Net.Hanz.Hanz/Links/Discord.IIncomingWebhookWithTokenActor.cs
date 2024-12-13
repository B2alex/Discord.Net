using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIncomingWebhookWithTokenActor
{
    public new interface Paged<in TParams> : 
        Discord.IIncomingWebhookActor.Paged<TParams>,
        Discord.IGuildChannelWebhookActor.Paged<TParams>,
        Discord.IWebhookActor.Paged<TParams>,
        Discord.IIncomingWebhookWithTokenActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IIncomingWebhook> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IIncomingWebhook> Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IIncomingWebhook> Discord.IIncomingWebhookActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.IGuildChannelWebhookActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookWithTokenActor.Paged<TParams>,
            IIncomingWebhookWithTokenActor.BackLink<TSource>,
            Discord.IIncomingWebhookActor.Paged<TParams>.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookWithTokenActor.Paged<TParams>,
            IIncomingWebhookWithTokenActor.Indexable,
            Discord.IIncomingWebhookActor.Paged<TParams>.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable,
            Discord.IWebhookActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookWithTokenActor.Paged<TParams>.Indexable,
                IIncomingWebhookWithTokenActor.Paged<TParams>.BackLink<TSource>,
                IIncomingWebhookWithTokenActor.Indexable.BackLink<TSource>,
                Discord.IIncomingWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IIncomingWebhookActor.Paged<TPaged, TParams>,
        Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>,
        Discord.IWebhookActor.Paged<TPaged, TParams>,
        Discord.IIncomingWebhookWithTokenActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IIncomingWebhookActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookWithTokenActor.Paged<TPaged, TParams>,
            IIncomingWebhookWithTokenActor.BackLink<TSource>,
            Discord.IIncomingWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookWithTokenActor.Paged<TPaged, TParams>,
            IIncomingWebhookWithTokenActor.Indexable,
            Discord.IIncomingWebhookActor.Paged<TPaged, TParams>.Indexable,
            Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
            Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookWithTokenActor.Paged<TPaged, TParams>.Indexable,
                IIncomingWebhookWithTokenActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IIncomingWebhookWithTokenActor.Indexable.BackLink<TSource>,
                Discord.IIncomingWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IIncomingWebhookActor.Defined,
        Discord.IGuildChannelWebhookActor.Defined,
        Discord.IWebhookActor.Defined,
        Discord.IIncomingWebhookWithTokenActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IIncomingWebhookActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelWebhookActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookWithTokenActor.Defined,
            IIncomingWebhookWithTokenActor.BackLink<TSource>,
            Discord.IIncomingWebhookActor.Defined.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Defined.BackLink<TSource>,
            Discord.IWebhookActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookWithTokenActor.Defined,
            IIncomingWebhookWithTokenActor.Indexable,
            Discord.IIncomingWebhookActor.Defined.Indexable,
            Discord.IGuildChannelWebhookActor.Defined.Indexable,
            Discord.IWebhookActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookWithTokenActor.Defined.Indexable,
                IIncomingWebhookWithTokenActor.Defined.BackLink<TSource>,
                IIncomingWebhookWithTokenActor.Indexable.BackLink<TSource>,
                Discord.IIncomingWebhookActor.Defined.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IIncomingWebhookWithTokenActor.Defined,
            IIncomingWebhookWithTokenActor.Enumerable,
            Discord.IIncomingWebhookActor.Defined.Enumerable,
            Discord.IGuildChannelWebhookActor.Defined.Enumerable,
            Discord.IWebhookActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookWithTokenActor.Defined.Enumerable,
                IIncomingWebhookWithTokenActor.Defined.BackLink<TSource>,
                IIncomingWebhookWithTokenActor.Enumerable.BackLink<TSource>,
                Discord.IIncomingWebhookActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IIncomingWebhookWithTokenActor.Defined.Enumerable,
                IIncomingWebhookWithTokenActor.Defined.Indexable,
                IIncomingWebhookWithTokenActor.Enumerable.Indexable,
                Discord.IIncomingWebhookActor.Defined.Enumerable.Indexable,
                Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                Discord.IWebhookActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                    IIncomingWebhookWithTokenActor.Defined.Enumerable.Indexable,
                    IIncomingWebhookWithTokenActor.Defined.Enumerable.BackLink<TSource>,
                    IIncomingWebhookWithTokenActor.Defined.Indexable.BackLink<TSource>,
                    IIncomingWebhookWithTokenActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IIncomingWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IIncomingWebhookActor.Enumerable,
        Discord.IGuildChannelWebhookActor.Enumerable,
        Discord.IWebhookActor.Enumerable,
        Discord.IIncomingWebhookWithTokenActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IIncomingWebhook>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IIncomingWebhook>> Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IIncomingWebhook>> Discord.IIncomingWebhookActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.IGuildChannelWebhookActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookWithTokenActor.Enumerable,
            IIncomingWebhookWithTokenActor.BackLink<TSource>,
            Discord.IIncomingWebhookActor.Enumerable.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
            Discord.IWebhookActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIncomingWebhookWithTokenActor.Enumerable,
            IIncomingWebhookWithTokenActor.Indexable,
            Discord.IIncomingWebhookActor.Enumerable.Indexable,
            Discord.IGuildChannelWebhookActor.Enumerable.Indexable,
            Discord.IWebhookActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
                IIncomingWebhookWithTokenActor.Enumerable.Indexable,
                IIncomingWebhookWithTokenActor.Enumerable.BackLink<TSource>,
                IIncomingWebhookWithTokenActor.Indexable.BackLink<TSource>,
                Discord.IIncomingWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IIncomingWebhookActor.Indexable,
        Discord.IGuildChannelWebhookActor.Indexable,
        Discord.IWebhookActor.Indexable,
        Discord.IIncomingWebhookWithTokenActor.Link,
        Discord.ILinkType<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.Indexable
    {
        internal new Discord.IIncomingWebhookWithTokenActor this[Discord.IIdentifiable<ulong, Discord.IIncomingWebhook, Discord.IIncomingWebhookWithTokenActor, Discord.Models.IIncomingWebhookModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IIncomingWebhookWithTokenActor this[ulong id] => (this as Discord.IActorProvider<Discord.IIncomingWebhookWithTokenActor, ulong>).GetActor(id);
    
        Discord.IIncomingWebhookActor Discord.IIncomingWebhookActor.Indexable.this[ulong id] => this[id];
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.this[ulong id] => this[id];
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IIncomingWebhookWithTokenActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IIncomingWebhookWithTokenActor, ulong>).GetActor(id);
    
        Discord.IIncomingWebhookActor Discord.IIncomingWebhookActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
            IIncomingWebhookWithTokenActor.Indexable,
            IIncomingWebhookWithTokenActor.BackLink<TSource>,
            Discord.IIncomingWebhookActor.Indexable.BackLink<TSource>,
            Discord.IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
            Discord.IWebhookActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
        Discord.IIncomingWebhookActor.BackLink<TSource>,
        Discord.IGuildChannelWebhookActor.BackLink<TSource>,
        Discord.IWebhookActor.BackLink<TSource>,
        Discord.IIncomingWebhookWithTokenActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>,
        Discord.IIncomingWebhookActor.Link,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.IWebhookActor.Link
    {
        Discord.IIncomingWebhookWithTokenActor Discord.IActorProvider<Discord.IIncomingWebhookWithTokenActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IIncomingWebhook Discord.IEntityProvider<Discord.IIncomingWebhook, Discord.Models.IIncomingWebhookModel>.CreateEntity(Discord.Models.IIncomingWebhookModel model) => CreateEntity(model);
    
        Discord.IIncomingWebhookActor Discord.IIncomingWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IIncomingWebhook Discord.IIncomingWebhookActor.Link.CreateEntity(Discord.Models.IIncomingWebhookModel model) => CreateEntity(model);
    
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IGuildChannelWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    
        Discord.IWebhookActor Discord.IWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
