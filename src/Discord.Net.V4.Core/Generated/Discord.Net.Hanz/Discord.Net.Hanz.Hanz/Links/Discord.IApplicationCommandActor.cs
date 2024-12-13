using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationCommandActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IApplicationCommand> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IApplicationCommand> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IApplicationCommandActor.Paged<TParams>,
            IApplicationCommandActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationCommandActor.Paged<TParams>,
            IApplicationCommandActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IApplicationCommandActor.Paged<TParams>.Indexable,
                IApplicationCommandActor.Paged<TParams>.BackLink<TSource>,
                IApplicationCommandActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IApplicationCommandActor.Paged<TPaged, TParams>,
            IApplicationCommandActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationCommandActor.Paged<TPaged, TParams>,
            IApplicationCommandActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IApplicationCommandActor.Paged<TPaged, TParams>.Indexable,
                IApplicationCommandActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IApplicationCommandActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IApplicationCommandActor.Defined,
            IApplicationCommandActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationCommandActor.Defined,
            IApplicationCommandActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IApplicationCommandActor.Defined.Indexable,
                IApplicationCommandActor.Defined.BackLink<TSource>,
                IApplicationCommandActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IApplicationCommandActor.Defined,
            IApplicationCommandActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IApplicationCommandActor.Defined.Enumerable,
                IApplicationCommandActor.Defined.BackLink<TSource>,
                IApplicationCommandActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IApplicationCommandActor.Defined.Enumerable,
                IApplicationCommandActor.Defined.Indexable,
                IApplicationCommandActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                    IApplicationCommandActor.Defined.Enumerable.Indexable,
                    IApplicationCommandActor.Defined.Enumerable.BackLink<TSource>,
                    IApplicationCommandActor.Defined.Indexable.BackLink<TSource>,
                    IApplicationCommandActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IApplicationCommand>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IApplicationCommand>> Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IApplicationCommandActor.Enumerable,
            IApplicationCommandActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationCommandActor.Enumerable,
            IApplicationCommandActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
                IApplicationCommandActor.Enumerable.Indexable,
                IApplicationCommandActor.Enumerable.BackLink<TSource>,
                IApplicationCommandActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationCommandActor.Link,
        Discord.ILinkType<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.Indexable
    {
        internal Discord.IApplicationCommandActor this[Discord.IIdentifiable<ulong, Discord.IApplicationCommand, Discord.IApplicationCommandActor, Discord.Models.IApplicationCommandModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
            IApplicationCommandActor.Indexable,
            IApplicationCommandActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>,
        Discord.IApplicationCommandActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>
    {
        Discord.IApplicationCommandActor Discord.IActorProvider<Discord.IApplicationCommandActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplicationCommand Discord.IEntityProvider<Discord.IApplicationCommand, Discord.Models.IApplicationCommandModel>.CreateEntity(Discord.Models.IApplicationCommandModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
