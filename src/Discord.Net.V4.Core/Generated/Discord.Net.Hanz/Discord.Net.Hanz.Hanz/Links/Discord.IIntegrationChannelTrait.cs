using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIntegrationChannelTrait
{
    public new interface Paged<in TParams> : 
        Discord.IIntegrationChannelTrait.Link,
        Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IIntegrationChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IIntegrationChannel> Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
            IIntegrationChannelTrait.Paged<TParams>,
            IIntegrationChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationChannelTrait.Paged<TParams>,
            IIntegrationChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                IIntegrationChannelTrait.Paged<TParams>.Indexable,
                IIntegrationChannelTrait.Paged<TParams>.BackLink<TSource>,
                IIntegrationChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IIntegrationChannelTrait.Link,
        Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
            IIntegrationChannelTrait.Paged<TPaged, TParams>,
            IIntegrationChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationChannelTrait.Paged<TPaged, TParams>,
            IIntegrationChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                IIntegrationChannelTrait.Paged<TPaged, TParams>.Indexable,
                IIntegrationChannelTrait.Paged<TPaged, TParams>.BackLink<TSource>,
                IIntegrationChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IIntegrationChannelTrait.Link,
        Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
            IIntegrationChannelTrait.Defined,
            IIntegrationChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationChannelTrait.Defined,
            IIntegrationChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                IIntegrationChannelTrait.Defined.Indexable,
                IIntegrationChannelTrait.Defined.BackLink<TSource>,
                IIntegrationChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IIntegrationChannelTrait.Defined,
            IIntegrationChannelTrait.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                IIntegrationChannelTrait.Defined.Enumerable,
                IIntegrationChannelTrait.Defined.BackLink<TSource>,
                IIntegrationChannelTrait.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IIntegrationChannelTrait.Defined.Enumerable,
                IIntegrationChannelTrait.Defined.Indexable,
                IIntegrationChannelTrait.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                    IIntegrationChannelTrait.Defined.Enumerable.Indexable,
                    IIntegrationChannelTrait.Defined.Enumerable.BackLink<TSource>,
                    IIntegrationChannelTrait.Defined.Indexable.BackLink<TSource>,
                    IIntegrationChannelTrait.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IIntegrationChannelTrait.Link,
        Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IIntegrationChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IIntegrationChannel>> Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
            IIntegrationChannelTrait.Enumerable,
            IIntegrationChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IIntegrationChannelTrait.Enumerable,
            IIntegrationChannelTrait.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
                IIntegrationChannelTrait.Enumerable.Indexable,
                IIntegrationChannelTrait.Enumerable.BackLink<TSource>,
                IIntegrationChannelTrait.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IIntegrationChannelTrait.Link,
        Discord.ILinkType<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.Indexable
    {
        internal Discord.IIntegrationChannelTrait this[Discord.IIdentifiable<ulong, Discord.IIntegrationChannel, Discord.IIntegrationChannelTrait, Discord.Models.IGuildChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
            IIntegrationChannelTrait.Indexable,
            IIntegrationChannelTrait.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>,
        Discord.IIntegrationChannelTrait
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IIntegrationChannelTrait, ulong, Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>
    {
        Discord.IIntegrationChannelTrait Discord.IActorProvider<Discord.IIntegrationChannelTrait, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IIntegrationChannel Discord.IEntityProvider<Discord.IIntegrationChannel, Discord.Models.IGuildChannelModel>.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
