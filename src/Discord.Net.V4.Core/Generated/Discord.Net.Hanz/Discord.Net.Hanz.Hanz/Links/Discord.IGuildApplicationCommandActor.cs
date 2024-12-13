using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationCommandActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationCommandActor.Paged<TParams>,
        Discord.IGuildApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildApplicationCommand> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildApplicationCommand> Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IApplicationCommand> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGuildApplicationCommandActor.Paged<TParams>,
            IGuildApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandActor.Paged<TParams>,
            IGuildApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGuildApplicationCommandActor.Paged<TParams>.Indexable,
                IGuildApplicationCommandActor.Paged<TParams>.BackLink<TSource>,
                IGuildApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationCommandActor.Paged<TPaged, TParams>,
        Discord.IGuildApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGuildApplicationCommandActor.Paged<TPaged, TParams>,
            IGuildApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandActor.Paged<TPaged, TParams>,
            IGuildApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGuildApplicationCommandActor.Paged<TPaged, TParams>.Indexable,
                IGuildApplicationCommandActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationCommandActor.Defined,
        Discord.IGuildApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGuildApplicationCommandActor.Defined,
            IGuildApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandActor.Defined,
            IGuildApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGuildApplicationCommandActor.Defined.Indexable,
                IGuildApplicationCommandActor.Defined.BackLink<TSource>,
                IGuildApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildApplicationCommandActor.Defined,
            IGuildApplicationCommandActor.Enumerable,
            Discord.IApplicationCommandActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGuildApplicationCommandActor.Defined.Enumerable,
                IGuildApplicationCommandActor.Defined.BackLink<TSource>,
                IGuildApplicationCommandActor.Enumerable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildApplicationCommandActor.Defined.Enumerable,
                IGuildApplicationCommandActor.Defined.Indexable,
                IGuildApplicationCommandActor.Enumerable.Indexable,
                Discord.IApplicationCommandActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                    IGuildApplicationCommandActor.Defined.Enumerable.Indexable,
                    IGuildApplicationCommandActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildApplicationCommandActor.Defined.Indexable.BackLink<TSource>,
                    IGuildApplicationCommandActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IApplicationCommandActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationCommandActor.Enumerable,
        Discord.IGuildApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildApplicationCommand>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildApplicationCommand>> Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IApplicationCommand>> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGuildApplicationCommandActor.Enumerable,
            IGuildApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandActor.Enumerable,
            IGuildApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGuildApplicationCommandActor.Enumerable.Indexable,
                IGuildApplicationCommandActor.Enumerable.BackLink<TSource>,
                IGuildApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationCommandActor.Indexable,
        Discord.IGuildApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable
    {
        internal new Discord.IGuildApplicationCommandActor this[Discord.IIdentifiable<ulong, Discord.IGuildApplicationCommand, Discord.IGuildApplicationCommandActor, Discord.Models.IApplicationCommandModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildApplicationCommandActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildApplicationCommandActor, ulong>).GetActor(id);
    
        Discord.IApplicationCommandActor Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildApplicationCommandActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildApplicationCommandActor, ulong>).GetActor(id);
    
        Discord.IApplicationCommandActor Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGuildApplicationCommandActor.Indexable,
            IGuildApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
        Discord.IApplicationCommandActor.BackLink<TSource>,
        Discord.IGuildApplicationCommandActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>,
        Discord.IApplicationCommandActor.Link
    {
        Discord.IGuildApplicationCommandActor Discord.IActorProvider<Discord.IGuildApplicationCommandActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildApplicationCommand Discord.IEntityProvider<Discord.IGuildApplicationCommand, Discord.Models.IApplicationCommandModel>.CreateEntity(Discord.Models.IApplicationCommandModel model) => CreateEntity(model);
    
        Discord.IApplicationCommandActor Discord.IApplicationCommandActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplicationCommand Discord.IApplicationCommandActor.Link.CreateEntity(Discord.Models.IApplicationCommandModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
