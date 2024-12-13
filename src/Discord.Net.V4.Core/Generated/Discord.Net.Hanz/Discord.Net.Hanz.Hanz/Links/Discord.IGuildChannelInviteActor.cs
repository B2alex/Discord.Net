using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelInviteActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildInviteActor.Paged<TParams>,
        Discord.IInviteActor.Paged<TParams>,
        Discord.IGuildChannelInviteActor.Link,
        Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildChannelInvite> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildChannelInvite> Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IGuildInvite> Discord.IGuildInviteActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IInvite> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
            IGuildChannelInviteActor.Paged<TParams>,
            IGuildChannelInviteActor.BackLink<TSource>,
            Discord.IGuildInviteActor.Paged<TParams>.BackLink<TSource>,
            Discord.IInviteActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelInviteActor.Paged<TParams>,
            IGuildChannelInviteActor.Indexable,
            Discord.IGuildInviteActor.Paged<TParams>.Indexable,
            Discord.IInviteActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                IGuildChannelInviteActor.Paged<TParams>.Indexable,
                IGuildChannelInviteActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelInviteActor.Indexable.BackLink<TSource>,
                Discord.IGuildInviteActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildInviteActor.Paged<TPaged, TParams>,
        Discord.IInviteActor.Paged<TPaged, TParams>,
        Discord.IGuildChannelInviteActor.Link,
        Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IGuildInviteActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
            IGuildChannelInviteActor.Paged<TPaged, TParams>,
            IGuildChannelInviteActor.BackLink<TSource>,
            Discord.IGuildInviteActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IInviteActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelInviteActor.Paged<TPaged, TParams>,
            IGuildChannelInviteActor.Indexable,
            Discord.IGuildInviteActor.Paged<TPaged, TParams>.Indexable,
            Discord.IInviteActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                IGuildChannelInviteActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelInviteActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelInviteActor.Indexable.BackLink<TSource>,
                Discord.IGuildInviteActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildInviteActor.Defined,
        Discord.IInviteActor.Defined,
        Discord.IGuildChannelInviteActor.Link,
        Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Defined.Ids => Ids;
        IReadOnlyCollection<string> Discord.IGuildInviteActor.Defined.Ids => Ids;
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
            IGuildChannelInviteActor.Defined,
            IGuildChannelInviteActor.BackLink<TSource>,
            Discord.IGuildInviteActor.Defined.BackLink<TSource>,
            Discord.IInviteActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelInviteActor.Defined,
            IGuildChannelInviteActor.Indexable,
            Discord.IGuildInviteActor.Defined.Indexable,
            Discord.IInviteActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                IGuildChannelInviteActor.Defined.Indexable,
                IGuildChannelInviteActor.Defined.BackLink<TSource>,
                IGuildChannelInviteActor.Indexable.BackLink<TSource>,
                Discord.IGuildInviteActor.Defined.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildChannelInviteActor.Defined,
            IGuildChannelInviteActor.Enumerable,
            Discord.IGuildInviteActor.Defined.Enumerable,
            Discord.IInviteActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                IGuildChannelInviteActor.Defined.Enumerable,
                IGuildChannelInviteActor.Defined.BackLink<TSource>,
                IGuildChannelInviteActor.Enumerable.BackLink<TSource>,
                Discord.IGuildInviteActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IInviteActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildChannelInviteActor.Defined.Enumerable,
                IGuildChannelInviteActor.Defined.Indexable,
                IGuildChannelInviteActor.Enumerable.Indexable,
                Discord.IGuildInviteActor.Defined.Enumerable.Indexable,
                Discord.IInviteActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                    IGuildChannelInviteActor.Defined.Enumerable.Indexable,
                    IGuildChannelInviteActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelInviteActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelInviteActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IGuildInviteActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IInviteActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildInviteActor.Enumerable,
        Discord.IInviteActor.Enumerable,
        Discord.IGuildChannelInviteActor.Link,
        Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildChannelInvite>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannelInvite>> Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IGuildInvite>> Discord.IGuildInviteActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IInvite>> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
            IGuildChannelInviteActor.Enumerable,
            IGuildChannelInviteActor.BackLink<TSource>,
            Discord.IGuildInviteActor.Enumerable.BackLink<TSource>,
            Discord.IInviteActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelInviteActor.Enumerable,
            IGuildChannelInviteActor.Indexable,
            Discord.IGuildInviteActor.Enumerable.Indexable,
            Discord.IInviteActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
                IGuildChannelInviteActor.Enumerable.Indexable,
                IGuildChannelInviteActor.Enumerable.BackLink<TSource>,
                IGuildChannelInviteActor.Indexable.BackLink<TSource>,
                Discord.IGuildInviteActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IInviteActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildInviteActor.Indexable,
        Discord.IInviteActor.Indexable,
        Discord.IGuildChannelInviteActor.Link,
        Discord.ILinkType<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.Indexable
    {
        internal new Discord.IGuildChannelInviteActor this[Discord.IIdentifiable<string, Discord.IGuildChannelInvite, Discord.IGuildChannelInviteActor, Discord.Models.IInviteModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildChannelInviteActor this[string id] => (this as Discord.IActorProvider<Discord.IGuildChannelInviteActor, string>).GetActor(id);
    
        Discord.IGuildInviteActor Discord.IGuildInviteActor.Indexable.this[string id] => this[id];
    
        Discord.IInviteActor Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Indexable.this[string id] => this[id];
    
    
        new Discord.IGuildChannelInviteActor Specifically(string id) => (this as Discord.IActorProvider<Discord.IGuildChannelInviteActor, string>).GetActor(id);
    
        Discord.IGuildInviteActor Discord.IGuildInviteActor.Indexable.Specifically(string id) => Specifically(id);
    
        Discord.IInviteActor Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Indexable.Specifically(string id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
            IGuildChannelInviteActor.Indexable,
            IGuildChannelInviteActor.BackLink<TSource>,
            Discord.IGuildInviteActor.Indexable.BackLink<TSource>,
            Discord.IInviteActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
        Discord.IGuildInviteActor.BackLink<TSource>,
        Discord.IInviteActor.BackLink<TSource>,
        Discord.IGuildChannelInviteActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite, Discord.Models.IInviteModel>,
        Discord.IGuildInviteActor.Link,
        Discord.IInviteActor.Link
    {
        Discord.IGuildChannelInviteActor Discord.IActorProvider<Discord.IGuildChannelInviteActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IGuildChannelInvite Discord.IEntityProvider<Discord.IGuildChannelInvite, Discord.Models.IInviteModel>.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    
        Discord.IGuildInviteActor Discord.IGuildInviteActor.Link.GetActor(string id) => GetActor(id);
    
        Discord.IGuildInvite Discord.IGuildInviteActor.Link.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    
        Discord.IInviteActor Discord.IInviteActor.Link.GetActor(string id) => GetActor(id);
    
        Discord.IInvite Discord.IInviteActor.Link.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
