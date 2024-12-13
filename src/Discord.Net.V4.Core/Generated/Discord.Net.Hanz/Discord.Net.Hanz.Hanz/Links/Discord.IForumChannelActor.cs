using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IForumChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IForumChannelActor.Link,
        Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IForumChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IForumChannel> Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
            IForumChannelActor.Paged<TParams>,
            IForumChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IForumChannelActor.Paged<TParams>,
            IForumChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                IForumChannelActor.Paged<TParams>.Indexable,
                IForumChannelActor.Paged<TParams>.BackLink<TSource>,
                IForumChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IForumChannelActor.Link,
        Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
            IForumChannelActor.Paged<TPaged, TParams>,
            IForumChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IForumChannelActor.Paged<TPaged, TParams>,
            IForumChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                IForumChannelActor.Paged<TPaged, TParams>.Indexable,
                IForumChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IForumChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IForumChannelActor.Link,
        Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
            IForumChannelActor.Defined,
            IForumChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IForumChannelActor.Defined,
            IForumChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                IForumChannelActor.Defined.Indexable,
                IForumChannelActor.Defined.BackLink<TSource>,
                IForumChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IForumChannelActor.Defined,
            IForumChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                IForumChannelActor.Defined.Enumerable,
                IForumChannelActor.Defined.BackLink<TSource>,
                IForumChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IForumChannelActor.Defined.Enumerable,
                IForumChannelActor.Defined.Indexable,
                IForumChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                    IForumChannelActor.Defined.Enumerable.Indexable,
                    IForumChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IForumChannelActor.Defined.Indexable.BackLink<TSource>,
                    IForumChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IForumChannelActor.Link,
        Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IForumChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IForumChannel>> Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
            IForumChannelActor.Enumerable,
            IForumChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IForumChannelActor.Enumerable,
            IForumChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
                IForumChannelActor.Enumerable.Indexable,
                IForumChannelActor.Enumerable.BackLink<TSource>,
                IForumChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IForumChannelActor.Link,
        Discord.ILinkType<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.Indexable
    {
        internal new Discord.IForumChannelActor this[Discord.IIdentifiable<ulong, Discord.IForumChannel, Discord.IForumChannelActor, Discord.Models.IGuildForumChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IForumChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IForumChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IForumChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IForumChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
            IForumChannelActor.Indexable,
            IForumChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IForumChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IForumChannelActor Discord.IActorProvider<Discord.IForumChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IForumChannel Discord.IEntityProvider<Discord.IForumChannel, Discord.Models.IGuildForumChannelModel>.CreateEntity(Discord.Models.IGuildForumChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
