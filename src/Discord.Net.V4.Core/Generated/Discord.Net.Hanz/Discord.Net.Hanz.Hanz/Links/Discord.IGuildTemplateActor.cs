using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildTemplateActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildTemplateActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildTemplate> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildTemplate> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateActor.Paged<TParams>,
            IGuildTemplateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateActor.Paged<TParams>,
            IGuildTemplateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateActor.Paged<TParams>.Indexable,
                IGuildTemplateActor.Paged<TParams>.BackLink<TSource>,
                IGuildTemplateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildTemplateActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateActor.Paged<TPaged, TParams>,
            IGuildTemplateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateActor.Paged<TPaged, TParams>,
            IGuildTemplateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateActor.Paged<TPaged, TParams>.Indexable,
                IGuildTemplateActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildTemplateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildTemplateActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateActor.Defined,
            IGuildTemplateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateActor.Defined,
            IGuildTemplateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateActor.Defined.Indexable,
                IGuildTemplateActor.Defined.BackLink<TSource>,
                IGuildTemplateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildTemplateActor.Defined,
            IGuildTemplateActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateActor.Defined.Enumerable,
                IGuildTemplateActor.Defined.BackLink<TSource>,
                IGuildTemplateActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildTemplateActor.Defined.Enumerable,
                IGuildTemplateActor.Defined.Indexable,
                IGuildTemplateActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                    IGuildTemplateActor.Defined.Enumerable.Indexable,
                    IGuildTemplateActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildTemplateActor.Defined.Indexable.BackLink<TSource>,
                    IGuildTemplateActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildTemplateActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildTemplate>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildTemplate>> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateActor.Enumerable,
            IGuildTemplateActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateActor.Enumerable,
            IGuildTemplateActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateActor.Enumerable.Indexable,
                IGuildTemplateActor.Enumerable.BackLink<TSource>,
                IGuildTemplateActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildTemplateActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Indexable
    {
        internal Discord.IGuildTemplateActor this[Discord.IIdentifiable<string, Discord.IGuildTemplate, Discord.IGuildTemplateActor, Discord.Models.IGuildTemplateModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateActor.Indexable,
            IGuildTemplateActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
        Discord.IGuildTemplateActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>
    {
        Discord.IGuildTemplateActor Discord.IActorProvider<Discord.IGuildTemplateActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IGuildTemplate Discord.IEntityProvider<Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.CreateEntity(Discord.Models.IGuildTemplateModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
