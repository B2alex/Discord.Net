using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelWebhookActor
{
    public interface WithChannelFollower
    {
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.WithChannelFollower,
            IGuildChannelWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.WithChannelFollower,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public interface WithIncoming
    {
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.WithIncoming,
            IGuildChannelWebhookActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.WithIncoming,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<in TParams> : 
        Discord.IWebhookActor.Paged<TParams>,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IWebhook> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IWebhook> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.Paged<TParams>,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Paged<TParams>.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithChannelFollower.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.Paged<TParams>,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TParams>.WithIncoming,
                IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Paged<TParams>.WithIncoming,
                IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithIncoming.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.Paged<TParams>,
            IGuildChannelWebhookActor.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelWebhookActor.Paged<TParams>,
            IGuildChannelWebhookActor.Indexable,
            Discord.IWebhookActor.Paged<TParams>.Indexable
        {
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Paged<TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TParams>.WithChannelFollower.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Paged<TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TParams>.WithIncoming,
                IGuildChannelWebhookActor.Indexable.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TParams>.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TParams>.WithIncoming.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IWebhookActor.Paged<TPaged, TParams>,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.Paged<TPaged, TParams>,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithChannelFollower.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.Paged<TPaged, TParams>,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithIncoming.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.Paged<TPaged, TParams>,
            IGuildChannelWebhookActor.BackLink<TSource>,
            Discord.IWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelWebhookActor.Paged<TPaged, TParams>,
            IGuildChannelWebhookActor.Indexable,
            Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable
        {
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithChannelFollower.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming,
                IGuildChannelWebhookActor.Indexable.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Paged<TPaged, TParams>.WithIncoming.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelWebhookActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IWebhookActor.Defined,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Defined.Ids => Ids;
    
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.Defined,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Defined.WithChannelFollower,
                IGuildChannelWebhookActor.Defined.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Defined.WithChannelFollower,
                IGuildChannelWebhookActor.Defined.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithChannelFollower.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.Defined,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Defined.WithIncoming,
                IGuildChannelWebhookActor.Defined.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Defined.WithIncoming,
                IGuildChannelWebhookActor.Defined.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithIncoming.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.Defined,
            IGuildChannelWebhookActor.BackLink<TSource>,
            Discord.IWebhookActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelWebhookActor.Defined,
            IGuildChannelWebhookActor.Indexable,
            Discord.IWebhookActor.Defined.Indexable
        {
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Defined.Indexable,
                IGuildChannelWebhookActor.Defined.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.WithChannelFollower.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Defined.Indexable,
                IGuildChannelWebhookActor.Defined.WithIncoming,
                IGuildChannelWebhookActor.Indexable.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Defined.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.WithIncoming.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Defined.Indexable,
                IGuildChannelWebhookActor.Defined.BackLink<TSource>,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildChannelWebhookActor.Defined,
            IGuildChannelWebhookActor.Enumerable,
            Discord.IWebhookActor.Defined.Enumerable
        {
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Defined.Enumerable,
                IGuildChannelWebhookActor.Defined.WithChannelFollower,
                IGuildChannelWebhookActor.Enumerable.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.WithChannelFollower.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.WithChannelFollower.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Defined.Enumerable,
                IGuildChannelWebhookActor.Defined.WithIncoming,
                IGuildChannelWebhookActor.Enumerable.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.WithIncoming.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.WithIncoming.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Defined.Enumerable,
                IGuildChannelWebhookActor.Defined.BackLink<TSource>,
                IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
                Discord.IWebhookActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildChannelWebhookActor.Defined.Enumerable,
                IGuildChannelWebhookActor.Defined.Indexable,
                IGuildChannelWebhookActor.Enumerable.Indexable,
                Discord.IWebhookActor.Defined.Enumerable.Indexable
            {
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower,
                    IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithIncoming : 
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.WithIncoming
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower.WithIncoming,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Enumerable.WithChannelFollower.WithIncoming.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>,
                            IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                    IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming,
                    IGuildChannelWebhookActor.Defined.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithChannelFollower : 
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming,
                        IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.WithChannelFollower
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming.WithChannelFollower,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithIncoming.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Enumerable.Indexable.WithChannelFollower.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Enumerable.WithIncoming.WithChannelFollower.BackLink<TSource>,
                            IGuildChannelWebhookActor.Defined.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>,
                            IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Defined.Enumerable.Indexable,
                    IGuildChannelWebhookActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IWebhookActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IWebhookActor.Enumerable,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IWebhook>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IWebhook>> Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.Enumerable,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Enumerable.WithChannelFollower,
                IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Enumerable.WithChannelFollower,
                IGuildChannelWebhookActor.Enumerable.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithChannelFollower.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.Enumerable,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Enumerable.WithIncoming,
                IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Enumerable.WithIncoming,
                IGuildChannelWebhookActor.Enumerable.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithIncoming.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.Enumerable,
            IGuildChannelWebhookActor.BackLink<TSource>,
            Discord.IWebhookActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelWebhookActor.Enumerable,
            IGuildChannelWebhookActor.Indexable,
            Discord.IWebhookActor.Enumerable.Indexable
        {
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Enumerable.Indexable,
                IGuildChannelWebhookActor.Enumerable.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithIncoming : 
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.WithIncoming,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.WithChannelFollower.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Enumerable.Indexable,
                IGuildChannelWebhookActor.Enumerable.WithIncoming,
                IGuildChannelWebhookActor.Indexable.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.Indexable.BackLink<TSource>,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithChannelFollower : 
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming,
                    IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower,
                    IGuildChannelWebhookActor.Enumerable.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.WithChannelFollower,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithIncoming.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.Indexable.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Enumerable.WithIncoming.WithChannelFollower.BackLink<TSource>,
                        IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Enumerable.Indexable,
                IGuildChannelWebhookActor.Enumerable.BackLink<TSource>,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                Discord.IWebhookActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IWebhookActor.Indexable,
        Discord.IGuildChannelWebhookActor.Link,
        Discord.ILinkType<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable
    {
        internal new Discord.IGuildChannelWebhookActor this[Discord.IIdentifiable<ulong, Discord.IWebhook, Discord.IGuildChannelWebhookActor, Discord.Models.IWebhookModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildChannelWebhookActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildChannelWebhookActor, ulong>).GetActor(id);
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildChannelWebhookActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildChannelWebhookActor, ulong>).GetActor(id);
    
        Discord.IWebhookActor Discord.ILinkType<Discord.IWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface WithChannelFollower : 
            IGuildChannelWebhookActor.Indexable,
            IGuildChannelWebhookActor.WithChannelFollower
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                IGuildChannelWebhookActor.WithChannelFollower.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithIncoming : 
                IGuildChannelWebhookActor.Indexable.WithChannelFollower,
                IGuildChannelWebhookActor.Indexable.WithIncoming,
                IGuildChannelWebhookActor.WithChannelFollower.WithIncoming
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.WithIncoming,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithChannelFollower.WithIncoming.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithIncoming : 
            IGuildChannelWebhookActor.Indexable,
            IGuildChannelWebhookActor.WithIncoming
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                IGuildChannelWebhookActor.Indexable.WithIncoming,
                IGuildChannelWebhookActor.Indexable.BackLink<TSource>,
                IGuildChannelWebhookActor.WithIncoming.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithChannelFollower : 
                IGuildChannelWebhookActor.Indexable.WithIncoming,
                IGuildChannelWebhookActor.Indexable.WithChannelFollower,
                IGuildChannelWebhookActor.WithIncoming.WithChannelFollower
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.WithChannelFollower,
                    IGuildChannelWebhookActor.Indexable.WithIncoming.BackLink<TSource>,
                    IGuildChannelWebhookActor.Indexable.WithChannelFollower.BackLink<TSource>,
                    IGuildChannelWebhookActor.WithIncoming.WithChannelFollower.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
            IGuildChannelWebhookActor.Indexable,
            IGuildChannelWebhookActor.BackLink<TSource>,
            Discord.IWebhookActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
        Discord.IWebhookActor.BackLink<TSource>,
        Discord.IGuildChannelWebhookActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook, Discord.Models.IWebhookModel>,
        Discord.IWebhookActor.Link
    {
        Discord.IGuildChannelWebhookActor Discord.IActorProvider<Discord.IGuildChannelWebhookActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IEntityProvider<Discord.IWebhook, Discord.Models.IWebhookModel>.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    
        Discord.IWebhookActor Discord.IWebhookActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IWebhook Discord.IWebhookActor.Link.CreateEntity(Discord.Models.IWebhookModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
