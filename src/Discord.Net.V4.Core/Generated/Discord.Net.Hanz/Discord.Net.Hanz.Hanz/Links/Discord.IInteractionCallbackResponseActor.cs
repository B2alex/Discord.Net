using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionCallbackResponseActor
{
    public new interface Paged<in TParams> : 
        Discord.IInteractionCallbackResponseActor.Link,
        Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IInteractionCallbackResponse> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IInteractionCallbackResponse> Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
            IInteractionCallbackResponseActor.Paged<TParams>,
            IInteractionCallbackResponseActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionCallbackResponseActor.Paged<TParams>,
            IInteractionCallbackResponseActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                IInteractionCallbackResponseActor.Paged<TParams>.Indexable,
                IInteractionCallbackResponseActor.Paged<TParams>.BackLink<TSource>,
                IInteractionCallbackResponseActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInteractionCallbackResponseActor.Link,
        Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
            IInteractionCallbackResponseActor.Paged<TPaged, TParams>,
            IInteractionCallbackResponseActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionCallbackResponseActor.Paged<TPaged, TParams>,
            IInteractionCallbackResponseActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                IInteractionCallbackResponseActor.Paged<TPaged, TParams>.Indexable,
                IInteractionCallbackResponseActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInteractionCallbackResponseActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInteractionCallbackResponseActor.Link,
        Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
            IInteractionCallbackResponseActor.Defined,
            IInteractionCallbackResponseActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionCallbackResponseActor.Defined,
            IInteractionCallbackResponseActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                IInteractionCallbackResponseActor.Defined.Indexable,
                IInteractionCallbackResponseActor.Defined.BackLink<TSource>,
                IInteractionCallbackResponseActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IInteractionCallbackResponseActor.Defined,
            IInteractionCallbackResponseActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                IInteractionCallbackResponseActor.Defined.Enumerable,
                IInteractionCallbackResponseActor.Defined.BackLink<TSource>,
                IInteractionCallbackResponseActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IInteractionCallbackResponseActor.Defined.Enumerable,
                IInteractionCallbackResponseActor.Defined.Indexable,
                IInteractionCallbackResponseActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                    IInteractionCallbackResponseActor.Defined.Enumerable.Indexable,
                    IInteractionCallbackResponseActor.Defined.Enumerable.BackLink<TSource>,
                    IInteractionCallbackResponseActor.Defined.Indexable.BackLink<TSource>,
                    IInteractionCallbackResponseActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInteractionCallbackResponseActor.Link,
        Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IInteractionCallbackResponse>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IInteractionCallbackResponse>> Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
            IInteractionCallbackResponseActor.Enumerable,
            IInteractionCallbackResponseActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionCallbackResponseActor.Enumerable,
            IInteractionCallbackResponseActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
                IInteractionCallbackResponseActor.Enumerable.Indexable,
                IInteractionCallbackResponseActor.Enumerable.BackLink<TSource>,
                IInteractionCallbackResponseActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInteractionCallbackResponseActor.Link,
        Discord.ILinkType<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.Indexable
    {
        internal Discord.IInteractionCallbackResponseActor this[Discord.IIdentifiable<ulong, Discord.IInteractionCallbackResponse, Discord.IInteractionCallbackResponseActor, Discord.Models.IInteractionCallbackResponseModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
            IInteractionCallbackResponseActor.Indexable,
            IInteractionCallbackResponseActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>,
        Discord.IInteractionCallbackResponseActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>
    {
        Discord.IInteractionCallbackResponseActor Discord.IActorProvider<Discord.IInteractionCallbackResponseActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IInteractionCallbackResponse Discord.IEntityProvider<Discord.IInteractionCallbackResponse, Discord.Models.IInteractionCallbackResponseModel>.CreateEntity(Discord.Models.IInteractionCallbackResponseModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
