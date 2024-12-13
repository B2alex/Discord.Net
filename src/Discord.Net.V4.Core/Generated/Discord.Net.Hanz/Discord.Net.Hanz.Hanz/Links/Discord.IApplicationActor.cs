using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationActor
{
    public interface WithCurrent
    {
        Discord.ICurrentApplicationActor Current { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.WithCurrent,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IApplicationActor.Link,
        Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IApplication> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IApplication> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IApplicationActor.Paged<TParams>,
            IApplicationActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Paged<TParams>.WithCurrent,
                IApplicationActor.Paged<TParams>.BackLink<TSource>,
                IApplicationActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.Paged<TParams>,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationActor.Paged<TParams>,
            IApplicationActor.Indexable
        {
            public interface WithCurrent : 
                IApplicationActor.Paged<TParams>.Indexable,
                IApplicationActor.Paged<TParams>.WithCurrent,
                IApplicationActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Paged<TParams>.Indexable.WithCurrent,
                    IApplicationActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IApplicationActor.Paged<TParams>.WithCurrent.BackLink<TSource>,
                    IApplicationActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Paged<TParams>.Indexable,
                IApplicationActor.Paged<TParams>.BackLink<TSource>,
                IApplicationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationActor.Link,
        Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IApplicationActor.Paged<TPaged, TParams>,
            IApplicationActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Paged<TPaged, TParams>.WithCurrent,
                IApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IApplicationActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.Paged<TPaged, TParams>,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationActor.Paged<TPaged, TParams>,
            IApplicationActor.Indexable
        {
            public interface WithCurrent : 
                IApplicationActor.Paged<TPaged, TParams>.Indexable,
                IApplicationActor.Paged<TPaged, TParams>.WithCurrent,
                IApplicationActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Paged<TPaged, TParams>.Indexable.WithCurrent,
                    IApplicationActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IApplicationActor.Paged<TPaged, TParams>.WithCurrent.BackLink<TSource>,
                    IApplicationActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Paged<TPaged, TParams>.Indexable,
                IApplicationActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IApplicationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationActor.Link,
        Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Defined.Ids => Ids;
    
    
        public interface WithCurrent : 
            IApplicationActor.Defined,
            IApplicationActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Defined.WithCurrent,
                IApplicationActor.Defined.BackLink<TSource>,
                IApplicationActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.Defined,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationActor.Defined,
            IApplicationActor.Indexable
        {
            public interface WithCurrent : 
                IApplicationActor.Defined.Indexable,
                IApplicationActor.Defined.WithCurrent,
                IApplicationActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Defined.Indexable.WithCurrent,
                    IApplicationActor.Defined.Indexable.BackLink<TSource>,
                    IApplicationActor.Defined.WithCurrent.BackLink<TSource>,
                    IApplicationActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Defined.Indexable,
                IApplicationActor.Defined.BackLink<TSource>,
                IApplicationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IApplicationActor.Defined,
            IApplicationActor.Enumerable
        {
            public interface WithCurrent : 
                IApplicationActor.Defined.Enumerable,
                IApplicationActor.Defined.WithCurrent,
                IApplicationActor.Enumerable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Defined.Enumerable.WithCurrent,
                    IApplicationActor.Defined.Enumerable.BackLink<TSource>,
                    IApplicationActor.Defined.WithCurrent.BackLink<TSource>,
                    IApplicationActor.Enumerable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Defined.Enumerable,
                IApplicationActor.Defined.BackLink<TSource>,
                IApplicationActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IApplicationActor.Defined.Enumerable,
                IApplicationActor.Defined.Indexable,
                IApplicationActor.Enumerable.Indexable
            {
                public interface WithCurrent : 
                    IApplicationActor.Defined.Enumerable.Indexable,
                    IApplicationActor.Defined.Enumerable.WithCurrent,
                    IApplicationActor.Defined.Indexable.WithCurrent,
                    IApplicationActor.Enumerable.Indexable.WithCurrent
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                        IApplicationActor.Defined.Enumerable.Indexable.WithCurrent,
                        IApplicationActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IApplicationActor.Defined.Enumerable.WithCurrent.BackLink<TSource>,
                        IApplicationActor.Defined.Indexable.WithCurrent.BackLink<TSource>,
                        IApplicationActor.Enumerable.Indexable.WithCurrent.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Defined.Enumerable.Indexable,
                    IApplicationActor.Defined.Enumerable.BackLink<TSource>,
                    IApplicationActor.Defined.Indexable.BackLink<TSource>,
                    IApplicationActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationActor.Link,
        Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IApplication>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IApplication>> Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithCurrent : 
            IApplicationActor.Enumerable,
            IApplicationActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Enumerable.WithCurrent,
                IApplicationActor.Enumerable.BackLink<TSource>,
                IApplicationActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.Enumerable,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationActor.Enumerable,
            IApplicationActor.Indexable
        {
            public interface WithCurrent : 
                IApplicationActor.Enumerable.Indexable,
                IApplicationActor.Enumerable.WithCurrent,
                IApplicationActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                    IApplicationActor.Enumerable.Indexable.WithCurrent,
                    IApplicationActor.Enumerable.Indexable.BackLink<TSource>,
                    IApplicationActor.Enumerable.WithCurrent.BackLink<TSource>,
                    IApplicationActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Enumerable.Indexable,
                IApplicationActor.Enumerable.BackLink<TSource>,
                IApplicationActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationActor.Link,
        Discord.ILinkType<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>.Indexable
    {
        internal Discord.IApplicationActor this[Discord.IIdentifiable<ulong, Discord.IApplication, Discord.IApplicationActor, Discord.Models.IApplicationModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface WithCurrent : 
            IApplicationActor.Indexable,
            IApplicationActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
                IApplicationActor.Indexable.WithCurrent,
                IApplicationActor.Indexable.BackLink<TSource>,
                IApplicationActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
            IApplicationActor.Indexable,
            IApplicationActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>,
        Discord.IApplicationActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IApplicationActor, ulong, Discord.IApplication, Discord.Models.IApplicationModel>
    {
        Discord.IApplicationActor Discord.IActorProvider<Discord.IApplicationActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplication Discord.IEntityProvider<Discord.IApplication, Discord.Models.IApplicationModel>.CreateEntity(Discord.Models.IApplicationModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
