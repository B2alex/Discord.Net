using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ISoundboardSoundActor
{
    public new interface Paged<in TParams> : 
        Discord.ISoundboardSoundActor.Link,
        Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ISoundboardSound> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ISoundboardSound> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
            ISoundboardSoundActor.Paged<TParams>,
            ISoundboardSoundActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISoundboardSoundActor.Paged<TParams>,
            ISoundboardSoundActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                ISoundboardSoundActor.Paged<TParams>.Indexable,
                ISoundboardSoundActor.Paged<TParams>.BackLink<TSource>,
                ISoundboardSoundActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.ISoundboardSoundActor.Link,
        Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
            ISoundboardSoundActor.Paged<TPaged, TParams>,
            ISoundboardSoundActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISoundboardSoundActor.Paged<TPaged, TParams>,
            ISoundboardSoundActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                ISoundboardSoundActor.Paged<TPaged, TParams>.Indexable,
                ISoundboardSoundActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ISoundboardSoundActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.ISoundboardSoundActor.Link,
        Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
            ISoundboardSoundActor.Defined,
            ISoundboardSoundActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISoundboardSoundActor.Defined,
            ISoundboardSoundActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                ISoundboardSoundActor.Defined.Indexable,
                ISoundboardSoundActor.Defined.BackLink<TSource>,
                ISoundboardSoundActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ISoundboardSoundActor.Defined,
            ISoundboardSoundActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                ISoundboardSoundActor.Defined.Enumerable,
                ISoundboardSoundActor.Defined.BackLink<TSource>,
                ISoundboardSoundActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ISoundboardSoundActor.Defined.Enumerable,
                ISoundboardSoundActor.Defined.Indexable,
                ISoundboardSoundActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                    ISoundboardSoundActor.Defined.Enumerable.Indexable,
                    ISoundboardSoundActor.Defined.Enumerable.BackLink<TSource>,
                    ISoundboardSoundActor.Defined.Indexable.BackLink<TSource>,
                    ISoundboardSoundActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.ISoundboardSoundActor.Link,
        Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ISoundboardSound>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ISoundboardSound>> Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
            ISoundboardSoundActor.Enumerable,
            ISoundboardSoundActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ISoundboardSoundActor.Enumerable,
            ISoundboardSoundActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
                ISoundboardSoundActor.Enumerable.Indexable,
                ISoundboardSoundActor.Enumerable.BackLink<TSource>,
                ISoundboardSoundActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.ISoundboardSoundActor.Link,
        Discord.ILinkType<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.Indexable
    {
        internal Discord.ISoundboardSoundActor this[Discord.IIdentifiable<ulong, Discord.ISoundboardSound, Discord.ISoundboardSoundActor, Discord.Models.ISoundboardSoundModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
            ISoundboardSoundActor.Indexable,
            ISoundboardSoundActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>,
        Discord.ISoundboardSoundActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>
    {
        Discord.ISoundboardSoundActor Discord.IActorProvider<Discord.ISoundboardSoundActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ISoundboardSound Discord.IEntityProvider<Discord.ISoundboardSound, Discord.Models.ISoundboardSoundModel>.CreateEntity(Discord.Models.ISoundboardSoundModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
