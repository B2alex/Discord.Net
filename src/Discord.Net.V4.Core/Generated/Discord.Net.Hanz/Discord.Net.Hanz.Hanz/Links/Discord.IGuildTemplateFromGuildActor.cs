using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildTemplateFromGuildActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildTemplateActor.Paged<TParams>,
        Discord.IGuildTemplateFromGuildActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildTemplate> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildTemplate> Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildTemplate> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateFromGuildActor.Paged<TParams>,
            IGuildTemplateFromGuildActor.BackLink<TSource>,
            Discord.IGuildTemplateActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateFromGuildActor.Paged<TParams>,
            IGuildTemplateFromGuildActor.Indexable,
            Discord.IGuildTemplateActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateFromGuildActor.Paged<TParams>.Indexable,
                IGuildTemplateFromGuildActor.Paged<TParams>.BackLink<TSource>,
                IGuildTemplateFromGuildActor.Indexable.BackLink<TSource>,
                Discord.IGuildTemplateActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildTemplateActor.Paged<TPaged, TParams>,
        Discord.IGuildTemplateFromGuildActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateFromGuildActor.Paged<TPaged, TParams>,
            IGuildTemplateFromGuildActor.BackLink<TSource>,
            Discord.IGuildTemplateActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateFromGuildActor.Paged<TPaged, TParams>,
            IGuildTemplateFromGuildActor.Indexable,
            Discord.IGuildTemplateActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateFromGuildActor.Paged<TPaged, TParams>.Indexable,
                IGuildTemplateFromGuildActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildTemplateFromGuildActor.Indexable.BackLink<TSource>,
                Discord.IGuildTemplateActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildTemplateActor.Defined,
        Discord.IGuildTemplateFromGuildActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Defined.Ids => Ids;
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateFromGuildActor.Defined,
            IGuildTemplateFromGuildActor.BackLink<TSource>,
            Discord.IGuildTemplateActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateFromGuildActor.Defined,
            IGuildTemplateFromGuildActor.Indexable,
            Discord.IGuildTemplateActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateFromGuildActor.Defined.Indexable,
                IGuildTemplateFromGuildActor.Defined.BackLink<TSource>,
                IGuildTemplateFromGuildActor.Indexable.BackLink<TSource>,
                Discord.IGuildTemplateActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildTemplateFromGuildActor.Defined,
            IGuildTemplateFromGuildActor.Enumerable,
            Discord.IGuildTemplateActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateFromGuildActor.Defined.Enumerable,
                IGuildTemplateFromGuildActor.Defined.BackLink<TSource>,
                IGuildTemplateFromGuildActor.Enumerable.BackLink<TSource>,
                Discord.IGuildTemplateActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildTemplateFromGuildActor.Defined.Enumerable,
                IGuildTemplateFromGuildActor.Defined.Indexable,
                IGuildTemplateFromGuildActor.Enumerable.Indexable,
                Discord.IGuildTemplateActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                    IGuildTemplateFromGuildActor.Defined.Enumerable.Indexable,
                    IGuildTemplateFromGuildActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildTemplateFromGuildActor.Defined.Indexable.BackLink<TSource>,
                    IGuildTemplateFromGuildActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildTemplateActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildTemplateActor.Enumerable,
        Discord.IGuildTemplateFromGuildActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildTemplate>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildTemplate>> Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildTemplate>> Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateFromGuildActor.Enumerable,
            IGuildTemplateFromGuildActor.BackLink<TSource>,
            Discord.IGuildTemplateActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildTemplateFromGuildActor.Enumerable,
            IGuildTemplateFromGuildActor.Indexable,
            Discord.IGuildTemplateActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
                IGuildTemplateFromGuildActor.Enumerable.Indexable,
                IGuildTemplateFromGuildActor.Enumerable.BackLink<TSource>,
                IGuildTemplateFromGuildActor.Indexable.BackLink<TSource>,
                Discord.IGuildTemplateActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildTemplateActor.Indexable,
        Discord.IGuildTemplateFromGuildActor.Link,
        Discord.ILinkType<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Indexable
    {
        internal new Discord.IGuildTemplateFromGuildActor this[Discord.IIdentifiable<string, Discord.IGuildTemplate, Discord.IGuildTemplateFromGuildActor, Discord.Models.IGuildTemplateModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildTemplateFromGuildActor this[string id] => (this as Discord.IActorProvider<Discord.IGuildTemplateFromGuildActor, string>).GetActor(id);
    
        Discord.IGuildTemplateActor Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Indexable.this[string id] => this[id];
    
    
        new Discord.IGuildTemplateFromGuildActor Specifically(string id) => (this as Discord.IActorProvider<Discord.IGuildTemplateFromGuildActor, string>).GetActor(id);
    
        Discord.IGuildTemplateActor Discord.ILinkType<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.Indexable.Specifically(string id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
            IGuildTemplateFromGuildActor.Indexable,
            IGuildTemplateFromGuildActor.BackLink<TSource>,
            Discord.IGuildTemplateActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
        Discord.IGuildTemplateActor.BackLink<TSource>,
        Discord.IGuildTemplateFromGuildActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>,
        Discord.IGuildTemplateActor.Link
    {
        Discord.IGuildTemplateFromGuildActor Discord.IActorProvider<Discord.IGuildTemplateFromGuildActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IGuildTemplate Discord.IEntityProvider<Discord.IGuildTemplate, Discord.Models.IGuildTemplateModel>.CreateEntity(Discord.Models.IGuildTemplateModel model) => CreateEntity(model);
    
        Discord.IGuildTemplateActor Discord.IGuildTemplateActor.Link.GetActor(string id) => GetActor(id);
    
        Discord.IGuildTemplate Discord.IGuildTemplateActor.Link.CreateEntity(Discord.Models.IGuildTemplateModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
