using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IVoiceStateActor
{
    public new interface Paged<in TParams> : 
        Discord.IVoiceStateActor.Link,
        Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IVoiceState> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IVoiceState> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
            IVoiceStateActor.Paged<TParams>,
            IVoiceStateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceStateActor.Paged<TParams>,
            IVoiceStateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                IVoiceStateActor.Paged<TParams>.Indexable,
                IVoiceStateActor.Paged<TParams>.BackLink<TSource>,
                IVoiceStateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IVoiceStateActor.Link,
        Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
            IVoiceStateActor.Paged<TPaged, TParams>,
            IVoiceStateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceStateActor.Paged<TPaged, TParams>,
            IVoiceStateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                IVoiceStateActor.Paged<TPaged, TParams>.Indexable,
                IVoiceStateActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IVoiceStateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IVoiceStateActor.Link,
        Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
            IVoiceStateActor.Defined,
            IVoiceStateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceStateActor.Defined,
            IVoiceStateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                IVoiceStateActor.Defined.Indexable,
                IVoiceStateActor.Defined.BackLink<TSource>,
                IVoiceStateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IVoiceStateActor.Defined,
            IVoiceStateActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                IVoiceStateActor.Defined.Enumerable,
                IVoiceStateActor.Defined.BackLink<TSource>,
                IVoiceStateActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IVoiceStateActor.Defined.Enumerable,
                IVoiceStateActor.Defined.Indexable,
                IVoiceStateActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                    IVoiceStateActor.Defined.Enumerable.Indexable,
                    IVoiceStateActor.Defined.Enumerable.BackLink<TSource>,
                    IVoiceStateActor.Defined.Indexable.BackLink<TSource>,
                    IVoiceStateActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IVoiceStateActor.Link,
        Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IVoiceState>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IVoiceState>> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
            IVoiceStateActor.Enumerable,
            IVoiceStateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IVoiceStateActor.Enumerable,
            IVoiceStateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
                IVoiceStateActor.Enumerable.Indexable,
                IVoiceStateActor.Enumerable.BackLink<TSource>,
                IVoiceStateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IVoiceStateActor.Link,
        Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Indexable
    {
        internal Discord.IVoiceStateActor this[Discord.IIdentifiable<ulong, Discord.IVoiceState, Discord.IVoiceStateActor, Discord.Models.IVoiceStateModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
            IVoiceStateActor.Indexable,
            IVoiceStateActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>,
        Discord.IVoiceStateActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>
    {
        Discord.IVoiceStateActor Discord.IActorProvider<Discord.IVoiceStateActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IVoiceState Discord.IEntityProvider<Discord.IVoiceState, Discord.Models.IVoiceStateModel>.CreateEntity(Discord.Models.IVoiceStateModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
