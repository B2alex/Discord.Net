using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ISkuActor
{
    public new interface Paged<in TParams> : 
        Discord.ISkuActor.Link,
        Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ISku> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ISku> Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
            ISkuActor.Paged<TParams>,
            ISkuActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISkuActor.Paged<TParams>,
            ISkuActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                ISkuActor.Paged<TParams>.Indexable,
                ISkuActor.Paged<TParams>.BackLink<TSource>,
                ISkuActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.ISkuActor.Link,
        Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
            ISkuActor.Paged<TPaged, TParams>,
            ISkuActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISkuActor.Paged<TPaged, TParams>,
            ISkuActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                ISkuActor.Paged<TPaged, TParams>.Indexable,
                ISkuActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ISkuActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.ISkuActor.Link,
        Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
            ISkuActor.Defined,
            ISkuActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISkuActor.Defined,
            ISkuActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                ISkuActor.Defined.Indexable,
                ISkuActor.Defined.BackLink<TSource>,
                ISkuActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ISkuActor.Defined,
            ISkuActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                ISkuActor.Defined.Enumerable,
                ISkuActor.Defined.BackLink<TSource>,
                ISkuActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ISkuActor.Defined.Enumerable,
                ISkuActor.Defined.Indexable,
                ISkuActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                    ISkuActor.Defined.Enumerable.Indexable,
                    ISkuActor.Defined.Enumerable.BackLink<TSource>,
                    ISkuActor.Defined.Indexable.BackLink<TSource>,
                    ISkuActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.ISkuActor.Link,
        Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ISku>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ISku>> Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
            ISkuActor.Enumerable,
            ISkuActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISkuActor.Enumerable,
            ISkuActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
                ISkuActor.Enumerable.Indexable,
                ISkuActor.Enumerable.BackLink<TSource>,
                ISkuActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.ISkuActor.Link,
        Discord.ILinkType<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>.Indexable
    {
        internal Discord.ISkuActor this[Discord.IIdentifiable<ulong, Discord.ISku, Discord.ISkuActor, Discord.Models.ISkuModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
            ISkuActor.Indexable,
            ISkuActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>,
        Discord.ISkuActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.ISkuActor, ulong, Discord.ISku, Discord.Models.ISkuModel>
    {
        Discord.ISkuActor Discord.IActorProvider<Discord.ISkuActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ISku Discord.IEntityProvider<Discord.ISku, Discord.Models.ISkuModel>.CreateEntity(Discord.Models.ISkuModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
