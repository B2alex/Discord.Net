using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IDMChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IChannelActor.Paged<TParams>,
        Discord.IDMChannelActor.Link,
        Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IDMChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IDMChannel> Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
            IDMChannelActor.Paged<TParams>,
            IDMChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IDMChannelActor.Paged<TParams>,
            IDMChannelActor.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                IDMChannelActor.Paged<TParams>.Indexable,
                IDMChannelActor.Paged<TParams>.BackLink<TSource>,
                IDMChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IDMChannelActor.Link,
        Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
            IDMChannelActor.Paged<TPaged, TParams>,
            IDMChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IDMChannelActor.Paged<TPaged, TParams>,
            IDMChannelActor.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                IDMChannelActor.Paged<TPaged, TParams>.Indexable,
                IDMChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IDMChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IChannelActor.Defined,
        Discord.IDMChannelActor.Link,
        Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
            IDMChannelActor.Defined,
            IDMChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IDMChannelActor.Defined,
            IDMChannelActor.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                IDMChannelActor.Defined.Indexable,
                IDMChannelActor.Defined.BackLink<TSource>,
                IDMChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IDMChannelActor.Defined,
            IDMChannelActor.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                IDMChannelActor.Defined.Enumerable,
                IDMChannelActor.Defined.BackLink<TSource>,
                IDMChannelActor.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IDMChannelActor.Defined.Enumerable,
                IDMChannelActor.Defined.Indexable,
                IDMChannelActor.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                    IDMChannelActor.Defined.Enumerable.Indexable,
                    IDMChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IDMChannelActor.Defined.Indexable.BackLink<TSource>,
                    IDMChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IChannelActor.Enumerable,
        Discord.IDMChannelActor.Link,
        Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IDMChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IDMChannel>> Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
            IDMChannelActor.Enumerable,
            IDMChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IDMChannelActor.Enumerable,
            IDMChannelActor.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
                IDMChannelActor.Enumerable.Indexable,
                IDMChannelActor.Enumerable.BackLink<TSource>,
                IDMChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IChannelActor.Indexable,
        Discord.IDMChannelActor.Link,
        Discord.ILinkType<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>.Indexable
    {
        internal new Discord.IDMChannelActor this[Discord.IIdentifiable<ulong, Discord.IDMChannel, Discord.IDMChannelActor, Discord.Models.IDMChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IDMChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IDMChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IDMChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IDMChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
            IDMChannelActor.Indexable,
            IDMChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IDMChannelActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel>,
        Discord.IChannelActor.Link
    {
        Discord.IDMChannelActor Discord.IActorProvider<Discord.IDMChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IDMChannel Discord.IEntityProvider<Discord.IDMChannel, Discord.Models.IDMChannelModel>.CreateEntity(Discord.Models.IDMChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
