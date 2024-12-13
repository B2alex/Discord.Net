using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadableChannelTrait
{
    public new interface Paged<in TParams> : 
        Discord.IThreadableChannelTrait.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IThreadableChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IThreadableChannel> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait.Paged<TParams>,
            IThreadableChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait.Paged<TParams>,
            IThreadableChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait.Paged<TParams>.Indexable,
                IThreadableChannelTrait.Paged<TParams>.BackLink<TSource>,
                IThreadableChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IThreadableChannelTrait.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait.Paged<TPaged, TParams>,
            IThreadableChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait.Paged<TPaged, TParams>,
            IThreadableChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait.Paged<TPaged, TParams>.Indexable,
                IThreadableChannelTrait.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadableChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IThreadableChannelTrait.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait.Defined,
            IThreadableChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait.Defined,
            IThreadableChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait.Defined.Indexable,
                IThreadableChannelTrait.Defined.BackLink<TSource>,
                IThreadableChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IThreadableChannelTrait.Defined,
            IThreadableChannelTrait.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait.Defined.Enumerable,
                IThreadableChannelTrait.Defined.BackLink<TSource>,
                IThreadableChannelTrait.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IThreadableChannelTrait.Defined.Enumerable,
                IThreadableChannelTrait.Defined.Indexable,
                IThreadableChannelTrait.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                    IThreadableChannelTrait.Defined.Enumerable.Indexable,
                    IThreadableChannelTrait.Defined.Enumerable.BackLink<TSource>,
                    IThreadableChannelTrait.Defined.Indexable.BackLink<TSource>,
                    IThreadableChannelTrait.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IThreadableChannelTrait.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IThreadableChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IThreadableChannel>> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait.Enumerable,
            IThreadableChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait.Enumerable,
            IThreadableChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait.Enumerable.Indexable,
                IThreadableChannelTrait.Enumerable.BackLink<TSource>,
                IThreadableChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IThreadableChannelTrait.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Indexable
    {
        internal Discord.IThreadableChannelTrait this[Discord.IIdentifiable<ulong, Discord.IThreadableChannel, Discord.IThreadableChannelTrait, Discord.Models.IThreadableChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait.Indexable,
            IThreadableChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
        Discord.IThreadableChannelTrait
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>
    {
        Discord.IThreadableChannelTrait Discord.IActorProvider<Discord.IThreadableChannelTrait, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadableChannel Discord.IEntityProvider<Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.CreateEntity(Discord.Models.IThreadableChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
