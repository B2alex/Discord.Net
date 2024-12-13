using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStageInstanceActor
{
    public new interface Paged<in TParams> : 
        Discord.IStageInstanceActor.Link,
        Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IStageInstance> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IStageInstance> Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
            IStageInstanceActor.Paged<TParams>,
            IStageInstanceActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageInstanceActor.Paged<TParams>,
            IStageInstanceActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                IStageInstanceActor.Paged<TParams>.Indexable,
                IStageInstanceActor.Paged<TParams>.BackLink<TSource>,
                IStageInstanceActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IStageInstanceActor.Link,
        Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
            IStageInstanceActor.Paged<TPaged, TParams>,
            IStageInstanceActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageInstanceActor.Paged<TPaged, TParams>,
            IStageInstanceActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                IStageInstanceActor.Paged<TPaged, TParams>.Indexable,
                IStageInstanceActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IStageInstanceActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IStageInstanceActor.Link,
        Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
            IStageInstanceActor.Defined,
            IStageInstanceActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageInstanceActor.Defined,
            IStageInstanceActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                IStageInstanceActor.Defined.Indexable,
                IStageInstanceActor.Defined.BackLink<TSource>,
                IStageInstanceActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IStageInstanceActor.Defined,
            IStageInstanceActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                IStageInstanceActor.Defined.Enumerable,
                IStageInstanceActor.Defined.BackLink<TSource>,
                IStageInstanceActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IStageInstanceActor.Defined.Enumerable,
                IStageInstanceActor.Defined.Indexable,
                IStageInstanceActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                    IStageInstanceActor.Defined.Enumerable.Indexable,
                    IStageInstanceActor.Defined.Enumerable.BackLink<TSource>,
                    IStageInstanceActor.Defined.Indexable.BackLink<TSource>,
                    IStageInstanceActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IStageInstanceActor.Link,
        Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IStageInstance>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IStageInstance>> Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
            IStageInstanceActor.Enumerable,
            IStageInstanceActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IStageInstanceActor.Enumerable,
            IStageInstanceActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
                IStageInstanceActor.Enumerable.Indexable,
                IStageInstanceActor.Enumerable.BackLink<TSource>,
                IStageInstanceActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IStageInstanceActor.Link,
        Discord.ILinkType<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>.Indexable
    {
        internal Discord.IStageInstanceActor this[Discord.IIdentifiable<ulong, Discord.IStageInstance, Discord.IStageInstanceActor, Discord.Models.IStageInstanceModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
            IStageInstanceActor.Indexable,
            IStageInstanceActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>,
        Discord.IStageInstanceActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IStageInstanceActor, ulong, Discord.IStageInstance, Discord.Models.IStageInstanceModel>
    {
        Discord.IStageInstanceActor Discord.IActorProvider<Discord.IStageInstanceActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IStageInstance Discord.IEntityProvider<Discord.IStageInstance, Discord.Models.IStageInstanceModel>.CreateEntity(Discord.Models.IStageInstanceModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
