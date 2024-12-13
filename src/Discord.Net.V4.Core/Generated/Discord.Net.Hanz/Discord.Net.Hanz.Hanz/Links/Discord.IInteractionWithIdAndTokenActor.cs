using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionWithIdAndTokenActor
{
    public new interface Paged<in TParams> : 
        Discord.IInteractionActor.Paged<TParams>,
        Discord.IInteractionWithIdAndTokenActor.Link,
        Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IInteraction> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IInteraction> Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IInteraction> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionWithIdAndTokenActor.Paged<TParams>,
            IInteractionWithIdAndTokenActor.BackLink<TSource>,
            Discord.IInteractionActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionWithIdAndTokenActor.Paged<TParams>,
            IInteractionWithIdAndTokenActor.Indexable,
            Discord.IInteractionActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionWithIdAndTokenActor.Paged<TParams>.Indexable,
                IInteractionWithIdAndTokenActor.Paged<TParams>.BackLink<TSource>,
                IInteractionWithIdAndTokenActor.Indexable.BackLink<TSource>,
                Discord.IInteractionActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInteractionActor.Paged<TPaged, TParams>,
        Discord.IInteractionWithIdAndTokenActor.Link,
        Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionWithIdAndTokenActor.Paged<TPaged, TParams>,
            IInteractionWithIdAndTokenActor.BackLink<TSource>,
            Discord.IInteractionActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionWithIdAndTokenActor.Paged<TPaged, TParams>,
            IInteractionWithIdAndTokenActor.Indexable,
            Discord.IInteractionActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionWithIdAndTokenActor.Paged<TPaged, TParams>.Indexable,
                IInteractionWithIdAndTokenActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInteractionWithIdAndTokenActor.Indexable.BackLink<TSource>,
                Discord.IInteractionActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInteractionActor.Defined,
        Discord.IInteractionWithIdAndTokenActor.Link,
        Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionWithIdAndTokenActor.Defined,
            IInteractionWithIdAndTokenActor.BackLink<TSource>,
            Discord.IInteractionActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionWithIdAndTokenActor.Defined,
            IInteractionWithIdAndTokenActor.Indexable,
            Discord.IInteractionActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionWithIdAndTokenActor.Defined.Indexable,
                IInteractionWithIdAndTokenActor.Defined.BackLink<TSource>,
                IInteractionWithIdAndTokenActor.Indexable.BackLink<TSource>,
                Discord.IInteractionActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IInteractionWithIdAndTokenActor.Defined,
            IInteractionWithIdAndTokenActor.Enumerable,
            Discord.IInteractionActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionWithIdAndTokenActor.Defined.Enumerable,
                IInteractionWithIdAndTokenActor.Defined.BackLink<TSource>,
                IInteractionWithIdAndTokenActor.Enumerable.BackLink<TSource>,
                Discord.IInteractionActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IInteractionWithIdAndTokenActor.Defined.Enumerable,
                IInteractionWithIdAndTokenActor.Defined.Indexable,
                IInteractionWithIdAndTokenActor.Enumerable.Indexable,
                Discord.IInteractionActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                    IInteractionWithIdAndTokenActor.Defined.Enumerable.Indexable,
                    IInteractionWithIdAndTokenActor.Defined.Enumerable.BackLink<TSource>,
                    IInteractionWithIdAndTokenActor.Defined.Indexable.BackLink<TSource>,
                    IInteractionWithIdAndTokenActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IInteractionActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInteractionActor.Enumerable,
        Discord.IInteractionWithIdAndTokenActor.Link,
        Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IInteraction>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IInteraction>> Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IInteraction>> Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionWithIdAndTokenActor.Enumerable,
            IInteractionWithIdAndTokenActor.BackLink<TSource>,
            Discord.IInteractionActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionWithIdAndTokenActor.Enumerable,
            IInteractionWithIdAndTokenActor.Indexable,
            Discord.IInteractionActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
                IInteractionWithIdAndTokenActor.Enumerable.Indexable,
                IInteractionWithIdAndTokenActor.Enumerable.BackLink<TSource>,
                IInteractionWithIdAndTokenActor.Indexable.BackLink<TSource>,
                Discord.IInteractionActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInteractionActor.Indexable,
        Discord.IInteractionWithIdAndTokenActor.Link,
        Discord.ILinkType<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Indexable
    {
        internal new Discord.IInteractionWithIdAndTokenActor this[Discord.IIdentifiable<ulong, Discord.IInteraction, Discord.IInteractionWithIdAndTokenActor, Discord.Models.IInteractionModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IInteractionWithIdAndTokenActor this[ulong id] => (this as Discord.IActorProvider<Discord.IInteractionWithIdAndTokenActor, ulong>).GetActor(id);
    
        Discord.IInteractionActor Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IInteractionWithIdAndTokenActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IInteractionWithIdAndTokenActor, ulong>).GetActor(id);
    
        Discord.IInteractionActor Discord.ILinkType<Discord.IInteractionActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
            IInteractionWithIdAndTokenActor.Indexable,
            IInteractionWithIdAndTokenActor.BackLink<TSource>,
            Discord.IInteractionActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
        Discord.IInteractionActor.BackLink<TSource>,
        Discord.IInteractionWithIdAndTokenActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction, Discord.Models.IInteractionModel>,
        Discord.IInteractionActor.Link
    {
        Discord.IInteractionWithIdAndTokenActor Discord.IActorProvider<Discord.IInteractionWithIdAndTokenActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IInteraction Discord.IEntityProvider<Discord.IInteraction, Discord.Models.IInteractionModel>.CreateEntity(Discord.Models.IInteractionModel model) => CreateEntity(model);
    
        Discord.IInteractionActor Discord.IInteractionActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IInteraction Discord.IInteractionActor.Link.CreateEntity(Discord.Models.IInteractionModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
