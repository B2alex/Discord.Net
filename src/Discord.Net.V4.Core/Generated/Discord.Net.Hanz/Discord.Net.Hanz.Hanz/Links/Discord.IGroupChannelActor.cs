using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGroupChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IChannelActor.Paged<TParams>,
        Discord.IGroupChannelActor.Link,
        Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGroupChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGroupChannel> Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
            IGroupChannelActor.Paged<TParams>,
            IGroupChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGroupChannelActor.Paged<TParams>,
            IGroupChannelActor.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                IGroupChannelActor.Paged<TParams>.Indexable,
                IGroupChannelActor.Paged<TParams>.BackLink<TSource>,
                IGroupChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IGroupChannelActor.Link,
        Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
            IGroupChannelActor.Paged<TPaged, TParams>,
            IGroupChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGroupChannelActor.Paged<TPaged, TParams>,
            IGroupChannelActor.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                IGroupChannelActor.Paged<TPaged, TParams>.Indexable,
                IGroupChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGroupChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IChannelActor.Defined,
        Discord.IGroupChannelActor.Link,
        Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
            IGroupChannelActor.Defined,
            IGroupChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGroupChannelActor.Defined,
            IGroupChannelActor.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                IGroupChannelActor.Defined.Indexable,
                IGroupChannelActor.Defined.BackLink<TSource>,
                IGroupChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGroupChannelActor.Defined,
            IGroupChannelActor.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                IGroupChannelActor.Defined.Enumerable,
                IGroupChannelActor.Defined.BackLink<TSource>,
                IGroupChannelActor.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGroupChannelActor.Defined.Enumerable,
                IGroupChannelActor.Defined.Indexable,
                IGroupChannelActor.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                    IGroupChannelActor.Defined.Enumerable.Indexable,
                    IGroupChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IGroupChannelActor.Defined.Indexable.BackLink<TSource>,
                    IGroupChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IChannelActor.Enumerable,
        Discord.IGroupChannelActor.Link,
        Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGroupChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGroupChannel>> Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
            IGroupChannelActor.Enumerable,
            IGroupChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGroupChannelActor.Enumerable,
            IGroupChannelActor.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
                IGroupChannelActor.Enumerable.Indexable,
                IGroupChannelActor.Enumerable.BackLink<TSource>,
                IGroupChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IChannelActor.Indexable,
        Discord.IGroupChannelActor.Link,
        Discord.ILinkType<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.Indexable
    {
        internal new Discord.IGroupChannelActor this[Discord.IIdentifiable<ulong, Discord.IGroupChannel, Discord.IGroupChannelActor, Discord.Models.IGroupDMChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGroupChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGroupChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGroupChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGroupChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
            IGroupChannelActor.Indexable,
            IGroupChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IGroupChannelActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>,
        Discord.IChannelActor.Link
    {
        Discord.IGroupChannelActor Discord.IActorProvider<Discord.IGroupChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGroupChannel Discord.IEntityProvider<Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel>.CreateEntity(Discord.Models.IGroupDMChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
