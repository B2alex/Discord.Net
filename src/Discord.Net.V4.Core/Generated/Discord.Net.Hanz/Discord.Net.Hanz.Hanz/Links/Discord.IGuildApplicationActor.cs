using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationActor.Paged<TParams>,
        Discord.IGuildApplicationActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IApplication> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IApplication> Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IApplication> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IGuildApplicationActor.Paged<TParams>,
            IGuildApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationActor.Paged<TParams>,
            IGuildApplicationActor.Indexable,
            Discord.IApplicationActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IGuildApplicationActor.Paged<TParams>.Indexable,
                IGuildApplicationActor.Paged<TParams>.BackLink<TSource>,
                IGuildApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationActor.Paged<TPaged, TParams>,
        Discord.IGuildApplicationActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IGuildApplicationActor.Paged<TPaged, TParams>,
            IGuildApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationActor.Paged<TPaged, TParams>,
            IGuildApplicationActor.Indexable,
            Discord.IApplicationActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IGuildApplicationActor.Paged<TPaged, TParams>.Indexable,
                IGuildApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationActor.Defined,
        Discord.IGuildApplicationActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IGuildApplicationActor.Defined,
            IGuildApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationActor.Defined,
            IGuildApplicationActor.Indexable,
            Discord.IApplicationActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IGuildApplicationActor.Defined.Indexable,
                IGuildApplicationActor.Defined.BackLink<TSource>,
                IGuildApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildApplicationActor.Defined,
            IGuildApplicationActor.Enumerable,
            Discord.IApplicationActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IGuildApplicationActor.Defined.Enumerable,
                IGuildApplicationActor.Defined.BackLink<TSource>,
                IGuildApplicationActor.Enumerable.BackLink<TSource>,
                Discord.IApplicationActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildApplicationActor.Defined.Enumerable,
                IGuildApplicationActor.Defined.Indexable,
                IGuildApplicationActor.Enumerable.Indexable,
                Discord.IApplicationActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IGuildApplicationActor.Defined.Enumerable.Indexable,
                    IGuildApplicationActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildApplicationActor.Defined.Indexable.BackLink<TSource>,
                    IGuildApplicationActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IApplicationActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationActor.Enumerable,
        Discord.IGuildApplicationActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IApplication>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IApplication>> Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IApplication>> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IGuildApplicationActor.Enumerable,
            IGuildApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationActor.Enumerable,
            IGuildApplicationActor.Indexable,
            Discord.IApplicationActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IGuildApplicationActor.Enumerable.Indexable,
                IGuildApplicationActor.Enumerable.BackLink<TSource>,
                IGuildApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationActor.Indexable,
        Discord.IGuildApplicationActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable
    {
        internal new Discord.IGuildApplicationActor this[Discord.IIdentifiable<ulong, Discord.IApplication, Discord.IGuildApplicationActor, Discord.Models.IApplicationModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildApplicationActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildApplicationActor, ulong>).GetActor(id);
    
        Discord.IApplicationActor Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildApplicationActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildApplicationActor, ulong>).GetActor(id);
    
        Discord.IApplicationActor Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IGuildApplicationActor.Indexable,
            IGuildApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
        Discord.IApplicationActor.BackLink<TSource>,
        Discord.IGuildApplicationActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
        Discord.IApplicationActor.Link
    {
        Discord.IGuildApplicationActor Discord.IActorProvider<Discord.IGuildApplicationActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplication Discord.IEntityProvider<Discord.IApplication, Discord.Models.IApplicationModel>.CreateEntity(Discord.Models.IApplicationModel model) => CreateEntity(model);
    
        Discord.IApplicationActor Discord.IApplicationActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplication Discord.IApplicationActor.Link.CreateEntity(Discord.Models.IApplicationModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
