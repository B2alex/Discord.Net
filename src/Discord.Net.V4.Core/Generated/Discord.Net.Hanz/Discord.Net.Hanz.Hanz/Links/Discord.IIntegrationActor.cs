using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIntegrationActor
{
    public new interface Paged<in TParams> : 
        Discord.IIntegrationActor.Link,
        Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IIntegration> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IIntegration> Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
            IIntegrationActor.Paged<TParams>,
            IIntegrationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationActor.Paged<TParams>,
            IIntegrationActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                IIntegrationActor.Paged<TParams>.Indexable,
                IIntegrationActor.Paged<TParams>.BackLink<TSource>,
                IIntegrationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IIntegrationActor.Link,
        Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
            IIntegrationActor.Paged<TPaged, TParams>,
            IIntegrationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationActor.Paged<TPaged, TParams>,
            IIntegrationActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                IIntegrationActor.Paged<TPaged, TParams>.Indexable,
                IIntegrationActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IIntegrationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IIntegrationActor.Link,
        Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
            IIntegrationActor.Defined,
            IIntegrationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationActor.Defined,
            IIntegrationActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                IIntegrationActor.Defined.Indexable,
                IIntegrationActor.Defined.BackLink<TSource>,
                IIntegrationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IIntegrationActor.Defined,
            IIntegrationActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                IIntegrationActor.Defined.Enumerable,
                IIntegrationActor.Defined.BackLink<TSource>,
                IIntegrationActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IIntegrationActor.Defined.Enumerable,
                IIntegrationActor.Defined.Indexable,
                IIntegrationActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                    IIntegrationActor.Defined.Enumerable.Indexable,
                    IIntegrationActor.Defined.Enumerable.BackLink<TSource>,
                    IIntegrationActor.Defined.Indexable.BackLink<TSource>,
                    IIntegrationActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IIntegrationActor.Link,
        Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IIntegration>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IIntegration>> Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
            IIntegrationActor.Enumerable,
            IIntegrationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationActor.Enumerable,
            IIntegrationActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
                IIntegrationActor.Enumerable.Indexable,
                IIntegrationActor.Enumerable.BackLink<TSource>,
                IIntegrationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IIntegrationActor.Link,
        Discord.ILinkType<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>.Indexable
    {
        internal Discord.IIntegrationActor this[Discord.IIdentifiable<ulong, Discord.IIntegration, Discord.IIntegrationActor, Discord.Models.IIntegrationModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
            IIntegrationActor.Indexable,
            IIntegrationActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>,
        Discord.IIntegrationActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IIntegrationActor, ulong, Discord.IIntegration, Discord.Models.IIntegrationModel>
    {
        Discord.IIntegrationActor Discord.IActorProvider<Discord.IIntegrationActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IIntegration Discord.IEntityProvider<Discord.IIntegration, Discord.Models.IIntegrationModel>.CreateEntity(Discord.Models.IIntegrationModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
