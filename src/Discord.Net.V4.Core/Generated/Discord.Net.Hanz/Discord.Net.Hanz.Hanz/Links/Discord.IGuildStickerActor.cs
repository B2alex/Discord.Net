using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildStickerActor
{
    public new interface Paged<in TParams> : 
        Discord.IStickerActor.Paged<TParams>,
        Discord.IGuildStickerActor.Link,
        Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildSticker> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildSticker> Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.ISticker> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
            IGuildStickerActor.Paged<TParams>,
            IGuildStickerActor.BackLink<TSource>,
            Discord.IStickerActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildStickerActor.Paged<TParams>,
            IGuildStickerActor.Indexable,
            Discord.IStickerActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                IGuildStickerActor.Paged<TParams>.Indexable,
                IGuildStickerActor.Paged<TParams>.BackLink<TSource>,
                IGuildStickerActor.Indexable.BackLink<TSource>,
                Discord.IStickerActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IStickerActor.Paged<TPaged, TParams>,
        Discord.IGuildStickerActor.Link,
        Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
            IGuildStickerActor.Paged<TPaged, TParams>,
            IGuildStickerActor.BackLink<TSource>,
            Discord.IStickerActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildStickerActor.Paged<TPaged, TParams>,
            IGuildStickerActor.Indexable,
            Discord.IStickerActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                IGuildStickerActor.Paged<TPaged, TParams>.Indexable,
                IGuildStickerActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildStickerActor.Indexable.BackLink<TSource>,
                Discord.IStickerActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IStickerActor.Defined,
        Discord.IGuildStickerActor.Link,
        Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
            IGuildStickerActor.Defined,
            IGuildStickerActor.BackLink<TSource>,
            Discord.IStickerActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildStickerActor.Defined,
            IGuildStickerActor.Indexable,
            Discord.IStickerActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                IGuildStickerActor.Defined.Indexable,
                IGuildStickerActor.Defined.BackLink<TSource>,
                IGuildStickerActor.Indexable.BackLink<TSource>,
                Discord.IStickerActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildStickerActor.Defined,
            IGuildStickerActor.Enumerable,
            Discord.IStickerActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                IGuildStickerActor.Defined.Enumerable,
                IGuildStickerActor.Defined.BackLink<TSource>,
                IGuildStickerActor.Enumerable.BackLink<TSource>,
                Discord.IStickerActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildStickerActor.Defined.Enumerable,
                IGuildStickerActor.Defined.Indexable,
                IGuildStickerActor.Enumerable.Indexable,
                Discord.IStickerActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                    IGuildStickerActor.Defined.Enumerable.Indexable,
                    IGuildStickerActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildStickerActor.Defined.Indexable.BackLink<TSource>,
                    IGuildStickerActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IStickerActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IStickerActor.Enumerable,
        Discord.IGuildStickerActor.Link,
        Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildSticker>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildSticker>> Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.ISticker>> Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
            IGuildStickerActor.Enumerable,
            IGuildStickerActor.BackLink<TSource>,
            Discord.IStickerActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildStickerActor.Enumerable,
            IGuildStickerActor.Indexable,
            Discord.IStickerActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
                IGuildStickerActor.Enumerable.Indexable,
                IGuildStickerActor.Enumerable.BackLink<TSource>,
                IGuildStickerActor.Indexable.BackLink<TSource>,
                Discord.IStickerActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IStickerActor.Indexable,
        Discord.IGuildStickerActor.Link,
        Discord.ILinkType<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.Indexable
    {
        internal new Discord.IGuildStickerActor this[Discord.IIdentifiable<ulong, Discord.IGuildSticker, Discord.IGuildStickerActor, Discord.Models.IGuildStickerModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildStickerActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildStickerActor, ulong>).GetActor(id);
    
        Discord.IStickerActor Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildStickerActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildStickerActor, ulong>).GetActor(id);
    
        Discord.IStickerActor Discord.ILinkType<Discord.IStickerActor, ulong, Discord.ISticker, Discord.Models.IStickerModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
            IGuildStickerActor.Indexable,
            IGuildStickerActor.BackLink<TSource>,
            Discord.IStickerActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
        Discord.IStickerActor.BackLink<TSource>,
        Discord.IGuildStickerActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker, Discord.Models.IGuildStickerModel>,
        Discord.IStickerActor.Link
    {
        Discord.IGuildStickerActor Discord.IActorProvider<Discord.IGuildStickerActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildSticker Discord.IEntityProvider<Discord.IGuildSticker, Discord.Models.IGuildStickerModel>.CreateEntity(Discord.Models.IGuildStickerModel model) => CreateEntity(model);
    
        Discord.IStickerActor Discord.IStickerActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.ISticker Discord.IStickerActor.Link.CreateEntity(Discord.Models.IStickerModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
