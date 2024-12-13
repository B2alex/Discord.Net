using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IAnnouncementThreadChannelActor
{
    public interface WithAnnouncementArchived : 
        Discord.IThreadChannelActor.WithAnnouncementArchived
    {
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IThreadChannelActor.Paged<TParams>,
        Discord.IChannelActor.Paged<TParams>,
        Discord.IAnnouncementThreadChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IAnnouncementThreadChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IAnnouncementThreadChannel> Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IThreadChannel> Discord.IThreadChannelActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithAnnouncementArchived : 
            IAnnouncementThreadChannelActor.Paged<TParams>,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            Discord.IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IAnnouncementThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.Paged<TParams>,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementThreadChannelActor.Paged<TParams>,
            IAnnouncementThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Paged<TParams>.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface WithAnnouncementArchived : 
                IAnnouncementThreadChannelActor.Paged<TParams>.Indexable,
                IAnnouncementThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived,
                Discord.IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    Discord.IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Paged<TParams>.Indexable,
                IAnnouncementThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IAnnouncementThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IThreadChannelActor.Paged<TPaged, TParams>,
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IAnnouncementThreadChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IThreadChannelActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithAnnouncementArchived : 
            IAnnouncementThreadChannelActor.Paged<TPaged, TParams>,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            Discord.IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IAnnouncementThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.Paged<TPaged, TParams>,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementThreadChannelActor.Paged<TPaged, TParams>,
            IAnnouncementThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface WithAnnouncementArchived : 
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived,
                Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IAnnouncementThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IAnnouncementThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IThreadChannelActor.Defined,
        Discord.IChannelActor.Defined,
        Discord.IAnnouncementThreadChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IThreadChannelActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface WithAnnouncementArchived : 
            IAnnouncementThreadChannelActor.Defined,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            Discord.IThreadChannelActor.Defined.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Defined.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Defined.BackLink<TSource>,
                IAnnouncementThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                Discord.IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.Defined,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Defined.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementThreadChannelActor.Defined,
            IAnnouncementThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Defined.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface WithAnnouncementArchived : 
                IAnnouncementThreadChannelActor.Defined.Indexable,
                IAnnouncementThreadChannelActor.Defined.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived,
                Discord.IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    Discord.IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Defined.Indexable,
                IAnnouncementThreadChannelActor.Defined.BackLink<TSource>,
                IAnnouncementThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IAnnouncementThreadChannelActor.Defined,
            IAnnouncementThreadChannelActor.Enumerable,
            Discord.IThreadChannelActor.Defined.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface WithAnnouncementArchived : 
                IAnnouncementThreadChannelActor.Defined.Enumerable,
                IAnnouncementThreadChannelActor.Defined.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Enumerable.WithAnnouncementArchived,
                Discord.IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    Discord.IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Defined.Enumerable,
                IAnnouncementThreadChannelActor.Defined.BackLink<TSource>,
                IAnnouncementThreadChannelActor.Enumerable.BackLink<TSource>,
                Discord.IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IAnnouncementThreadChannelActor.Defined.Enumerable,
                IAnnouncementThreadChannelActor.Defined.Indexable,
                IAnnouncementThreadChannelActor.Enumerable.Indexable,
                Discord.IThreadChannelActor.Defined.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface WithAnnouncementArchived : 
                    IAnnouncementThreadChannelActor.Defined.Enumerable.Indexable,
                    IAnnouncementThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    Discord.IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                        IAnnouncementThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IAnnouncementThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IAnnouncementThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IAnnouncementThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IAnnouncementThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        Discord.IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Defined.Enumerable.Indexable,
                    IAnnouncementThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IThreadChannelActor.Enumerable,
        Discord.IChannelActor.Enumerable,
        Discord.IAnnouncementThreadChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IAnnouncementThreadChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IAnnouncementThreadChannel>> Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IThreadChannel>> Discord.IThreadChannelActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithAnnouncementArchived : 
            IAnnouncementThreadChannelActor.Enumerable,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            Discord.IThreadChannelActor.Enumerable.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Enumerable.BackLink<TSource>,
                IAnnouncementThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                Discord.IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.Enumerable,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Enumerable.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IAnnouncementThreadChannelActor.Enumerable,
            IAnnouncementThreadChannelActor.Indexable,
            Discord.IThreadChannelActor.Enumerable.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface WithAnnouncementArchived : 
                IAnnouncementThreadChannelActor.Enumerable.Indexable,
                IAnnouncementThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived,
                Discord.IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                    IAnnouncementThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IAnnouncementThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    Discord.IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Enumerable.Indexable,
                IAnnouncementThreadChannelActor.Enumerable.BackLink<TSource>,
                IAnnouncementThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IThreadChannelActor.Indexable,
        Discord.IChannelActor.Indexable,
        Discord.IAnnouncementThreadChannelActor.Link,
        Discord.ILinkType<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.Indexable
    {
        internal new Discord.IAnnouncementThreadChannelActor this[Discord.IIdentifiable<ulong, Discord.IAnnouncementThreadChannel, Discord.IAnnouncementThreadChannelActor, Discord.Models.IThreadChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IAnnouncementThreadChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IAnnouncementThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Indexable.this[ulong id] => this[id];
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IAnnouncementThreadChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IAnnouncementThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface WithAnnouncementArchived : 
            IAnnouncementThreadChannelActor.Indexable,
            IAnnouncementThreadChannelActor.WithAnnouncementArchived,
            Discord.IThreadChannelActor.Indexable.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
                IAnnouncementThreadChannelActor.Indexable.WithAnnouncementArchived,
                IAnnouncementThreadChannelActor.Indexable.BackLink<TSource>,
                IAnnouncementThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                Discord.IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
            IAnnouncementThreadChannelActor.Indexable,
            IAnnouncementThreadChannelActor.BackLink<TSource>,
            Discord.IThreadChannelActor.Indexable.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IThreadChannelActor.BackLink<TSource>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IAnnouncementThreadChannelActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IThreadChannelActor.Link,
        Discord.IChannelActor.Link
    {
        Discord.IAnnouncementThreadChannelActor Discord.IActorProvider<Discord.IAnnouncementThreadChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IAnnouncementThreadChannel Discord.IEntityProvider<Discord.IAnnouncementThreadChannel, Discord.Models.IThreadChannelModel>.CreateEntity(Discord.Models.IThreadChannelModel model) => CreateEntity(model);
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadChannel Discord.IThreadChannelActor.Link.CreateEntity(Discord.Models.IThreadChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
