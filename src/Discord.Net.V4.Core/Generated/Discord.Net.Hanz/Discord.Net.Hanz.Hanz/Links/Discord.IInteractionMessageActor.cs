using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionMessageActor
{
    public interface WithOriginal
    {
        Discord.IInteractionCallbackResponseActor Original { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.WithOriginal,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IInteractionMessageActor.Link,
        Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IMessage> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IMessage> Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithOriginal : 
            IInteractionMessageActor.Paged<TParams>,
            IInteractionMessageActor.WithOriginal
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Paged<TParams>.WithOriginal,
                IInteractionMessageActor.Paged<TParams>.BackLink<TSource>,
                IInteractionMessageActor.WithOriginal.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.Paged<TParams>,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionMessageActor.Paged<TParams>,
            IInteractionMessageActor.Indexable
        {
            public interface WithOriginal : 
                IInteractionMessageActor.Paged<TParams>.Indexable,
                IInteractionMessageActor.Paged<TParams>.WithOriginal,
                IInteractionMessageActor.Indexable.WithOriginal
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Paged<TParams>.Indexable.WithOriginal,
                    IInteractionMessageActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IInteractionMessageActor.Paged<TParams>.WithOriginal.BackLink<TSource>,
                    IInteractionMessageActor.Indexable.WithOriginal.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Paged<TParams>.Indexable,
                IInteractionMessageActor.Paged<TParams>.BackLink<TSource>,
                IInteractionMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInteractionMessageActor.Link,
        Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithOriginal : 
            IInteractionMessageActor.Paged<TPaged, TParams>,
            IInteractionMessageActor.WithOriginal
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Paged<TPaged, TParams>.WithOriginal,
                IInteractionMessageActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInteractionMessageActor.WithOriginal.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.Paged<TPaged, TParams>,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionMessageActor.Paged<TPaged, TParams>,
            IInteractionMessageActor.Indexable
        {
            public interface WithOriginal : 
                IInteractionMessageActor.Paged<TPaged, TParams>.Indexable,
                IInteractionMessageActor.Paged<TPaged, TParams>.WithOriginal,
                IInteractionMessageActor.Indexable.WithOriginal
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Paged<TPaged, TParams>.Indexable.WithOriginal,
                    IInteractionMessageActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IInteractionMessageActor.Paged<TPaged, TParams>.WithOriginal.BackLink<TSource>,
                    IInteractionMessageActor.Indexable.WithOriginal.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Paged<TPaged, TParams>.Indexable,
                IInteractionMessageActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInteractionMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInteractionMessageActor.Link,
        Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Defined.Ids => Ids;
    
    
        public interface WithOriginal : 
            IInteractionMessageActor.Defined,
            IInteractionMessageActor.WithOriginal
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Defined.WithOriginal,
                IInteractionMessageActor.Defined.BackLink<TSource>,
                IInteractionMessageActor.WithOriginal.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.Defined,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionMessageActor.Defined,
            IInteractionMessageActor.Indexable
        {
            public interface WithOriginal : 
                IInteractionMessageActor.Defined.Indexable,
                IInteractionMessageActor.Defined.WithOriginal,
                IInteractionMessageActor.Indexable.WithOriginal
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Defined.Indexable.WithOriginal,
                    IInteractionMessageActor.Defined.Indexable.BackLink<TSource>,
                    IInteractionMessageActor.Defined.WithOriginal.BackLink<TSource>,
                    IInteractionMessageActor.Indexable.WithOriginal.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Defined.Indexable,
                IInteractionMessageActor.Defined.BackLink<TSource>,
                IInteractionMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IInteractionMessageActor.Defined,
            IInteractionMessageActor.Enumerable
        {
            public interface WithOriginal : 
                IInteractionMessageActor.Defined.Enumerable,
                IInteractionMessageActor.Defined.WithOriginal,
                IInteractionMessageActor.Enumerable.WithOriginal
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Defined.Enumerable.WithOriginal,
                    IInteractionMessageActor.Defined.Enumerable.BackLink<TSource>,
                    IInteractionMessageActor.Defined.WithOriginal.BackLink<TSource>,
                    IInteractionMessageActor.Enumerable.WithOriginal.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Defined.Enumerable,
                IInteractionMessageActor.Defined.BackLink<TSource>,
                IInteractionMessageActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IInteractionMessageActor.Defined.Enumerable,
                IInteractionMessageActor.Defined.Indexable,
                IInteractionMessageActor.Enumerable.Indexable
            {
                public interface WithOriginal : 
                    IInteractionMessageActor.Defined.Enumerable.Indexable,
                    IInteractionMessageActor.Defined.Enumerable.WithOriginal,
                    IInteractionMessageActor.Defined.Indexable.WithOriginal,
                    IInteractionMessageActor.Enumerable.Indexable.WithOriginal
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                        IInteractionMessageActor.Defined.Enumerable.Indexable.WithOriginal,
                        IInteractionMessageActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IInteractionMessageActor.Defined.Enumerable.WithOriginal.BackLink<TSource>,
                        IInteractionMessageActor.Defined.Indexable.WithOriginal.BackLink<TSource>,
                        IInteractionMessageActor.Enumerable.Indexable.WithOriginal.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Defined.Enumerable.Indexable,
                    IInteractionMessageActor.Defined.Enumerable.BackLink<TSource>,
                    IInteractionMessageActor.Defined.Indexable.BackLink<TSource>,
                    IInteractionMessageActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInteractionMessageActor.Link,
        Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IMessage>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IMessage>> Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithOriginal : 
            IInteractionMessageActor.Enumerable,
            IInteractionMessageActor.WithOriginal
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Enumerable.WithOriginal,
                IInteractionMessageActor.Enumerable.BackLink<TSource>,
                IInteractionMessageActor.WithOriginal.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.Enumerable,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInteractionMessageActor.Enumerable,
            IInteractionMessageActor.Indexable
        {
            public interface WithOriginal : 
                IInteractionMessageActor.Enumerable.Indexable,
                IInteractionMessageActor.Enumerable.WithOriginal,
                IInteractionMessageActor.Indexable.WithOriginal
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                    IInteractionMessageActor.Enumerable.Indexable.WithOriginal,
                    IInteractionMessageActor.Enumerable.Indexable.BackLink<TSource>,
                    IInteractionMessageActor.Enumerable.WithOriginal.BackLink<TSource>,
                    IInteractionMessageActor.Indexable.WithOriginal.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Enumerable.Indexable,
                IInteractionMessageActor.Enumerable.BackLink<TSource>,
                IInteractionMessageActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInteractionMessageActor.Link,
        Discord.ILinkType<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>.Indexable
    {
        internal Discord.IInteractionMessageActor this[Discord.IIdentifiable<ulong, Discord.IMessage, Discord.IInteractionMessageActor, Discord.Models.IMessageModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface WithOriginal : 
            IInteractionMessageActor.Indexable,
            IInteractionMessageActor.WithOriginal
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
                IInteractionMessageActor.Indexable.WithOriginal,
                IInteractionMessageActor.Indexable.BackLink<TSource>,
                IInteractionMessageActor.WithOriginal.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
            IInteractionMessageActor.Indexable,
            IInteractionMessageActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>,
        Discord.IInteractionMessageActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IInteractionMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel>
    {
        Discord.IInteractionMessageActor Discord.IActorProvider<Discord.IInteractionMessageActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IMessage Discord.IEntityProvider<Discord.IMessage, Discord.Models.IMessageModel>.CreateEntity(Discord.Models.IMessageModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
