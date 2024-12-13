using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStickerPackActor
{
    public new interface Paged<in TParams> : 
        Discord.IStickerPackActor.Link,
        Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IStickerPack> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IStickerPack> Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
            IStickerPackActor.Paged<TParams>,
            IStickerPackActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerPackActor.Paged<TParams>,
            IStickerPackActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                IStickerPackActor.Paged<TParams>.Indexable,
                IStickerPackActor.Paged<TParams>.BackLink<TSource>,
                IStickerPackActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IStickerPackActor.Link,
        Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
            IStickerPackActor.Paged<TPaged, TParams>,
            IStickerPackActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerPackActor.Paged<TPaged, TParams>,
            IStickerPackActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                IStickerPackActor.Paged<TPaged, TParams>.Indexable,
                IStickerPackActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IStickerPackActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IStickerPackActor.Link,
        Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
            IStickerPackActor.Defined,
            IStickerPackActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerPackActor.Defined,
            IStickerPackActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                IStickerPackActor.Defined.Indexable,
                IStickerPackActor.Defined.BackLink<TSource>,
                IStickerPackActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IStickerPackActor.Defined,
            IStickerPackActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                IStickerPackActor.Defined.Enumerable,
                IStickerPackActor.Defined.BackLink<TSource>,
                IStickerPackActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IStickerPackActor.Defined.Enumerable,
                IStickerPackActor.Defined.Indexable,
                IStickerPackActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                    IStickerPackActor.Defined.Enumerable.Indexable,
                    IStickerPackActor.Defined.Enumerable.BackLink<TSource>,
                    IStickerPackActor.Defined.Indexable.BackLink<TSource>,
                    IStickerPackActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IStickerPackActor.Link,
        Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IStickerPack>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IStickerPack>> Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
            IStickerPackActor.Enumerable,
            IStickerPackActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStickerPackActor.Enumerable,
            IStickerPackActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
                IStickerPackActor.Enumerable.Indexable,
                IStickerPackActor.Enumerable.BackLink<TSource>,
                IStickerPackActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IStickerPackActor.Link,
        Discord.ILinkType<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>.Indexable
    {
        internal Discord.IStickerPackActor this[Discord.IIdentifiable<ulong, Discord.IStickerPack, Discord.IStickerPackActor, Discord.Models.IStickerPackModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
            IStickerPackActor.Indexable,
            IStickerPackActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>,
        Discord.IStickerPackActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>
    {
        Discord.IStickerPackActor Discord.IActorProvider<Discord.IStickerPackActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IStickerPack Discord.IEntityProvider<Discord.IStickerPack, Discord.Models.IStickerPackModel>.CreateEntity(Discord.Models.IStickerPackModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
