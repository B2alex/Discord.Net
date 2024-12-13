using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPollActor
{
    public new interface Paged<in TParams> : 
        Discord.IPollActor.Link,
        Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IPoll> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IPoll> Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
            IPollActor.Paged<TParams>,
            IPollActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollActor.Paged<TParams>,
            IPollActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                IPollActor.Paged<TParams>.Indexable,
                IPollActor.Paged<TParams>.BackLink<TSource>,
                IPollActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IPollActor.Link,
        Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
            IPollActor.Paged<TPaged, TParams>,
            IPollActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollActor.Paged<TPaged, TParams>,
            IPollActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                IPollActor.Paged<TPaged, TParams>.Indexable,
                IPollActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IPollActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IPollActor.Link,
        Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
            IPollActor.Defined,
            IPollActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollActor.Defined,
            IPollActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                IPollActor.Defined.Indexable,
                IPollActor.Defined.BackLink<TSource>,
                IPollActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IPollActor.Defined,
            IPollActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                IPollActor.Defined.Enumerable,
                IPollActor.Defined.BackLink<TSource>,
                IPollActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IPollActor.Defined.Enumerable,
                IPollActor.Defined.Indexable,
                IPollActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                    IPollActor.Defined.Enumerable.Indexable,
                    IPollActor.Defined.Enumerable.BackLink<TSource>,
                    IPollActor.Defined.Indexable.BackLink<TSource>,
                    IPollActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IPollActor.Link,
        Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IPoll>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IPoll>> Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
            IPollActor.Enumerable,
            IPollActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollActor.Enumerable,
            IPollActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
                IPollActor.Enumerable.Indexable,
                IPollActor.Enumerable.BackLink<TSource>,
                IPollActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IPollActor.Link,
        Discord.ILinkType<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>.Indexable
    {
        internal Discord.IPollActor this[Discord.IIdentifiable<ulong, Discord.IPoll, Discord.IPollActor, Discord.Models.IPollModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
            IPollActor.Indexable,
            IPollActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>,
        Discord.IPollActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IPollActor, ulong, Discord.IPoll, Discord.Models.IPollModel>
    {
        Discord.IPollActor Discord.IActorProvider<Discord.IPollActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IPoll Discord.IEntityProvider<Discord.IPoll, Discord.Models.IPollModel>.CreateEntity(Discord.Models.IPollModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
