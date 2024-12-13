using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildInviteActor
{
    public new interface Paged<in TParams> : 
        Discord.IInviteActor.Paged<TParams>,
        Discord.IGuildInviteActor.Link,
        Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildInvite> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildInvite> Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IInvite> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
            IGuildInviteActor.Paged<TParams>,
            IGuildInviteActor.BackLink<TSource>,
            Discord.IInviteActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildInviteActor.Paged<TParams>,
            IGuildInviteActor.Indexable,
            Discord.IInviteActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                IGuildInviteActor.Paged<TParams>.Indexable,
                IGuildInviteActor.Paged<TParams>.BackLink<TSource>,
                IGuildInviteActor.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInviteActor.Paged<TPaged, TParams>,
        Discord.IGuildInviteActor.Link,
        Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
            IGuildInviteActor.Paged<TPaged, TParams>,
            IGuildInviteActor.BackLink<TSource>,
            Discord.IInviteActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildInviteActor.Paged<TPaged, TParams>,
            IGuildInviteActor.Indexable,
            Discord.IInviteActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                IGuildInviteActor.Paged<TPaged, TParams>.Indexable,
                IGuildInviteActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildInviteActor.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInviteActor.Defined,
        Discord.IGuildInviteActor.Link,
        Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Defined.Ids => Ids;
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
            IGuildInviteActor.Defined,
            IGuildInviteActor.BackLink<TSource>,
            Discord.IInviteActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildInviteActor.Defined,
            IGuildInviteActor.Indexable,
            Discord.IInviteActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                IGuildInviteActor.Defined.Indexable,
                IGuildInviteActor.Defined.BackLink<TSource>,
                IGuildInviteActor.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildInviteActor.Defined,
            IGuildInviteActor.Enumerable,
            Discord.IInviteActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                IGuildInviteActor.Defined.Enumerable,
                IGuildInviteActor.Defined.BackLink<TSource>,
                IGuildInviteActor.Enumerable.BackLink<TSource>,
                Discord.IInviteActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildInviteActor.Defined.Enumerable,
                IGuildInviteActor.Defined.Indexable,
                IGuildInviteActor.Enumerable.Indexable,
                Discord.IInviteActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                    IGuildInviteActor.Defined.Enumerable.Indexable,
                    IGuildInviteActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildInviteActor.Defined.Indexable.BackLink<TSource>,
                    IGuildInviteActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IInviteActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInviteActor.Enumerable,
        Discord.IGuildInviteActor.Link,
        Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildInvite>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildInvite>> Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IInvite>> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
            IGuildInviteActor.Enumerable,
            IGuildInviteActor.BackLink<TSource>,
            Discord.IInviteActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildInviteActor.Enumerable,
            IGuildInviteActor.Indexable,
            Discord.IInviteActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
                IGuildInviteActor.Enumerable.Indexable,
                IGuildInviteActor.Enumerable.BackLink<TSource>,
                IGuildInviteActor.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInviteActor.Indexable,
        Discord.IGuildInviteActor.Link,
        Discord.ILinkType<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>.Indexable
    {
        internal new Discord.IGuildInviteActor this[Discord.IIdentifiable<string, Discord.IGuildInvite, Discord.IGuildInviteActor, Discord.Models.IInviteModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildInviteActor this[string id] => (this as Discord.IActorProvider<Discord.IGuildInviteActor, string>).GetActor(id);
    
        Discord.IInviteActor Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Indexable.this[string id] => this[id];
    
    
        new Discord.IGuildInviteActor Specifically(string id) => (this as Discord.IActorProvider<Discord.IGuildInviteActor, string>).GetActor(id);
    
        Discord.IInviteActor Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Indexable.Specifically(string id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
            IGuildInviteActor.Indexable,
            IGuildInviteActor.BackLink<TSource>,
            Discord.IInviteActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
        Discord.IInviteActor.BackLink<TSource>,
        Discord.IGuildInviteActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildInviteActor, string, Discord.IGuildInvite, Discord.Models.IInviteModel>,
        Discord.IInviteActor.Link
    {
        Discord.IGuildInviteActor Discord.IActorProvider<Discord.IGuildInviteActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IGuildInvite Discord.IEntityProvider<Discord.IGuildInvite, Discord.Models.IInviteModel>.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    
        Discord.IInviteActor Discord.IInviteActor.Link.GetActor(string id) => GetActor(id);
    
        Discord.IInvite Discord.IInviteActor.Link.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
