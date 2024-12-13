using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IBanActor
{
    public new interface Paged<in TParams> : 
        Discord.IBanActor.Link,
        Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IBan> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IBan> Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
            IBanActor.Paged<TParams>,
            IBanActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IBanActor.Paged<TParams>,
            IBanActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                IBanActor.Paged<TParams>.Indexable,
                IBanActor.Paged<TParams>.BackLink<TSource>,
                IBanActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IBanActor.Link,
        Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
            IBanActor.Paged<TPaged, TParams>,
            IBanActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IBanActor.Paged<TPaged, TParams>,
            IBanActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                IBanActor.Paged<TPaged, TParams>.Indexable,
                IBanActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IBanActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IBanActor.Link,
        Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
            IBanActor.Defined,
            IBanActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IBanActor.Defined,
            IBanActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                IBanActor.Defined.Indexable,
                IBanActor.Defined.BackLink<TSource>,
                IBanActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IBanActor.Defined,
            IBanActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                IBanActor.Defined.Enumerable,
                IBanActor.Defined.BackLink<TSource>,
                IBanActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IBanActor.Defined.Enumerable,
                IBanActor.Defined.Indexable,
                IBanActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                    IBanActor.Defined.Enumerable.Indexable,
                    IBanActor.Defined.Enumerable.BackLink<TSource>,
                    IBanActor.Defined.Indexable.BackLink<TSource>,
                    IBanActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IBanActor.Link,
        Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IBan>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IBan>> Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
            IBanActor.Enumerable,
            IBanActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IBanActor.Enumerable,
            IBanActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
                IBanActor.Enumerable.Indexable,
                IBanActor.Enumerable.BackLink<TSource>,
                IBanActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IBanActor.Link,
        Discord.ILinkType<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>.Indexable
    {
        internal Discord.IBanActor this[Discord.IIdentifiable<ulong, Discord.IBan, Discord.IBanActor, Discord.Models.IBanModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
            IBanActor.Indexable,
            IBanActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>,
        Discord.IBanActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IBanActor, ulong, Discord.IBan, Discord.Models.IBanModel>
    {
        Discord.IBanActor Discord.IActorProvider<Discord.IBanActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IBan Discord.IEntityProvider<Discord.IBan, Discord.Models.IBanModel>.CreateEntity(Discord.Models.IBanModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
