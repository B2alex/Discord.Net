using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildActor
{
    public interface WithTemplates
    {
        Discord.IGuildTemplateActor.Indexable Templates { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.WithTemplates,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IGuildActor.Link,
        Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuild> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuild> Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithTemplates : 
            IGuildActor.Paged<TParams>,
            IGuildActor.WithTemplates
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Paged<TParams>.WithTemplates,
                IGuildActor.Paged<TParams>.BackLink<TSource>,
                IGuildActor.WithTemplates.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.Paged<TParams>,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildActor.Paged<TParams>,
            IGuildActor.Indexable
        {
            public interface WithTemplates : 
                IGuildActor.Paged<TParams>.Indexable,
                IGuildActor.Paged<TParams>.WithTemplates,
                IGuildActor.Indexable.WithTemplates
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Paged<TParams>.Indexable.WithTemplates,
                    IGuildActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IGuildActor.Paged<TParams>.WithTemplates.BackLink<TSource>,
                    IGuildActor.Indexable.WithTemplates.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Paged<TParams>.Indexable,
                IGuildActor.Paged<TParams>.BackLink<TSource>,
                IGuildActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildActor.Link,
        Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithTemplates : 
            IGuildActor.Paged<TPaged, TParams>,
            IGuildActor.WithTemplates
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Paged<TPaged, TParams>.WithTemplates,
                IGuildActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildActor.WithTemplates.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.Paged<TPaged, TParams>,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildActor.Paged<TPaged, TParams>,
            IGuildActor.Indexable
        {
            public interface WithTemplates : 
                IGuildActor.Paged<TPaged, TParams>.Indexable,
                IGuildActor.Paged<TPaged, TParams>.WithTemplates,
                IGuildActor.Indexable.WithTemplates
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Paged<TPaged, TParams>.Indexable.WithTemplates,
                    IGuildActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IGuildActor.Paged<TPaged, TParams>.WithTemplates.BackLink<TSource>,
                    IGuildActor.Indexable.WithTemplates.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Paged<TPaged, TParams>.Indexable,
                IGuildActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildActor.Link,
        Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Defined.Ids => Ids;
    
    
        public interface WithTemplates : 
            IGuildActor.Defined,
            IGuildActor.WithTemplates
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Defined.WithTemplates,
                IGuildActor.Defined.BackLink<TSource>,
                IGuildActor.WithTemplates.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.Defined,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildActor.Defined,
            IGuildActor.Indexable
        {
            public interface WithTemplates : 
                IGuildActor.Defined.Indexable,
                IGuildActor.Defined.WithTemplates,
                IGuildActor.Indexable.WithTemplates
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Defined.Indexable.WithTemplates,
                    IGuildActor.Defined.Indexable.BackLink<TSource>,
                    IGuildActor.Defined.WithTemplates.BackLink<TSource>,
                    IGuildActor.Indexable.WithTemplates.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Defined.Indexable,
                IGuildActor.Defined.BackLink<TSource>,
                IGuildActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildActor.Defined,
            IGuildActor.Enumerable
        {
            public interface WithTemplates : 
                IGuildActor.Defined.Enumerable,
                IGuildActor.Defined.WithTemplates,
                IGuildActor.Enumerable.WithTemplates
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Defined.Enumerable.WithTemplates,
                    IGuildActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildActor.Defined.WithTemplates.BackLink<TSource>,
                    IGuildActor.Enumerable.WithTemplates.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Defined.Enumerable,
                IGuildActor.Defined.BackLink<TSource>,
                IGuildActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildActor.Defined.Enumerable,
                IGuildActor.Defined.Indexable,
                IGuildActor.Enumerable.Indexable
            {
                public interface WithTemplates : 
                    IGuildActor.Defined.Enumerable.Indexable,
                    IGuildActor.Defined.Enumerable.WithTemplates,
                    IGuildActor.Defined.Indexable.WithTemplates,
                    IGuildActor.Enumerable.Indexable.WithTemplates
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                        IGuildActor.Defined.Enumerable.Indexable.WithTemplates,
                        IGuildActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IGuildActor.Defined.Enumerable.WithTemplates.BackLink<TSource>,
                        IGuildActor.Defined.Indexable.WithTemplates.BackLink<TSource>,
                        IGuildActor.Enumerable.Indexable.WithTemplates.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Defined.Enumerable.Indexable,
                    IGuildActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildActor.Defined.Indexable.BackLink<TSource>,
                    IGuildActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildActor.Link,
        Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuild>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuild>> Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithTemplates : 
            IGuildActor.Enumerable,
            IGuildActor.WithTemplates
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Enumerable.WithTemplates,
                IGuildActor.Enumerable.BackLink<TSource>,
                IGuildActor.WithTemplates.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.Enumerable,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildActor.Enumerable,
            IGuildActor.Indexable
        {
            public interface WithTemplates : 
                IGuildActor.Enumerable.Indexable,
                IGuildActor.Enumerable.WithTemplates,
                IGuildActor.Indexable.WithTemplates
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                    IGuildActor.Enumerable.Indexable.WithTemplates,
                    IGuildActor.Enumerable.Indexable.BackLink<TSource>,
                    IGuildActor.Enumerable.WithTemplates.BackLink<TSource>,
                    IGuildActor.Indexable.WithTemplates.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Enumerable.Indexable,
                IGuildActor.Enumerable.BackLink<TSource>,
                IGuildActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildActor.Link,
        Discord.ILinkType<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>.Indexable
    {
        internal Discord.IGuildActor this[Discord.IIdentifiable<ulong, Discord.IGuild, Discord.IGuildActor, Discord.Models.IGuildModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface WithTemplates : 
            IGuildActor.Indexable,
            IGuildActor.WithTemplates
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
                IGuildActor.Indexable.WithTemplates,
                IGuildActor.Indexable.BackLink<TSource>,
                IGuildActor.WithTemplates.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
            IGuildActor.Indexable,
            IGuildActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>,
        Discord.IGuildActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildActor, ulong, Discord.IGuild, Discord.Models.IGuildModel>
    {
        Discord.IGuildActor Discord.IActorProvider<Discord.IGuildActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuild Discord.IEntityProvider<Discord.IGuild, Discord.Models.IGuildModel>.CreateEntity(Discord.Models.IGuildModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
