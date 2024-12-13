using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStickerActor
{
    public new interface Paged<in TParams> : 
        Discord.IStickerActor.Link,
        Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ISticker> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ISticker> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
            IStickerActor.Paged<TParams>,
            IStickerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerActor.Paged<TParams>,
            IStickerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                IStickerActor.Paged<TParams>.Indexable,
                IStickerActor.Paged<TParams>.BackLink<TSource>,
                IStickerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IStickerActor.Link,
        Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
            IStickerActor.Paged<TPaged, TParams>,
            IStickerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerActor.Paged<TPaged, TParams>,
            IStickerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                IStickerActor.Paged<TPaged, TParams>.Indexable,
                IStickerActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IStickerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IStickerActor.Link,
        Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
            IStickerActor.Defined,
            IStickerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerActor.Defined,
            IStickerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                IStickerActor.Defined.Indexable,
                IStickerActor.Defined.BackLink<TSource>,
                IStickerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IStickerActor.Defined,
            IStickerActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                IStickerActor.Defined.Enumerable,
                IStickerActor.Defined.BackLink<TSource>,
                IStickerActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IStickerActor.Defined.Enumerable,
                IStickerActor.Defined.Indexable,
                IStickerActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                    IStickerActor.Defined.Enumerable.Indexable,
                    IStickerActor.Defined.Enumerable.BackLink<TSource>,
                    IStickerActor.Defined.Indexable.BackLink<TSource>,
                    IStickerActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IStickerActor.Link,
        Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ISticker>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ISticker>> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
            IStickerActor.Enumerable,
            IStickerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerActor.Enumerable,
            IStickerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
                IStickerActor.Enumerable.Indexable,
                IStickerActor.Enumerable.BackLink<TSource>,
                IStickerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IStickerActor.Link,
        Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Indexable
    {
        internal Discord.IStickerActor this[Discord.IIdentifiable<ulong, Discord.ISticker, Discord.IStickerActor, Discord.Models.IStickerModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
            IStickerActor.Indexable,
            IStickerActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>,
        Discord.IStickerActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>
    {
        Discord.IStickerActor Discord.IActorProvider<Discord.IStickerActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ISticker Discord.IEntityProvider<Discord.ISticker, Discord.Models.IStickerModel>.CreateEntity(Discord.Models.IStickerModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
