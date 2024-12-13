using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IReactionActor
{
    public new interface Paged<in TParams> : 
        Discord.IReactionActor.Link,
        Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IReaction> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IReaction> Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
            IReactionActor.Paged<TParams>,
            IReactionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IReactionActor.Paged<TParams>,
            IReactionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                IReactionActor.Paged<TParams>.Indexable,
                IReactionActor.Paged<TParams>.BackLink<TSource>,
                IReactionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IReactionActor.Link,
        Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
            IReactionActor.Paged<TPaged, TParams>,
            IReactionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IReactionActor.Paged<TPaged, TParams>,
            IReactionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                IReactionActor.Paged<TPaged, TParams>.Indexable,
                IReactionActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IReactionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IReactionActor.Link,
        Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Defined
    {
        new IReadOnlyCollection<Discord.DiscordEmojiId> Ids { get; }
    
        IReadOnlyCollection<Discord.DiscordEmojiId> Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
            IReactionActor.Defined,
            IReactionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IReactionActor.Defined,
            IReactionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                IReactionActor.Defined.Indexable,
                IReactionActor.Defined.BackLink<TSource>,
                IReactionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IReactionActor.Defined,
            IReactionActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                IReactionActor.Defined.Enumerable,
                IReactionActor.Defined.BackLink<TSource>,
                IReactionActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IReactionActor.Defined.Enumerable,
                IReactionActor.Defined.Indexable,
                IReactionActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                    IReactionActor.Defined.Enumerable.Indexable,
                    IReactionActor.Defined.Enumerable.BackLink<TSource>,
                    IReactionActor.Defined.Indexable.BackLink<TSource>,
                    IReactionActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IReactionActor.Link,
        Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IReaction>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IReaction>> Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
            IReactionActor.Enumerable,
            IReactionActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IReactionActor.Enumerable,
            IReactionActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
                IReactionActor.Enumerable.Indexable,
                IReactionActor.Enumerable.BackLink<TSource>,
                IReactionActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IReactionActor.Link,
        Discord.ILinkType<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>.Indexable
    {
        internal Discord.IReactionActor this[Discord.IIdentifiable<Discord.DiscordEmojiId, Discord.IReaction, Discord.IReactionActor, Discord.Models.IReactionModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
            IReactionActor.Indexable,
            IReactionActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>,
        Discord.IReactionActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction, Discord.Models.IReactionModel>
    {
        Discord.IReactionActor Discord.IActorProvider<Discord.IReactionActor, Discord.DiscordEmojiId>.GetActor(Discord.DiscordEmojiId id) => GetActor(id);
    
        Discord.IReaction Discord.IEntityProvider<Discord.IReaction, Discord.Models.IReactionModel>.CreateEntity(Discord.Models.IReactionModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
