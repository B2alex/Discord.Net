using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildEmoteActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildEmoteActor.Link,
        Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildEmote> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildEmote> Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
            IGuildEmoteActor.Paged<TParams>,
            IGuildEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildEmoteActor.Paged<TParams>,
            IGuildEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                IGuildEmoteActor.Paged<TParams>.Indexable,
                IGuildEmoteActor.Paged<TParams>.BackLink<TSource>,
                IGuildEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildEmoteActor.Link,
        Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
            IGuildEmoteActor.Paged<TPaged, TParams>,
            IGuildEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildEmoteActor.Paged<TPaged, TParams>,
            IGuildEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                IGuildEmoteActor.Paged<TPaged, TParams>.Indexable,
                IGuildEmoteActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildEmoteActor.Link,
        Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
            IGuildEmoteActor.Defined,
            IGuildEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildEmoteActor.Defined,
            IGuildEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                IGuildEmoteActor.Defined.Indexable,
                IGuildEmoteActor.Defined.BackLink<TSource>,
                IGuildEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildEmoteActor.Defined,
            IGuildEmoteActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                IGuildEmoteActor.Defined.Enumerable,
                IGuildEmoteActor.Defined.BackLink<TSource>,
                IGuildEmoteActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildEmoteActor.Defined.Enumerable,
                IGuildEmoteActor.Defined.Indexable,
                IGuildEmoteActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                    IGuildEmoteActor.Defined.Enumerable.Indexable,
                    IGuildEmoteActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildEmoteActor.Defined.Indexable.BackLink<TSource>,
                    IGuildEmoteActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildEmoteActor.Link,
        Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildEmote>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildEmote>> Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
            IGuildEmoteActor.Enumerable,
            IGuildEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildEmoteActor.Enumerable,
            IGuildEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
                IGuildEmoteActor.Enumerable.Indexable,
                IGuildEmoteActor.Enumerable.BackLink<TSource>,
                IGuildEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildEmoteActor.Link,
        Discord.ILinkType<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.Indexable
    {
        internal Discord.IGuildEmoteActor this[Discord.IIdentifiable<ulong, Discord.IGuildEmote, Discord.IGuildEmoteActor, Discord.Models.ICustomEmoteModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
            IGuildEmoteActor.Indexable,
            IGuildEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>,
        Discord.IGuildEmoteActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>
    {
        Discord.IGuildEmoteActor Discord.IActorProvider<Discord.IGuildEmoteActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildEmote Discord.IEntityProvider<Discord.IGuildEmote, Discord.Models.ICustomEmoteModel>.CreateEntity(Discord.Models.ICustomEmoteModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
