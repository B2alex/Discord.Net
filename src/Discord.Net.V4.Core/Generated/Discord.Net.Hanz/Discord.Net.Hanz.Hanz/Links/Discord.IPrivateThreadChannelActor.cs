using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPrivateThreadChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IThreadChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IPrivateThreadChannelActor.Link,
        Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IPrivateThreadChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IPrivateThreadChannel> Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IThreadChannel> Discord.IThreadChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
            IPrivateThreadChannelActor.Paged<TParams>,
            IPrivateThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPrivateThreadChannelActor.Paged<TParams>,
            IPrivateThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                IPrivateThreadChannelActor.Paged<TParams>.Indexable,
                IPrivateThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IPrivateThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IThreadChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IPrivateThreadChannelActor.Link,
        Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IThreadChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
            IPrivateThreadChannelActor.Paged<TPaged, TParams>,
            IPrivateThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPrivateThreadChannelActor.Paged<TPaged, TParams>,
            IPrivateThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                IPrivateThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IPrivateThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IPrivateThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IThreadChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IPrivateThreadChannelActor.Link,
        Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IThreadChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
            IPrivateThreadChannelActor.Defined,
            IPrivateThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPrivateThreadChannelActor.Defined,
            IPrivateThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                IPrivateThreadChannelActor.Defined.Indexable,
                IPrivateThreadChannelActor.Defined.BackLink<TSource>,
                IPrivateThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IPrivateThreadChannelActor.Defined,
            IPrivateThreadChannelActor.Enumerable,
            Discord.IThreadChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                IPrivateThreadChannelActor.Defined.Enumerable,
                IPrivateThreadChannelActor.Defined.BackLink<TSource>,
                IPrivateThreadChannelActor.Enumerable.BackLink<TSource>,
                Discord.IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IPrivateThreadChannelActor.Defined.Enumerable,
                IPrivateThreadChannelActor.Defined.Indexable,
                IPrivateThreadChannelActor.Enumerable.Indexable,
                Discord.IThreadChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                    IPrivateThreadChannelActor.Defined.Enumerable.Indexable,
                    IPrivateThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IPrivateThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IPrivateThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IThreadChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IPrivateThreadChannelActor.Link,
        Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IPrivateThreadChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IPrivateThreadChannel>> Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IThreadChannel>> Discord.IThreadChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
            IPrivateThreadChannelActor.Enumerable,
            IPrivateThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPrivateThreadChannelActor.Enumerable,
            IPrivateThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
                IPrivateThreadChannelActor.Enumerable.Indexable,
                IPrivateThreadChannelActor.Enumerable.BackLink<TSource>,
                IPrivateThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IThreadChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IPrivateThreadChannelActor.Link,
        Discord.ILinkType<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.Indexable
    {
        internal new Discord.IPrivateThreadChannelActor this[Discord.IIdentifiable<ulong, Discord.IPrivateThreadChannel, Discord.IPrivateThreadChannelActor, Discord.Models.IThreadChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IPrivateThreadChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IPrivateThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IPrivateThreadChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IPrivateThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
            IPrivateThreadChannelActor.Indexable,
            IPrivateThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IThreadChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IPrivateThreadChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IThreadChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IPrivateThreadChannelActor Discord.IActorProvider<Discord.IPrivateThreadChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IPrivateThreadChannel Discord.IEntityProvider<Discord.IPrivateThreadChannel, Discord.Models.IThreadChannelModel>.CreateEntity(Discord.Models.IThreadChannelModel model) => CreateEntity(model);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadChannel Discord.IThreadChannelActor.Link.CreateEntity(Discord.Models.IThreadChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
