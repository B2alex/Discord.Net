using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildScheduledEventActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildScheduledEventActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildScheduledEvent> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildScheduledEvent> Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
            IGuildScheduledEventActor.Paged<TParams>,
            IGuildScheduledEventActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventActor.Paged<TParams>,
            IGuildScheduledEventActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                IGuildScheduledEventActor.Paged<TParams>.Indexable,
                IGuildScheduledEventActor.Paged<TParams>.BackLink<TSource>,
                IGuildScheduledEventActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildScheduledEventActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
            IGuildScheduledEventActor.Paged<TPaged, TParams>,
            IGuildScheduledEventActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventActor.Paged<TPaged, TParams>,
            IGuildScheduledEventActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                IGuildScheduledEventActor.Paged<TPaged, TParams>.Indexable,
                IGuildScheduledEventActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildScheduledEventActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildScheduledEventActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
            IGuildScheduledEventActor.Defined,
            IGuildScheduledEventActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventActor.Defined,
            IGuildScheduledEventActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                IGuildScheduledEventActor.Defined.Indexable,
                IGuildScheduledEventActor.Defined.BackLink<TSource>,
                IGuildScheduledEventActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildScheduledEventActor.Defined,
            IGuildScheduledEventActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                IGuildScheduledEventActor.Defined.Enumerable,
                IGuildScheduledEventActor.Defined.BackLink<TSource>,
                IGuildScheduledEventActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildScheduledEventActor.Defined.Enumerable,
                IGuildScheduledEventActor.Defined.Indexable,
                IGuildScheduledEventActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                    IGuildScheduledEventActor.Defined.Enumerable.Indexable,
                    IGuildScheduledEventActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildScheduledEventActor.Defined.Indexable.BackLink<TSource>,
                    IGuildScheduledEventActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildScheduledEventActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildScheduledEvent>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildScheduledEvent>> Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
            IGuildScheduledEventActor.Enumerable,
            IGuildScheduledEventActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventActor.Enumerable,
            IGuildScheduledEventActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
                IGuildScheduledEventActor.Enumerable.Indexable,
                IGuildScheduledEventActor.Enumerable.BackLink<TSource>,
                IGuildScheduledEventActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildScheduledEventActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.Indexable
    {
        internal Discord.IGuildScheduledEventActor this[Discord.IIdentifiable<ulong, Discord.IGuildScheduledEvent, Discord.IGuildScheduledEventActor, Discord.Models.IGuildScheduledEventModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
            IGuildScheduledEventActor.Indexable,
            IGuildScheduledEventActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>,
        Discord.IGuildScheduledEventActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>
    {
        Discord.IGuildScheduledEventActor Discord.IActorProvider<Discord.IGuildScheduledEventActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildScheduledEvent Discord.IEntityProvider<Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel>.CreateEntity(Discord.Models.IGuildScheduledEventModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
