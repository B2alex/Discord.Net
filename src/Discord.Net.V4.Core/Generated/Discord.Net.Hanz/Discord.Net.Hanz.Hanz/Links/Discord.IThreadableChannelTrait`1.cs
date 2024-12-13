using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadableChannelTrait<TLink>
    where TLink : class, Discord.IThreadChannelActor.Indexable
{
    public new interface Paged<in TParams> : 
        Discord.IThreadableChannelTrait.Paged<TParams>,
        Discord.IThreadableChannelTrait<TLink>.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IThreadableChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IThreadableChannel> Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IThreadableChannel> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait<TLink>.Paged<TParams>,
            IThreadableChannelTrait<TLink>.BackLink<TSource>,
            Discord.IThreadableChannelTrait.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait<TLink>.Paged<TParams>,
            IThreadableChannelTrait<TLink>.Indexable,
            Discord.IThreadableChannelTrait.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait<TLink>.Paged<TParams>.Indexable,
                IThreadableChannelTrait<TLink>.Paged<TParams>.BackLink<TSource>,
                IThreadableChannelTrait<TLink>.Indexable.BackLink<TSource>,
                Discord.IThreadableChannelTrait.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IThreadableChannelTrait.Paged<TPaged, TParams>,
        Discord.IThreadableChannelTrait<TLink>.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait<TLink>.Paged<TPaged, TParams>,
            IThreadableChannelTrait<TLink>.BackLink<TSource>,
            Discord.IThreadableChannelTrait.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait<TLink>.Paged<TPaged, TParams>,
            IThreadableChannelTrait<TLink>.Indexable,
            Discord.IThreadableChannelTrait.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait<TLink>.Paged<TPaged, TParams>.Indexable,
                IThreadableChannelTrait<TLink>.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadableChannelTrait<TLink>.Indexable.BackLink<TSource>,
                Discord.IThreadableChannelTrait.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IThreadableChannelTrait.Defined,
        Discord.IThreadableChannelTrait<TLink>.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait<TLink>.Defined,
            IThreadableChannelTrait<TLink>.BackLink<TSource>,
            Discord.IThreadableChannelTrait.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait<TLink>.Defined,
            IThreadableChannelTrait<TLink>.Indexable,
            Discord.IThreadableChannelTrait.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait<TLink>.Defined.Indexable,
                IThreadableChannelTrait<TLink>.Defined.BackLink<TSource>,
                IThreadableChannelTrait<TLink>.Indexable.BackLink<TSource>,
                Discord.IThreadableChannelTrait.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IThreadableChannelTrait<TLink>.Defined,
            IThreadableChannelTrait<TLink>.Enumerable,
            Discord.IThreadableChannelTrait.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait<TLink>.Defined.Enumerable,
                IThreadableChannelTrait<TLink>.Defined.BackLink<TSource>,
                IThreadableChannelTrait<TLink>.Enumerable.BackLink<TSource>,
                Discord.IThreadableChannelTrait.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IThreadableChannelTrait<TLink>.Defined.Enumerable,
                IThreadableChannelTrait<TLink>.Defined.Indexable,
                IThreadableChannelTrait<TLink>.Enumerable.Indexable,
                Discord.IThreadableChannelTrait.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                    IThreadableChannelTrait<TLink>.Defined.Enumerable.Indexable,
                    IThreadableChannelTrait<TLink>.Defined.Enumerable.BackLink<TSource>,
                    IThreadableChannelTrait<TLink>.Defined.Indexable.BackLink<TSource>,
                    IThreadableChannelTrait<TLink>.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IThreadableChannelTrait.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IThreadableChannelTrait.Enumerable,
        Discord.IThreadableChannelTrait<TLink>.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IThreadableChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IThreadableChannel>> Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IThreadableChannel>> Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait<TLink>.Enumerable,
            IThreadableChannelTrait<TLink>.BackLink<TSource>,
            Discord.IThreadableChannelTrait.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadableChannelTrait<TLink>.Enumerable,
            IThreadableChannelTrait<TLink>.Indexable,
            Discord.IThreadableChannelTrait.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
                IThreadableChannelTrait<TLink>.Enumerable.Indexable,
                IThreadableChannelTrait<TLink>.Enumerable.BackLink<TSource>,
                IThreadableChannelTrait<TLink>.Indexable.BackLink<TSource>,
                Discord.IThreadableChannelTrait.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IThreadableChannelTrait.Indexable,
        Discord.IThreadableChannelTrait<TLink>.Link,
        Discord.ILinkType<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Indexable
    {
        internal new Discord.IThreadableChannelTrait<TLink> this[Discord.IIdentifiable<ulong, Discord.IThreadableChannel, Discord.IThreadableChannelTrait<TLink>, Discord.Models.IThreadableChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IThreadableChannelTrait<TLink> this[ulong id] => (this as Discord.IActorProvider<Discord.IThreadableChannelTrait<TLink>, ulong>).GetActor(id);
    
        Discord.IThreadableChannelTrait Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IThreadableChannelTrait<TLink> Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IThreadableChannelTrait<TLink>, ulong>).GetActor(id);
    
        Discord.IThreadableChannelTrait Discord.ILinkType<Discord.IThreadableChannelTrait, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
            IThreadableChannelTrait<TLink>.Indexable,
            IThreadableChannelTrait<TLink>.BackLink<TSource>,
            Discord.IThreadableChannelTrait.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
        Discord.IThreadableChannelTrait.BackLink<TSource>,
        Discord.IThreadableChannelTrait<TLink>
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IThreadableChannelTrait<TLink>, ulong, Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>,
        Discord.IThreadableChannelTrait.Link
    {
        Discord.IThreadableChannelTrait<TLink> Discord.IActorProvider<Discord.IThreadableChannelTrait<TLink>, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadableChannel Discord.IEntityProvider<Discord.IThreadableChannel, Discord.Models.IThreadableChannelModel>.CreateEntity(Discord.Models.IThreadableChannelModel model) => CreateEntity(model);
    
        Discord.IThreadableChannelTrait Discord.IThreadableChannelTrait.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadableChannel Discord.IThreadableChannelTrait.Link.CreateEntity(Discord.Models.IThreadableChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
