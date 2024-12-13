using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMessageActor
{
    public new interface Paged<in TParams> : 
        Discord.IMessageActor.Link,
        Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IMessage> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IMessage> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IMessageActor.Paged<TParams>,
            IMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageActor.Paged<TParams>,
            IMessageActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IMessageActor.Paged<TParams>.Indexable,
                IMessageActor.Paged<TParams>.BackLink<TSource>,
                IMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IMessageActor.Link,
        Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IMessageActor.Paged<TPaged, TParams>,
            IMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageActor.Paged<TPaged, TParams>,
            IMessageActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IMessageActor.Paged<TPaged, TParams>.Indexable,
                IMessageActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IMessageActor.Link,
        Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IMessageActor.Defined,
            IMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageActor.Defined,
            IMessageActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IMessageActor.Defined.Indexable,
                IMessageActor.Defined.BackLink<TSource>,
                IMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IMessageActor.Defined,
            IMessageActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IMessageActor.Defined.Enumerable,
                IMessageActor.Defined.BackLink<TSource>,
                IMessageActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IMessageActor.Defined.Enumerable,
                IMessageActor.Defined.Indexable,
                IMessageActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IMessageActor.Defined.Enumerable.Indexable,
                    IMessageActor.Defined.Enumerable.BackLink<TSource>,
                    IMessageActor.Defined.Indexable.BackLink<TSource>,
                    IMessageActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IMessageActor.Link,
        Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IMessage>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IMessage>> Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IMessageActor.Enumerable,
            IMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMessageActor.Enumerable,
            IMessageActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IMessageActor.Enumerable.Indexable,
                IMessageActor.Enumerable.BackLink<TSource>,
                IMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IMessageActor.Link,
        Discord.ILinkType<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Indexable
    {
        internal Discord.IMessageActor this[Discord.IIdentifiable<ulong, Discord.IMessage, Discord.IMessageActor, Discord.Models.IMessageModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IMessageActor.Indexable,
            IMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
        Discord.IMessageActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>
    {
        Discord.IMessageActor Discord.IActorProvider<Discord.IMessageActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IMessage Discord.IEntityProvider<Discord.IMessage, Discord.Models.IMessageModel>.CreateEntity(Discord.Models.IMessageModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
