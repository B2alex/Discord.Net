using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IAnnouncementChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IAnnouncementChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IAnnouncementChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IAnnouncementChannel> Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
            IAnnouncementChannelActor.Paged<TParams>,
            IAnnouncementChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementChannelActor.Paged<TParams>,
            IAnnouncementChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                IAnnouncementChannelActor.Paged<TParams>.Indexable,
                IAnnouncementChannelActor.Paged<TParams>.BackLink<TSource>,
                IAnnouncementChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IAnnouncementChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
            IAnnouncementChannelActor.Paged<TPaged, TParams>,
            IAnnouncementChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementChannelActor.Paged<TPaged, TParams>,
            IAnnouncementChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                IAnnouncementChannelActor.Paged<TPaged, TParams>.Indexable,
                IAnnouncementChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IAnnouncementChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IAnnouncementChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
            IAnnouncementChannelActor.Defined,
            IAnnouncementChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementChannelActor.Defined,
            IAnnouncementChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                IAnnouncementChannelActor.Defined.Indexable,
                IAnnouncementChannelActor.Defined.BackLink<TSource>,
                IAnnouncementChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IAnnouncementChannelActor.Defined,
            IAnnouncementChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                IAnnouncementChannelActor.Defined.Enumerable,
                IAnnouncementChannelActor.Defined.BackLink<TSource>,
                IAnnouncementChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IAnnouncementChannelActor.Defined.Enumerable,
                IAnnouncementChannelActor.Defined.Indexable,
                IAnnouncementChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                    IAnnouncementChannelActor.Defined.Enumerable.Indexable,
                    IAnnouncementChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IAnnouncementChannelActor.Defined.Indexable.BackLink<TSource>,
                    IAnnouncementChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IAnnouncementChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IAnnouncementChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IAnnouncementChannel>> Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
            IAnnouncementChannelActor.Enumerable,
            IAnnouncementChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementChannelActor.Enumerable,
            IAnnouncementChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
                IAnnouncementChannelActor.Enumerable.Indexable,
                IAnnouncementChannelActor.Enumerable.BackLink<TSource>,
                IAnnouncementChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IAnnouncementChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.Indexable
    {
        internal new Discord.IAnnouncementChannelActor this[Discord.IIdentifiable<ulong, Discord.IAnnouncementChannel, Discord.IAnnouncementChannelActor, Discord.Models.IGuildNewsChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IAnnouncementChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IAnnouncementChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IAnnouncementChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IAnnouncementChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
            IAnnouncementChannelActor.Indexable,
            IAnnouncementChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IAnnouncementChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IAnnouncementChannelActor Discord.IActorProvider<Discord.IAnnouncementChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IAnnouncementChannel Discord.IEntityProvider<Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel>.CreateEntity(Discord.Models.IGuildNewsChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
