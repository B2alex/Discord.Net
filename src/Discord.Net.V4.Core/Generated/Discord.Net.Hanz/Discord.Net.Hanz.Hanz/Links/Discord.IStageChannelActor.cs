using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStageChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IVoiceChannelActor.Paged<TParams>,
        Discord.IGuildChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IStageChannelActor.Link,
        Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IStageChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IStageChannel> Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IVoiceChannel> Discord.IVoiceChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.IGuildChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
            IStageChannelActor.Paged<TParams>,
            IStageChannelActor.BackLink<TSource>,
            Discord.IVoiceChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageChannelActor.Paged<TParams>,
            IStageChannelActor.Indexable,
            Discord.IVoiceChannelActor.Paged<TParams>.Indexable,
            Discord.IGuildChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                IStageChannelActor.Paged<TParams>.Indexable,
                IStageChannelActor.Paged<TParams>.BackLink<TSource>,
                IStageChannelActor.Indexable.BackLink<TSource>,
                Discord.IVoiceChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IVoiceChannelActor.Paged<TPaged, TParams>,
        Discord.IGuildChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IStageChannelActor.Link,
        Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IVoiceChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
            IStageChannelActor.Paged<TPaged, TParams>,
            IStageChannelActor.BackLink<TSource>,
            Discord.IVoiceChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageChannelActor.Paged<TPaged, TParams>,
            IStageChannelActor.Indexable,
            Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                IStageChannelActor.Paged<TPaged, TParams>.Indexable,
                IStageChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IStageChannelActor.Indexable.BackLink<TSource>,
                Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IVoiceChannelActor.Defined,
        Discord.IGuildChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IStageChannelActor.Link,
        Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IVoiceChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IGuildChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
            IStageChannelActor.Defined,
            IStageChannelActor.BackLink<TSource>,
            Discord.IVoiceChannelActor.Defined.BackLink<TSource>,
            Discord.IGuildChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageChannelActor.Defined,
            IStageChannelActor.Indexable,
            Discord.IVoiceChannelActor.Defined.Indexable,
            Discord.IGuildChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                IStageChannelActor.Defined.Indexable,
                IStageChannelActor.Defined.BackLink<TSource>,
                IStageChannelActor.Indexable.BackLink<TSource>,
                Discord.IVoiceChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IStageChannelActor.Defined,
            IStageChannelActor.Enumerable,
            Discord.IVoiceChannelActor.Defined.Enumerable,
            Discord.IGuildChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                IStageChannelActor.Defined.Enumerable,
                IStageChannelActor.Defined.BackLink<TSource>,
                IStageChannelActor.Enumerable.BackLink<TSource>,
                Discord.IVoiceChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IStageChannelActor.Defined.Enumerable,
                IStageChannelActor.Defined.Indexable,
                IStageChannelActor.Enumerable.Indexable,
                Discord.IVoiceChannelActor.Defined.Enumerable.Indexable,
                Discord.IGuildChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                    IStageChannelActor.Defined.Enumerable.Indexable,
                    IStageChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IStageChannelActor.Defined.Indexable.BackLink<TSource>,
                    IStageChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IVoiceChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IVoiceChannelActor.Enumerable,
        Discord.IGuildChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IStageChannelActor.Link,
        Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IStageChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IStageChannel>> Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IVoiceChannel>> Discord.IVoiceChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.IGuildChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
            IStageChannelActor.Enumerable,
            IStageChannelActor.BackLink<TSource>,
            Discord.IVoiceChannelActor.Enumerable.BackLink<TSource>,
            Discord.IGuildChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageChannelActor.Enumerable,
            IStageChannelActor.Indexable,
            Discord.IVoiceChannelActor.Enumerable.Indexable,
            Discord.IGuildChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
                IStageChannelActor.Enumerable.Indexable,
                IStageChannelActor.Enumerable.BackLink<TSource>,
                IStageChannelActor.Indexable.BackLink<TSource>,
                Discord.IVoiceChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IVoiceChannelActor.Indexable,
        Discord.IGuildChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IStageChannelActor.Link,
        Discord.ILinkType<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.Indexable
    {
        internal new Discord.IStageChannelActor this[Discord.IIdentifiable<ulong, Discord.IStageChannel, Discord.IStageChannelActor, Discord.Models.IGuildStageChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IStageChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IStageChannelActor, ulong>).GetActor(id);
    
        Discord.IVoiceChannelActor Discord.IVoiceChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IStageChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IStageChannelActor, ulong>).GetActor(id);
    
        Discord.IVoiceChannelActor Discord.IVoiceChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
            IStageChannelActor.Indexable,
            IStageChannelActor.BackLink<TSource>,
            Discord.IVoiceChannelActor.Indexable.BackLink<TSource>,
            Discord.IGuildChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
        Discord.IVoiceChannelActor.BackLink<TSource>,
        Discord.IGuildChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IStageChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>,
        Discord.IVoiceChannelActor.Link,
        Discord.IGuildChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IStageChannelActor Discord.IActorProvider<Discord.IStageChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IStageChannel Discord.IEntityProvider<Discord.IStageChannel, Discord.Models.IGuildStageChannelModel>.CreateEntity(Discord.Models.IGuildStageChannelModel model) => CreateEntity(model);
    
        Discord.IVoiceChannelActor Discord.IVoiceChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IVoiceChannel Discord.IVoiceChannelActor.Link.CreateEntity(Discord.Models.IGuildVoiceChannelModel model) => CreateEntity(model);
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IGuildChannelActor.Link.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
