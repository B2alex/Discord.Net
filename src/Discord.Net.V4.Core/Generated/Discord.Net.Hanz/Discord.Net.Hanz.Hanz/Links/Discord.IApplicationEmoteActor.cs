using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationEmoteActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationEmoteActor.Link,
        Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IApplicationEmote> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IApplicationEmote> Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
            IApplicationEmoteActor.Paged<TParams>,
            IApplicationEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationEmoteActor.Paged<TParams>,
            IApplicationEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                IApplicationEmoteActor.Paged<TParams>.Indexable,
                IApplicationEmoteActor.Paged<TParams>.BackLink<TSource>,
                IApplicationEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationEmoteActor.Link,
        Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
            IApplicationEmoteActor.Paged<TPaged, TParams>,
            IApplicationEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationEmoteActor.Paged<TPaged, TParams>,
            IApplicationEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                IApplicationEmoteActor.Paged<TPaged, TParams>.Indexable,
                IApplicationEmoteActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IApplicationEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationEmoteActor.Link,
        Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
            IApplicationEmoteActor.Defined,
            IApplicationEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationEmoteActor.Defined,
            IApplicationEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                IApplicationEmoteActor.Defined.Indexable,
                IApplicationEmoteActor.Defined.BackLink<TSource>,
                IApplicationEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IApplicationEmoteActor.Defined,
            IApplicationEmoteActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                IApplicationEmoteActor.Defined.Enumerable,
                IApplicationEmoteActor.Defined.BackLink<TSource>,
                IApplicationEmoteActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IApplicationEmoteActor.Defined.Enumerable,
                IApplicationEmoteActor.Defined.Indexable,
                IApplicationEmoteActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                    IApplicationEmoteActor.Defined.Enumerable.Indexable,
                    IApplicationEmoteActor.Defined.Enumerable.BackLink<TSource>,
                    IApplicationEmoteActor.Defined.Indexable.BackLink<TSource>,
                    IApplicationEmoteActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationEmoteActor.Link,
        Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IApplicationEmote>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IApplicationEmote>> Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
            IApplicationEmoteActor.Enumerable,
            IApplicationEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationEmoteActor.Enumerable,
            IApplicationEmoteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
                IApplicationEmoteActor.Enumerable.Indexable,
                IApplicationEmoteActor.Enumerable.BackLink<TSource>,
                IApplicationEmoteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationEmoteActor.Link,
        Discord.ILinkType<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.Indexable
    {
        internal Discord.IApplicationEmoteActor this[Discord.IIdentifiable<ulong, Discord.IApplicationEmote, Discord.IApplicationEmoteActor, Discord.Models.ICustomEmoteModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
            IApplicationEmoteActor.Indexable,
            IApplicationEmoteActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>,
        Discord.IApplicationEmoteActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>
    {
        Discord.IApplicationEmoteActor Discord.IActorProvider<Discord.IApplicationEmoteActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IApplicationEmote Discord.IEntityProvider<Discord.IApplicationEmote, Discord.Models.ICustomEmoteModel>.CreateEntity(Discord.Models.ICustomEmoteModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
