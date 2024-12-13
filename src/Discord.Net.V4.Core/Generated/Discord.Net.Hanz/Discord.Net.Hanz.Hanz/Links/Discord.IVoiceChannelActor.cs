using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IVoiceChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IVoiceChannelActor.Link,
        Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IVoiceChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IVoiceChannel> Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
            IVoiceChannelActor.Paged<TParams>,
            IVoiceChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceChannelActor.Paged<TParams>,
            IVoiceChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                IVoiceChannelActor.Paged<TParams>.Indexable,
                IVoiceChannelActor.Paged<TParams>.BackLink<TSource>,
                IVoiceChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IVoiceChannelActor.Link,
        Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
            IVoiceChannelActor.Paged<TPaged, TParams>,
            IVoiceChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceChannelActor.Paged<TPaged, TParams>,
            IVoiceChannelActor.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                IVoiceChannelActor.Paged<TPaged, TParams>.Indexable,
                IVoiceChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IVoiceChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IVoiceChannelActor.Link,
        Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
            IVoiceChannelActor.Defined,
            IVoiceChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceChannelActor.Defined,
            IVoiceChannelActor.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                IVoiceChannelActor.Defined.Indexable,
                IVoiceChannelActor.Defined.BackLink<TSource>,
                IVoiceChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IVoiceChannelActor.Defined,
            IVoiceChannelActor.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                IVoiceChannelActor.Defined.Enumerable,
                IVoiceChannelActor.Defined.BackLink<TSource>,
                IVoiceChannelActor.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IVoiceChannelActor.Defined.Enumerable,
                IVoiceChannelActor.Defined.Indexable,
                IVoiceChannelActor.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                    IVoiceChannelActor.Defined.Enumerable.Indexable,
                    IVoiceChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IVoiceChannelActor.Defined.Indexable.BackLink<TSource>,
                    IVoiceChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IVoiceChannelActor.Link,
        Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IVoiceChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IVoiceChannel>> Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
            IVoiceChannelActor.Enumerable,
            IVoiceChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceChannelActor.Enumerable,
            IVoiceChannelActor.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
                IVoiceChannelActor.Enumerable.Indexable,
                IVoiceChannelActor.Enumerable.BackLink<TSource>,
                IVoiceChannelActor.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IVoiceChannelActor.Link,
        Discord.ILinkType<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.Indexable
    {
        internal new Discord.IVoiceChannelActor this[Discord.IIdentifiable<ulong, Discord.IVoiceChannel, Discord.IVoiceChannelActor, Discord.Models.IGuildVoiceChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IVoiceChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IVoiceChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IVoiceChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IVoiceChannelActor, ulong>).GetActor(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
            IVoiceChannelActor.Indexable,
            IVoiceChannelActor.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IVoiceChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IVoiceChannelActor Discord.IActorProvider<Discord.IVoiceChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IVoiceChannel Discord.IEntityProvider<Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel>.CreateEntity(Discord.Models.IGuildVoiceChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
