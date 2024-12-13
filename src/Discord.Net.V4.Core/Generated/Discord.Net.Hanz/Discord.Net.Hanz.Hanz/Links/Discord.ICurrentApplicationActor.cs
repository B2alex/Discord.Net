using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentApplicationActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationActor.Paged<TParams>,
        Discord.ICurrentApplicationActor.Link,
        Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ICurrentApplication> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ICurrentApplication> Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IApplication> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
            ICurrentApplicationActor.Paged<TParams>,
            ICurrentApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentApplicationActor.Paged<TParams>,
            ICurrentApplicationActor.Indexable,
            Discord.IApplicationActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                ICurrentApplicationActor.Paged<TParams>.Indexable,
                ICurrentApplicationActor.Paged<TParams>.BackLink<TSource>,
                ICurrentApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationActor.Paged<TPaged, TParams>,
        Discord.ICurrentApplicationActor.Link,
        Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
            ICurrentApplicationActor.Paged<TPaged, TParams>,
            ICurrentApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentApplicationActor.Paged<TPaged, TParams>,
            ICurrentApplicationActor.Indexable,
            Discord.IApplicationActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                ICurrentApplicationActor.Paged<TPaged, TParams>.Indexable,
                ICurrentApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ICurrentApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationActor.Defined,
        Discord.ICurrentApplicationActor.Link,
        Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
            ICurrentApplicationActor.Defined,
            ICurrentApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentApplicationActor.Defined,
            ICurrentApplicationActor.Indexable,
            Discord.IApplicationActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                ICurrentApplicationActor.Defined.Indexable,
                ICurrentApplicationActor.Defined.BackLink<TSource>,
                ICurrentApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ICurrentApplicationActor.Defined,
            ICurrentApplicationActor.Enumerable,
            Discord.IApplicationActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                ICurrentApplicationActor.Defined.Enumerable,
                ICurrentApplicationActor.Defined.BackLink<TSource>,
                ICurrentApplicationActor.Enumerable.BackLink<TSource>,
                Discord.IApplicationActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ICurrentApplicationActor.Defined.Enumerable,
                ICurrentApplicationActor.Defined.Indexable,
                ICurrentApplicationActor.Enumerable.Indexable,
                Discord.IApplicationActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                    ICurrentApplicationActor.Defined.Enumerable.Indexable,
                    ICurrentApplicationActor.Defined.Enumerable.BackLink<TSource>,
                    ICurrentApplicationActor.Defined.Indexable.BackLink<TSource>,
                    ICurrentApplicationActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IApplicationActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationActor.Enumerable,
        Discord.ICurrentApplicationActor.Link,
        Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ICurrentApplication>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ICurrentApplication>> Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IApplication>> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
            ICurrentApplicationActor.Enumerable,
            ICurrentApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentApplicationActor.Enumerable,
            ICurrentApplicationActor.Indexable,
            Discord.IApplicationActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
                ICurrentApplicationActor.Enumerable.Indexable,
                ICurrentApplicationActor.Enumerable.BackLink<TSource>,
                ICurrentApplicationActor.Indexable.BackLink<TSource>,
                Discord.IApplicationActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationActor.Indexable,
        Discord.ICurrentApplicationActor.Link,
        Discord.ILinkType<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>.Indexable
    {
        internal new Discord.ICurrentApplicationActor this[Discord.IIdentifiable<ulong, Discord.ICurrentApplication, Discord.ICurrentApplicationActor, Discord.Models.IApplicationModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ICurrentApplicationActor this[ulong id] => (this as Discord.IActorProvider<Discord.ICurrentApplicationActor, ulong>).GetActor(id);
    
        Discord.IApplicationActor Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ICurrentApplicationActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ICurrentApplicationActor, ulong>).GetActor(id);
    
        Discord.IApplicationActor Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
            ICurrentApplicationActor.Indexable,
            ICurrentApplicationActor.BackLink<TSource>,
            Discord.IApplicationActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
        Discord.IApplicationActor.BackLink<TSource>,
        Discord.ICurrentApplicationActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication, Discord.Models.IApplicationModel>,
        Discord.IApplicationActor.Link
    {
        Discord.ICurrentApplicationActor Discord.IActorProvider<Discord.ICurrentApplicationActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ICurrentApplication Discord.IEntityProvider<Discord.ICurrentApplication, Discord.Models.IApplicationModel>.CreateEntity(Discord.Models.IApplicationModel model) => CreateEntity(model);
    
        Discord.IApplicationActor Discord.IApplicationActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplication Discord.IApplicationActor.Link.CreateEntity(Discord.Models.IApplicationModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
