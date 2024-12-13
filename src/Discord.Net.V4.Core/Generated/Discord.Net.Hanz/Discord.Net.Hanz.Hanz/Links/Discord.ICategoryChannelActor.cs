using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICategoryChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.ICategoryChannelActor.Link,
        Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ICategoryChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ICategoryChannel> Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
            ICategoryChannelActor.Paged<TParams>,
            ICategoryChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICategoryChannelActor.Paged<TParams>,
            ICategoryChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                ICategoryChannelActor.Paged<TParams>.Indexable,
                ICategoryChannelActor.Paged<TParams>.BackLink<TSource>,
                ICategoryChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.ICategoryChannelActor.Link,
        Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
            ICategoryChannelActor.Paged<TPaged, TParams>,
            ICategoryChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICategoryChannelActor.Paged<TPaged, TParams>,
            ICategoryChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                ICategoryChannelActor.Paged<TPaged, TParams>.Indexable,
                ICategoryChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ICategoryChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.ICategoryChannelActor.Link,
        Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
            ICategoryChannelActor.Defined,
            ICategoryChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICategoryChannelActor.Defined,
            ICategoryChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                ICategoryChannelActor.Defined.Indexable,
                ICategoryChannelActor.Defined.BackLink<TSource>,
                ICategoryChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ICategoryChannelActor.Defined,
            ICategoryChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                ICategoryChannelActor.Defined.Enumerable,
                ICategoryChannelActor.Defined.BackLink<TSource>,
                ICategoryChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ICategoryChannelActor.Defined.Enumerable,
                ICategoryChannelActor.Defined.Indexable,
                ICategoryChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                    ICategoryChannelActor.Defined.Enumerable.Indexable,
                    ICategoryChannelActor.Defined.Enumerable.BackLink<TSource>,
                    ICategoryChannelActor.Defined.Indexable.BackLink<TSource>,
                    ICategoryChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.ICategoryChannelActor.Link,
        Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ICategoryChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ICategoryChannel>> Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
            ICategoryChannelActor.Enumerable,
            ICategoryChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICategoryChannelActor.Enumerable,
            ICategoryChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
                ICategoryChannelActor.Enumerable.Indexable,
                ICategoryChannelActor.Enumerable.BackLink<TSource>,
                ICategoryChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.ICategoryChannelActor.Link,
        Discord.ILinkType<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.Indexable
    {
        internal new Discord.ICategoryChannelActor this[Discord.IIdentifiable<ulong, Discord.ICategoryChannel, Discord.ICategoryChannelActor, Discord.Models.IGuildCategoryChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ICategoryChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.ICategoryChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ICategoryChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ICategoryChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
            ICategoryChannelActor.Indexable,
            ICategoryChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.ICategoryChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.ICategoryChannelActor Discord.IActorProvider<Discord.ICategoryChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ICategoryChannel Discord.IEntityProvider<Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel>.CreateEntity(Discord.Models.IGuildCategoryChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
