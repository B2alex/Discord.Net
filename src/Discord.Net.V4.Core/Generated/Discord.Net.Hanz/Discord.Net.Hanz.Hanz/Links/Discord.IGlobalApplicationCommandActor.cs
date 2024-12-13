using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGlobalApplicationCommandActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationCommandActor.Paged<TParams>,
        Discord.IGlobalApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGlobalApplicationCommand> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGlobalApplicationCommand> Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IApplicationCommand> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGlobalApplicationCommandActor.Paged<TParams>,
            IGlobalApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGlobalApplicationCommandActor.Paged<TParams>,
            IGlobalApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGlobalApplicationCommandActor.Paged<TParams>.Indexable,
                IGlobalApplicationCommandActor.Paged<TParams>.BackLink<TSource>,
                IGlobalApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationCommandActor.Paged<TPaged, TParams>,
        Discord.IGlobalApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGlobalApplicationCommandActor.Paged<TPaged, TParams>,
            IGlobalApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGlobalApplicationCommandActor.Paged<TPaged, TParams>,
            IGlobalApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGlobalApplicationCommandActor.Paged<TPaged, TParams>.Indexable,
                IGlobalApplicationCommandActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGlobalApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationCommandActor.Defined,
        Discord.IGlobalApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGlobalApplicationCommandActor.Defined,
            IGlobalApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGlobalApplicationCommandActor.Defined,
            IGlobalApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGlobalApplicationCommandActor.Defined.Indexable,
                IGlobalApplicationCommandActor.Defined.BackLink<TSource>,
                IGlobalApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGlobalApplicationCommandActor.Defined,
            IGlobalApplicationCommandActor.Enumerable,
            Discord.IApplicationCommandActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGlobalApplicationCommandActor.Defined.Enumerable,
                IGlobalApplicationCommandActor.Defined.BackLink<TSource>,
                IGlobalApplicationCommandActor.Enumerable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGlobalApplicationCommandActor.Defined.Enumerable,
                IGlobalApplicationCommandActor.Defined.Indexable,
                IGlobalApplicationCommandActor.Enumerable.Indexable,
                Discord.IApplicationCommandActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                    IGlobalApplicationCommandActor.Defined.Enumerable.Indexable,
                    IGlobalApplicationCommandActor.Defined.Enumerable.BackLink<TSource>,
                    IGlobalApplicationCommandActor.Defined.Indexable.BackLink<TSource>,
                    IGlobalApplicationCommandActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IApplicationCommandActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationCommandActor.Enumerable,
        Discord.IGlobalApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGlobalApplicationCommand>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGlobalApplicationCommand>> Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IApplicationCommand>> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGlobalApplicationCommandActor.Enumerable,
            IGlobalApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGlobalApplicationCommandActor.Enumerable,
            IGlobalApplicationCommandActor.Indexable,
            Discord.IApplicationCommandActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IGlobalApplicationCommandActor.Enumerable.Indexable,
                IGlobalApplicationCommandActor.Enumerable.BackLink<TSource>,
                IGlobalApplicationCommandActor.Indexable.BackLink<TSource>,
                Discord.IApplicationCommandActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationCommandActor.Indexable,
        Discord.IGlobalApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable
    {
        internal new Discord.IGlobalApplicationCommandActor this[Discord.IIdentifiable<ulong, Discord.IGlobalApplicationCommand, Discord.IGlobalApplicationCommandActor, Discord.Models.IApplicationCommandModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGlobalApplicationCommandActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGlobalApplicationCommandActor, ulong>).GetActor(id);
    
        Discord.IApplicationCommandActor Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGlobalApplicationCommandActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGlobalApplicationCommandActor, ulong>).GetActor(id);
    
        Discord.IApplicationCommandActor Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IGlobalApplicationCommandActor.Indexable,
            IGlobalApplicationCommandActor.BackLink<TSource>,
            Discord.IApplicationCommandActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
        Discord.IApplicationCommandActor.BackLink<TSource>,
        Discord.IGlobalApplicationCommandActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>,
        Discord.IApplicationCommandActor.Link
    {
        Discord.IGlobalApplicationCommandActor Discord.IActorProvider<Discord.IGlobalApplicationCommandActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGlobalApplicationCommand Discord.IEntityProvider<Discord.IGlobalApplicationCommand, Discord.Models.IApplicationCommandModel>.CreateEntity(Discord.Models.IApplicationCommandModel model) => CreateEntity(model);
    
        Discord.IApplicationCommandActor Discord.IApplicationCommandActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplicationCommand Discord.IApplicationCommandActor.Link.CreateEntity(Discord.Models.IApplicationCommandModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
