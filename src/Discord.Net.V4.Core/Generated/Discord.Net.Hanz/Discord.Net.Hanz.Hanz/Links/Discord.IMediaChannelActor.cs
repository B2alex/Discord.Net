using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMediaChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IMediaChannelActor.Link,
        Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IMediaChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IMediaChannel> Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
            IMediaChannelActor.Paged<TParams>,
            IMediaChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMediaChannelActor.Paged<TParams>,
            IMediaChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                IMediaChannelActor.Paged<TParams>.Indexable,
                IMediaChannelActor.Paged<TParams>.BackLink<TSource>,
                IMediaChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IMediaChannelActor.Link,
        Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
            IMediaChannelActor.Paged<TPaged, TParams>,
            IMediaChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMediaChannelActor.Paged<TPaged, TParams>,
            IMediaChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                IMediaChannelActor.Paged<TPaged, TParams>.Indexable,
                IMediaChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IMediaChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IMediaChannelActor.Link,
        Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
            IMediaChannelActor.Defined,
            IMediaChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMediaChannelActor.Defined,
            IMediaChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                IMediaChannelActor.Defined.Indexable,
                IMediaChannelActor.Defined.BackLink<TSource>,
                IMediaChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IMediaChannelActor.Defined,
            IMediaChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                IMediaChannelActor.Defined.Enumerable,
                IMediaChannelActor.Defined.BackLink<TSource>,
                IMediaChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IMediaChannelActor.Defined.Enumerable,
                IMediaChannelActor.Defined.Indexable,
                IMediaChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                    IMediaChannelActor.Defined.Enumerable.Indexable,
                    IMediaChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IMediaChannelActor.Defined.Indexable.BackLink<TSource>,
                    IMediaChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IMediaChannelActor.Link,
        Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IMediaChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IMediaChannel>> Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
            IMediaChannelActor.Enumerable,
            IMediaChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMediaChannelActor.Enumerable,
            IMediaChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
                IMediaChannelActor.Enumerable.Indexable,
                IMediaChannelActor.Enumerable.BackLink<TSource>,
                IMediaChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IMediaChannelActor.Link,
        Discord.ILinkType<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.Indexable
    {
        internal new Discord.IMediaChannelActor this[Discord.IIdentifiable<ulong, Discord.IMediaChannel, Discord.IMediaChannelActor, Discord.Models.IGuildMediaChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IMediaChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IMediaChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IMediaChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IMediaChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
            IMediaChannelActor.Indexable,
            IMediaChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IMediaChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IMediaChannelActor Discord.IActorProvider<Discord.IMediaChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IMediaChannel Discord.IEntityProvider<Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel>.CreateEntity(Discord.Models.IGuildMediaChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
