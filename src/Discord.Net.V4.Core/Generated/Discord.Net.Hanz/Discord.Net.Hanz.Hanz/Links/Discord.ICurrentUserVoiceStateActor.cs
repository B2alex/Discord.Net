using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentUserVoiceStateActor
{
    public new interface Paged<in TParams> : 
        Discord.IVoiceStateActor.Paged<TParams>,
        Discord.ICurrentUserVoiceStateActor.Link,
        Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ICurrentUserVoiceState> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ICurrentUserVoiceState> Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IVoiceState> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
            ICurrentUserVoiceStateActor.Paged<TParams>,
            ICurrentUserVoiceStateActor.BackLink<TSource>,
            Discord.IVoiceStateActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserVoiceStateActor.Paged<TParams>,
            ICurrentUserVoiceStateActor.Indexable,
            Discord.IVoiceStateActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                ICurrentUserVoiceStateActor.Paged<TParams>.Indexable,
                ICurrentUserVoiceStateActor.Paged<TParams>.BackLink<TSource>,
                ICurrentUserVoiceStateActor.Indexable.BackLink<TSource>,
                Discord.IVoiceStateActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IVoiceStateActor.Paged<TPaged, TParams>,
        Discord.ICurrentUserVoiceStateActor.Link,
        Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
            ICurrentUserVoiceStateActor.Paged<TPaged, TParams>,
            ICurrentUserVoiceStateActor.BackLink<TSource>,
            Discord.IVoiceStateActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserVoiceStateActor.Paged<TPaged, TParams>,
            ICurrentUserVoiceStateActor.Indexable,
            Discord.IVoiceStateActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                ICurrentUserVoiceStateActor.Paged<TPaged, TParams>.Indexable,
                ICurrentUserVoiceStateActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ICurrentUserVoiceStateActor.Indexable.BackLink<TSource>,
                Discord.IVoiceStateActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IVoiceStateActor.Defined,
        Discord.ICurrentUserVoiceStateActor.Link,
        Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
            ICurrentUserVoiceStateActor.Defined,
            ICurrentUserVoiceStateActor.BackLink<TSource>,
            Discord.IVoiceStateActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserVoiceStateActor.Defined,
            ICurrentUserVoiceStateActor.Indexable,
            Discord.IVoiceStateActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                ICurrentUserVoiceStateActor.Defined.Indexable,
                ICurrentUserVoiceStateActor.Defined.BackLink<TSource>,
                ICurrentUserVoiceStateActor.Indexable.BackLink<TSource>,
                Discord.IVoiceStateActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ICurrentUserVoiceStateActor.Defined,
            ICurrentUserVoiceStateActor.Enumerable,
            Discord.IVoiceStateActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                ICurrentUserVoiceStateActor.Defined.Enumerable,
                ICurrentUserVoiceStateActor.Defined.BackLink<TSource>,
                ICurrentUserVoiceStateActor.Enumerable.BackLink<TSource>,
                Discord.IVoiceStateActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ICurrentUserVoiceStateActor.Defined.Enumerable,
                ICurrentUserVoiceStateActor.Defined.Indexable,
                ICurrentUserVoiceStateActor.Enumerable.Indexable,
                Discord.IVoiceStateActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                    ICurrentUserVoiceStateActor.Defined.Enumerable.Indexable,
                    ICurrentUserVoiceStateActor.Defined.Enumerable.BackLink<TSource>,
                    ICurrentUserVoiceStateActor.Defined.Indexable.BackLink<TSource>,
                    ICurrentUserVoiceStateActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IVoiceStateActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IVoiceStateActor.Enumerable,
        Discord.ICurrentUserVoiceStateActor.Link,
        Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ICurrentUserVoiceState>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ICurrentUserVoiceState>> Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IVoiceState>> Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
            ICurrentUserVoiceStateActor.Enumerable,
            ICurrentUserVoiceStateActor.BackLink<TSource>,
            Discord.IVoiceStateActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserVoiceStateActor.Enumerable,
            ICurrentUserVoiceStateActor.Indexable,
            Discord.IVoiceStateActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
                ICurrentUserVoiceStateActor.Enumerable.Indexable,
                ICurrentUserVoiceStateActor.Enumerable.BackLink<TSource>,
                ICurrentUserVoiceStateActor.Indexable.BackLink<TSource>,
                Discord.IVoiceStateActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IVoiceStateActor.Indexable,
        Discord.ICurrentUserVoiceStateActor.Link,
        Discord.ILinkType<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.Indexable
    {
        internal new Discord.ICurrentUserVoiceStateActor this[Discord.IIdentifiable<ulong, Discord.ICurrentUserVoiceState, Discord.ICurrentUserVoiceStateActor, Discord.Models.IVoiceStateModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ICurrentUserVoiceStateActor this[ulong id] => (this as Discord.IActorProvider<Discord.ICurrentUserVoiceStateActor, ulong>).GetActor(id);
    
        Discord.IVoiceStateActor Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ICurrentUserVoiceStateActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ICurrentUserVoiceStateActor, ulong>).GetActor(id);
    
        Discord.IVoiceStateActor Discord.ILinkType<Discord.IVoiceStateActor, ulong, Discord.IVoiceState, Discord.Models.IVoiceStateModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
            ICurrentUserVoiceStateActor.Indexable,
            ICurrentUserVoiceStateActor.BackLink<TSource>,
            Discord.IVoiceStateActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
        Discord.IVoiceStateActor.BackLink<TSource>,
        Discord.ICurrentUserVoiceStateActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>,
        Discord.IVoiceStateActor.Link
    {
        Discord.ICurrentUserVoiceStateActor Discord.IActorProvider<Discord.ICurrentUserVoiceStateActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ICurrentUserVoiceState Discord.IEntityProvider<Discord.ICurrentUserVoiceState, Discord.Models.IVoiceStateModel>.CreateEntity(Discord.Models.IVoiceStateModel model) => CreateEntity(model);
    
        Discord.IVoiceStateActor Discord.IVoiceStateActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IVoiceState Discord.IVoiceStateActor.Link.CreateEntity(Discord.Models.IVoiceStateModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
