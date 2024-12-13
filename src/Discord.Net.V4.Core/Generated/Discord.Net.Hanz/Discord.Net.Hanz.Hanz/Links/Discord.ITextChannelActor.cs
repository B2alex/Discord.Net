using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ITextChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.ITextChannelActor.Link,
        Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ITextChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ITextChannel> Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
            ITextChannelActor.Paged<TParams>,
            ITextChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ITextChannelActor.Paged<TParams>,
            ITextChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                ITextChannelActor.Paged<TParams>.Indexable,
                ITextChannelActor.Paged<TParams>.BackLink<TSource>,
                ITextChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.ITextChannelActor.Link,
        Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
            ITextChannelActor.Paged<TPaged, TParams>,
            ITextChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ITextChannelActor.Paged<TPaged, TParams>,
            ITextChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                ITextChannelActor.Paged<TPaged, TParams>.Indexable,
                ITextChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ITextChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.ITextChannelActor.Link,
        Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
            ITextChannelActor.Defined,
            ITextChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ITextChannelActor.Defined,
            ITextChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                ITextChannelActor.Defined.Indexable,
                ITextChannelActor.Defined.BackLink<TSource>,
                ITextChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ITextChannelActor.Defined,
            ITextChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                ITextChannelActor.Defined.Enumerable,
                ITextChannelActor.Defined.BackLink<TSource>,
                ITextChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ITextChannelActor.Defined.Enumerable,
                ITextChannelActor.Defined.Indexable,
                ITextChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                    ITextChannelActor.Defined.Enumerable.Indexable,
                    ITextChannelActor.Defined.Enumerable.BackLink<TSource>,
                    ITextChannelActor.Defined.Indexable.BackLink<TSource>,
                    ITextChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.ITextChannelActor.Link,
        Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ITextChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ITextChannel>> Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
            ITextChannelActor.Enumerable,
            ITextChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ITextChannelActor.Enumerable,
            ITextChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
                ITextChannelActor.Enumerable.Indexable,
                ITextChannelActor.Enumerable.BackLink<TSource>,
                ITextChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.ITextChannelActor.Link,
        Discord.ILinkType<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.Indexable
    {
        internal new Discord.ITextChannelActor this[Discord.IIdentifiable<ulong, Discord.ITextChannel, Discord.ITextChannelActor, Discord.Models.IGuildTextChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ITextChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.ITextChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ITextChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ITextChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
            ITextChannelActor.Indexable,
            ITextChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.ITextChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.ITextChannelActor Discord.IActorProvider<Discord.ITextChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ITextChannel Discord.IEntityProvider<Discord.ITextChannel, Discord.Models.IGuildTextChannelModel>.CreateEntity(Discord.Models.IGuildTextChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
