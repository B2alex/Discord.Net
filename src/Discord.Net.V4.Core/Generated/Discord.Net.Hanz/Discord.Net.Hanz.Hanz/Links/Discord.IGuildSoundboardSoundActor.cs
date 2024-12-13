using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildSoundboardSoundActor
{
    public new interface Paged<in TParams> : 
        Discord.ISoundboardSoundActor.Paged<TParams>,
        Discord.IGuildSoundboardSoundActor.Link,
        Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildSoundboardSound> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildSoundboardSound> Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.ISoundboardSound> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
            IGuildSoundboardSoundActor.Paged<TParams>,
            IGuildSoundboardSoundActor.BackLink<TSource>,
            Discord.ISoundboardSoundActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildSoundboardSoundActor.Paged<TParams>,
            IGuildSoundboardSoundActor.Indexable,
            Discord.ISoundboardSoundActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                IGuildSoundboardSoundActor.Paged<TParams>.Indexable,
                IGuildSoundboardSoundActor.Paged<TParams>.BackLink<TSource>,
                IGuildSoundboardSoundActor.Indexable.BackLink<TSource>,
                Discord.ISoundboardSoundActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.ISoundboardSoundActor.Paged<TPaged, TParams>,
        Discord.IGuildSoundboardSoundActor.Link,
        Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
            IGuildSoundboardSoundActor.Paged<TPaged, TParams>,
            IGuildSoundboardSoundActor.BackLink<TSource>,
            Discord.ISoundboardSoundActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildSoundboardSoundActor.Paged<TPaged, TParams>,
            IGuildSoundboardSoundActor.Indexable,
            Discord.ISoundboardSoundActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                IGuildSoundboardSoundActor.Paged<TPaged, TParams>.Indexable,
                IGuildSoundboardSoundActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildSoundboardSoundActor.Indexable.BackLink<TSource>,
                Discord.ISoundboardSoundActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.ISoundboardSoundActor.Defined,
        Discord.IGuildSoundboardSoundActor.Link,
        Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
            IGuildSoundboardSoundActor.Defined,
            IGuildSoundboardSoundActor.BackLink<TSource>,
            Discord.ISoundboardSoundActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildSoundboardSoundActor.Defined,
            IGuildSoundboardSoundActor.Indexable,
            Discord.ISoundboardSoundActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                IGuildSoundboardSoundActor.Defined.Indexable,
                IGuildSoundboardSoundActor.Defined.BackLink<TSource>,
                IGuildSoundboardSoundActor.Indexable.BackLink<TSource>,
                Discord.ISoundboardSoundActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildSoundboardSoundActor.Defined,
            IGuildSoundboardSoundActor.Enumerable,
            Discord.ISoundboardSoundActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                IGuildSoundboardSoundActor.Defined.Enumerable,
                IGuildSoundboardSoundActor.Defined.BackLink<TSource>,
                IGuildSoundboardSoundActor.Enumerable.BackLink<TSource>,
                Discord.ISoundboardSoundActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildSoundboardSoundActor.Defined.Enumerable,
                IGuildSoundboardSoundActor.Defined.Indexable,
                IGuildSoundboardSoundActor.Enumerable.Indexable,
                Discord.ISoundboardSoundActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                    IGuildSoundboardSoundActor.Defined.Enumerable.Indexable,
                    IGuildSoundboardSoundActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildSoundboardSoundActor.Defined.Indexable.BackLink<TSource>,
                    IGuildSoundboardSoundActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.ISoundboardSoundActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.ISoundboardSoundActor.Enumerable,
        Discord.IGuildSoundboardSoundActor.Link,
        Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildSoundboardSound>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildSoundboardSound>> Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.ISoundboardSound>> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
            IGuildSoundboardSoundActor.Enumerable,
            IGuildSoundboardSoundActor.BackLink<TSource>,
            Discord.ISoundboardSoundActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildSoundboardSoundActor.Enumerable,
            IGuildSoundboardSoundActor.Indexable,
            Discord.ISoundboardSoundActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
                IGuildSoundboardSoundActor.Enumerable.Indexable,
                IGuildSoundboardSoundActor.Enumerable.BackLink<TSource>,
                IGuildSoundboardSoundActor.Indexable.BackLink<TSource>,
                Discord.ISoundboardSoundActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.ISoundboardSoundActor.Indexable,
        Discord.IGuildSoundboardSoundActor.Link,
        Discord.ILinkType<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.Indexable
    {
        internal new Discord.IGuildSoundboardSoundActor this[Discord.IIdentifiable<ulong, Discord.IGuildSoundboardSound, Discord.IGuildSoundboardSoundActor, Discord.Models.IGuildSoundboardSoundModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildSoundboardSoundActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildSoundboardSoundActor, ulong>).GetActor(id);
    
        Discord.ISoundboardSoundActor Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildSoundboardSoundActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildSoundboardSoundActor, ulong>).GetActor(id);
    
        Discord.ISoundboardSoundActor Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
            IGuildSoundboardSoundActor.Indexable,
            IGuildSoundboardSoundActor.BackLink<TSource>,
            Discord.ISoundboardSoundActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
        Discord.ISoundboardSoundActor.BackLink<TSource>,
        Discord.IGuildSoundboardSoundActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>,
        Discord.ISoundboardSoundActor.Link
    {
        Discord.IGuildSoundboardSoundActor Discord.IActorProvider<Discord.IGuildSoundboardSoundActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildSoundboardSound Discord.IEntityProvider<Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>.CreateEntity(Discord.Models.IGuildSoundboardSoundModel model) => CreateEntity(model);
    
        Discord.ISoundboardSoundActor Discord.ISoundboardSoundActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.ISoundboardSound Discord.ISoundboardSoundActor.Link.CreateEntity(Discord.Models.ISoundboardSoundModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
