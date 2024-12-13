using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMessageChannelTrait
{
    public new interface Paged<in TParams> : 
        Discord.IMessageChannelTrait.Link,
        Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IMessageChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IMessageChannel> Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
            IMessageChannelTrait.Paged<TParams>,
            IMessageChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageChannelTrait.Paged<TParams>,
            IMessageChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                IMessageChannelTrait.Paged<TParams>.Indexable,
                IMessageChannelTrait.Paged<TParams>.BackLink<TSource>,
                IMessageChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IMessageChannelTrait.Link,
        Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
            IMessageChannelTrait.Paged<TPaged, TParams>,
            IMessageChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageChannelTrait.Paged<TPaged, TParams>,
            IMessageChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                IMessageChannelTrait.Paged<TPaged, TParams>.Indexable,
                IMessageChannelTrait.Paged<TPaged, TParams>.BackLink<TSource>,
                IMessageChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IMessageChannelTrait.Link,
        Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
            IMessageChannelTrait.Defined,
            IMessageChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageChannelTrait.Defined,
            IMessageChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                IMessageChannelTrait.Defined.Indexable,
                IMessageChannelTrait.Defined.BackLink<TSource>,
                IMessageChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IMessageChannelTrait.Defined,
            IMessageChannelTrait.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                IMessageChannelTrait.Defined.Enumerable,
                IMessageChannelTrait.Defined.BackLink<TSource>,
                IMessageChannelTrait.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IMessageChannelTrait.Defined.Enumerable,
                IMessageChannelTrait.Defined.Indexable,
                IMessageChannelTrait.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                    IMessageChannelTrait.Defined.Enumerable.Indexable,
                    IMessageChannelTrait.Defined.Enumerable.BackLink<TSource>,
                    IMessageChannelTrait.Defined.Indexable.BackLink<TSource>,
                    IMessageChannelTrait.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IMessageChannelTrait.Link,
        Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IMessageChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IMessageChannel>> Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
            IMessageChannelTrait.Enumerable,
            IMessageChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageChannelTrait.Enumerable,
            IMessageChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
                IMessageChannelTrait.Enumerable.Indexable,
                IMessageChannelTrait.Enumerable.BackLink<TSource>,
                IMessageChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IMessageChannelTrait.Link,
        Discord.ILinkType<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>.Indexable
    {
        internal Discord.IMessageChannelTrait this[Discord.IIdentifiable<ulong, Discord.IMessageChannel, Discord.IMessageChannelTrait, Discord.Models.IChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
            IMessageChannelTrait.Indexable,
            IMessageChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>,
        Discord.IMessageChannelTrait
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IMessageChannelTrait, ulong, Discord.IMessageChannel, Discord.Models.IChannelModel>
    {
        Discord.IMessageChannelTrait Discord.IActorProvider<Discord.IMessageChannelTrait, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IMessageChannel Discord.IEntityProvider<Discord.IMessageChannel, Discord.Models.IChannelModel>.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
