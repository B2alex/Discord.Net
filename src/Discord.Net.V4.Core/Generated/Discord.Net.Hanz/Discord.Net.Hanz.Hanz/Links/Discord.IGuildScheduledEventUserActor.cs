using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildScheduledEventUserActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildScheduledEventUserActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildScheduledEventUser> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildScheduledEventUser> Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
            IGuildScheduledEventUserActor.Paged<TParams>,
            IGuildScheduledEventUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventUserActor.Paged<TParams>,
            IGuildScheduledEventUserActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                IGuildScheduledEventUserActor.Paged<TParams>.Indexable,
                IGuildScheduledEventUserActor.Paged<TParams>.BackLink<TSource>,
                IGuildScheduledEventUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildScheduledEventUserActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
            IGuildScheduledEventUserActor.Paged<TPaged, TParams>,
            IGuildScheduledEventUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventUserActor.Paged<TPaged, TParams>,
            IGuildScheduledEventUserActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                IGuildScheduledEventUserActor.Paged<TPaged, TParams>.Indexable,
                IGuildScheduledEventUserActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildScheduledEventUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildScheduledEventUserActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
            IGuildScheduledEventUserActor.Defined,
            IGuildScheduledEventUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventUserActor.Defined,
            IGuildScheduledEventUserActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                IGuildScheduledEventUserActor.Defined.Indexable,
                IGuildScheduledEventUserActor.Defined.BackLink<TSource>,
                IGuildScheduledEventUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildScheduledEventUserActor.Defined,
            IGuildScheduledEventUserActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                IGuildScheduledEventUserActor.Defined.Enumerable,
                IGuildScheduledEventUserActor.Defined.BackLink<TSource>,
                IGuildScheduledEventUserActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildScheduledEventUserActor.Defined.Enumerable,
                IGuildScheduledEventUserActor.Defined.Indexable,
                IGuildScheduledEventUserActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                    IGuildScheduledEventUserActor.Defined.Enumerable.Indexable,
                    IGuildScheduledEventUserActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildScheduledEventUserActor.Defined.Indexable.BackLink<TSource>,
                    IGuildScheduledEventUserActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildScheduledEventUserActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildScheduledEventUser>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildScheduledEventUser>> Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
            IGuildScheduledEventUserActor.Enumerable,
            IGuildScheduledEventUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildScheduledEventUserActor.Enumerable,
            IGuildScheduledEventUserActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
                IGuildScheduledEventUserActor.Enumerable.Indexable,
                IGuildScheduledEventUserActor.Enumerable.BackLink<TSource>,
                IGuildScheduledEventUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildScheduledEventUserActor.Link,
        Discord.ILinkType<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.Indexable
    {
        internal Discord.IGuildScheduledEventUserActor this[Discord.IIdentifiable<ulong, Discord.IGuildScheduledEventUser, Discord.IGuildScheduledEventUserActor, Discord.Models.IGuildScheduledEventUserModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
            IGuildScheduledEventUserActor.Indexable,
            IGuildScheduledEventUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>,
        Discord.IGuildScheduledEventUserActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>
    {
        Discord.IGuildScheduledEventUserActor Discord.IActorProvider<Discord.IGuildScheduledEventUserActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildScheduledEventUser Discord.IEntityProvider<Discord.IGuildScheduledEventUser, Discord.Models.IGuildScheduledEventUserModel>.CreateEntity(Discord.Models.IGuildScheduledEventUserModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
