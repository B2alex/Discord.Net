using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionActor
{
    public new interface Paged<in TParams> : 
        Discord.IInteractionActor.Link,
        Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IInteraction> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IInteraction> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionActor.Paged<TParams>,
            IInteractionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionActor.Paged<TParams>,
            IInteractionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionActor.Paged<TParams>.Indexable,
                IInteractionActor.Paged<TParams>.BackLink<TSource>,
                IInteractionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInteractionActor.Link,
        Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionActor.Paged<TPaged, TParams>,
            IInteractionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionActor.Paged<TPaged, TParams>,
            IInteractionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionActor.Paged<TPaged, TParams>.Indexable,
                IInteractionActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInteractionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInteractionActor.Link,
        Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionActor.Defined,
            IInteractionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionActor.Defined,
            IInteractionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionActor.Defined.Indexable,
                IInteractionActor.Defined.BackLink<TSource>,
                IInteractionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IInteractionActor.Defined,
            IInteractionActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionActor.Defined.Enumerable,
                IInteractionActor.Defined.BackLink<TSource>,
                IInteractionActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IInteractionActor.Defined.Enumerable,
                IInteractionActor.Defined.Indexable,
                IInteractionActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                    IInteractionActor.Defined.Enumerable.Indexable,
                    IInteractionActor.Defined.Enumerable.BackLink<TSource>,
                    IInteractionActor.Defined.Indexable.BackLink<TSource>,
                    IInteractionActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInteractionActor.Link,
        Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IInteraction>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IInteraction>> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionActor.Enumerable,
            IInteractionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionActor.Enumerable,
            IInteractionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionActor.Enumerable.Indexable,
                IInteractionActor.Enumerable.BackLink<TSource>,
                IInteractionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInteractionActor.Link,
        Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Indexable
    {
        internal Discord.IInteractionActor this[Discord.IIdentifiable<ulong, Discord.IInteraction, Discord.IInteractionActor, Discord.Models.IInteractionModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionActor.Indexable,
            IInteractionActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
        Discord.IInteractionActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>
    {
        Discord.IInteractionActor Discord.IActorProvider<Discord.IInteractionActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IInteraction Discord.IEntityProvider<Discord.IInteraction, Discord.Models.IInteractionModel>.CreateEntity(Discord.Models.IInteractionModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
