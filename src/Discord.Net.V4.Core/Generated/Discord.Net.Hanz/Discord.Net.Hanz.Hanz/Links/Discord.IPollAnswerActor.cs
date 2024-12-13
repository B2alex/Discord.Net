using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPollAnswerActor
{
    public new interface Paged<in TParams> : 
        Discord.IPollAnswerActor.Link,
        Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IPollAnswer> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IPollAnswer> Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
            IPollAnswerActor.Paged<TParams>,
            IPollAnswerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollAnswerActor.Paged<TParams>,
            IPollAnswerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                IPollAnswerActor.Paged<TParams>.Indexable,
                IPollAnswerActor.Paged<TParams>.BackLink<TSource>,
                IPollAnswerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IPollAnswerActor.Link,
        Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
            IPollAnswerActor.Paged<TPaged, TParams>,
            IPollAnswerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollAnswerActor.Paged<TPaged, TParams>,
            IPollAnswerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                IPollAnswerActor.Paged<TPaged, TParams>.Indexable,
                IPollAnswerActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IPollAnswerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IPollAnswerActor.Link,
        Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Defined
    {
        new IReadOnlyCollection<int> Ids { get; }
    
        IReadOnlyCollection<int> Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
            IPollAnswerActor.Defined,
            IPollAnswerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollAnswerActor.Defined,
            IPollAnswerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                IPollAnswerActor.Defined.Indexable,
                IPollAnswerActor.Defined.BackLink<TSource>,
                IPollAnswerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IPollAnswerActor.Defined,
            IPollAnswerActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                IPollAnswerActor.Defined.Enumerable,
                IPollAnswerActor.Defined.BackLink<TSource>,
                IPollAnswerActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IPollAnswerActor.Defined.Enumerable,
                IPollAnswerActor.Defined.Indexable,
                IPollAnswerActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                    IPollAnswerActor.Defined.Enumerable.Indexable,
                    IPollAnswerActor.Defined.Enumerable.BackLink<TSource>,
                    IPollAnswerActor.Defined.Indexable.BackLink<TSource>,
                    IPollAnswerActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IPollAnswerActor.Link,
        Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IPollAnswer>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IPollAnswer>> Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
            IPollAnswerActor.Enumerable,
            IPollAnswerActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IPollAnswerActor.Enumerable,
            IPollAnswerActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
                IPollAnswerActor.Enumerable.Indexable,
                IPollAnswerActor.Enumerable.BackLink<TSource>,
                IPollAnswerActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IPollAnswerActor.Link,
        Discord.ILinkType<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.Indexable
    {
        internal Discord.IPollAnswerActor this[Discord.IIdentifiable<int, Discord.IPollAnswer, Discord.IPollAnswerActor, Discord.Models.IPollAnswerModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
            IPollAnswerActor.Indexable,
            IPollAnswerActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>,
        Discord.IPollAnswerActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IPollAnswerActor, int, Discord.IPollAnswer, Discord.Models.IPollAnswerModel>
    {
        Discord.IPollAnswerActor Discord.IActorProvider<Discord.IPollAnswerActor, int>.GetActor(int id) => GetActor(id);
    
        Discord.IPollAnswer Discord.IEntityProvider<Discord.IPollAnswer, Discord.Models.IPollAnswerModel>.CreateEntity(Discord.Models.IPollAnswerModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
