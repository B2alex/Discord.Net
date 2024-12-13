using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadChannelActor
{
    public interface WithArchived
    {
        Discord.IPublicThreadChannelActor.Paged<Discord.PagePublicArchivedThreadsParams> PublicArchived { get; }
    
        Discord.IPrivateThreadChannelActor.Paged<Discord.PagePrivateArchivedThreadsParams> PrivateArchived { get; }
    
        Discord.IPrivateThreadChannelActor.Paged<Discord.PageJoinedPrivateArchivedThreadsParams> JoinedPrivateArchived { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.WithArchived,
            IThreadChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithActive : 
            IThreadChannelActor.WithArchived,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithArchived.WithActive,
                IThreadChannelActor.WithArchived.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.WithArchived.WithActive,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.WithArchived,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.WithArchived.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public interface WithAnnouncementArchived
    {
        Discord.IAnnouncementThreadChannelActor.Paged<Discord.PagePublicArchivedThreadsParams> PublicArchived { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.WithAnnouncementArchived,
            IThreadChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithActive : 
            IThreadChannelActor.WithAnnouncementArchived,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithAnnouncementArchived.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithArchived : 
                IThreadChannelActor.WithAnnouncementArchived.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithArchived : 
            IThreadChannelActor.WithAnnouncementArchived,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.WithAnnouncementArchived.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public interface WithActive
    {
        Discord.IThreadChannelActor.Enumerable.BackLink<Discord.IGuildActor> Active { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.WithActive,
            IThreadChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.WithActive,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithActive.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithArchived : 
                IThreadChannelActor.WithActive.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithArchived : 
            IThreadChannelActor.WithActive,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.WithActive.WithArchived,
                IThreadChannelActor.WithActive.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.WithActive.WithArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Paged<in TParams> : 
        Discord.IChannelActor.Paged<TParams>,
        Discord.IThreadChannelActor.Link,
        Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IThreadChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IThreadChannel> Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithArchived : 
            IThreadChannelActor.Paged<TParams>,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.Paged<TParams>,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithActive : 
            IThreadChannelActor.Paged<TParams>,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.Paged<TParams>,
            IThreadChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadChannelActor.Paged<TParams>,
            IThreadChannelActor.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface WithArchived : 
                IThreadChannelActor.Paged<TParams>.Indexable,
                IThreadChannelActor.Paged<TParams>.WithArchived,
                IThreadChannelActor.Indexable.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TParams>.Indexable,
                IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TParams>.Indexable,
                IThreadChannelActor.Paged<TParams>.WithActive,
                IThreadChannelActor.Indexable.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TParams>.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TParams>.Indexable,
                IThreadChannelActor.Paged<TParams>.BackLink<TSource>,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IThreadChannelActor.Link,
        Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithArchived : 
            IThreadChannelActor.Paged<TPaged, TParams>,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.Paged<TPaged, TParams>,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithActive : 
            IThreadChannelActor.Paged<TPaged, TParams>,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.Paged<TPaged, TParams>,
            IThreadChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadChannelActor.Paged<TPaged, TParams>,
            IThreadChannelActor.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface WithArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IThreadChannelActor.Paged<TPaged, TParams>.WithArchived,
                IThreadChannelActor.Indexable.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithActive : 
                IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IThreadChannelActor.Paged<TPaged, TParams>.WithActive,
                IThreadChannelActor.Indexable.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive,
                    IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived,
                    IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Paged<TPaged, TParams>.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Paged<TPaged, TParams>.Indexable,
                IThreadChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IChannelActor.Defined,
        Discord.IThreadChannelActor.Link,
        Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface WithArchived : 
            IThreadChannelActor.Defined,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.Defined.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.Defined,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.Defined.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithActive : 
            IThreadChannelActor.Defined,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.Defined.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.Defined,
            IThreadChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadChannelActor.Defined,
            IThreadChannelActor.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface WithArchived : 
                IThreadChannelActor.Defined.Indexable,
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.Indexable.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Defined.Indexable,
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithActive : 
                IThreadChannelActor.Defined.Indexable,
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.Indexable.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Defined.Indexable,
                IThreadChannelActor.Defined.BackLink<TSource>,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IThreadChannelActor.Defined,
            IThreadChannelActor.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface WithArchived : 
                IThreadChannelActor.Defined.Enumerable,
                IThreadChannelActor.Defined.WithArchived,
                IThreadChannelActor.Enumerable.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.WithArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Defined.Enumerable,
                IThreadChannelActor.Defined.WithAnnouncementArchived,
                IThreadChannelActor.Enumerable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithActive : 
                IThreadChannelActor.Defined.Enumerable,
                IThreadChannelActor.Defined.WithActive,
                IThreadChannelActor.Enumerable.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadChannelActor.Defined.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.WithActive.WithArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Defined.Enumerable,
                IThreadChannelActor.Defined.BackLink<TSource>,
                IThreadChannelActor.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IThreadChannelActor.Defined.Enumerable,
                IThreadChannelActor.Defined.Indexable,
                IThreadChannelActor.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface WithArchived : 
                    IThreadChannelActor.Defined.Enumerable.Indexable,
                    IThreadChannelActor.Defined.Enumerable.WithArchived,
                    IThreadChannelActor.Defined.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithAnnouncementArchived : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.WithAnnouncementArchived
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithActive : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.WithActive
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Defined.Enumerable.Indexable,
                    IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived,
                    IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithActive,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithArchived : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.WithArchived
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithActive : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.WithActive
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                }
            
                public interface WithActive : 
                    IThreadChannelActor.Defined.Enumerable.Indexable,
                    IThreadChannelActor.Defined.Enumerable.WithActive,
                    IThreadChannelActor.Defined.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.Indexable.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithActive,
                        IThreadChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IThreadChannelActor.Defined.Enumerable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Defined.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithActive,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithArchived : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.WithArchived
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                
                    public interface WithArchived : 
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithActive,
                        IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived,
                        IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived,
                        IThreadChannelActor.Defined.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    
                        public interface WithAnnouncementArchived : 
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.WithAnnouncementArchived
                        {
                            public interface BackLink<out TSource> : 
                                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Enumerable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Defined.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                                IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                                where TSource : class, IPathable;
                        }
                    }
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Defined.Enumerable.Indexable,
                    IThreadChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadChannelActor.Defined.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IChannelActor.Enumerable,
        Discord.IThreadChannelActor.Link,
        Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IThreadChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IThreadChannel>> Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithArchived : 
            IThreadChannelActor.Enumerable,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.Enumerable.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Enumerable.WithArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.Enumerable,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.Enumerable.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Enumerable.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithActive : 
            IThreadChannelActor.Enumerable,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.Enumerable.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithArchived,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.WithActive.WithArchived,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Enumerable.WithActive.WithArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.Enumerable,
            IThreadChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadChannelActor.Enumerable,
            IThreadChannelActor.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface WithArchived : 
                IThreadChannelActor.Enumerable.Indexable,
                IThreadChannelActor.Enumerable.WithArchived,
                IThreadChannelActor.Indexable.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Enumerable.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Enumerable.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Enumerable.Indexable,
                IThreadChannelActor.Enumerable.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithActive : 
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive,
                        IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface WithActive : 
                IThreadChannelActor.Enumerable.Indexable,
                IThreadChannelActor.Enumerable.WithActive,
                IThreadChannelActor.Indexable.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Enumerable.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IThreadChannelActor.Enumerable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Enumerable.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithArchived : 
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithArchived : 
                    IThreadChannelActor.Enumerable.Indexable.WithActive,
                    IThreadChannelActor.Enumerable.Indexable.WithArchived,
                    IThreadChannelActor.Enumerable.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithAnnouncementArchived : 
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Enumerable.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Enumerable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                            IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Enumerable.Indexable,
                IThreadChannelActor.Enumerable.BackLink<TSource>,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IChannelActor.Indexable,
        Discord.IThreadChannelActor.Link,
        Discord.ILinkType<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.Indexable
    {
        internal new Discord.IThreadChannelActor this[Discord.IIdentifiable<ulong, Discord.IThreadChannel, Discord.IThreadChannelActor, Discord.Models.IThreadChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IThreadChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IThreadChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IThreadChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface WithArchived : 
            IThreadChannelActor.Indexable,
            IThreadChannelActor.WithArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Indexable.WithArchived,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                IThreadChannelActor.WithArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Indexable.WithArchived,
                IThreadChannelActor.Indexable.WithActive,
                IThreadChannelActor.WithArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Indexable.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithActive.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Indexable.WithArchived,
                IThreadChannelActor.Indexable.WithAnnouncementArchived,
                IThreadChannelActor.WithArchived.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.WithActive,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithArchived.WithAnnouncementArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithAnnouncementArchived : 
            IThreadChannelActor.Indexable,
            IThreadChannelActor.WithAnnouncementArchived
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Indexable.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                IThreadChannelActor.WithAnnouncementArchived.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithActive : 
                IThreadChannelActor.Indexable.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithActive,
                IThreadChannelActor.WithAnnouncementArchived.WithActive
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived,
                    IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.WithArchived,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithActive.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Indexable.WithAnnouncementArchived,
                IThreadChannelActor.Indexable.WithArchived,
                IThreadChannelActor.WithAnnouncementArchived.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithActive : 
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive,
                    IThreadChannelActor.Indexable.WithArchived.WithActive,
                    IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.WithActive,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithActive.BackLink<TSource>,
                        IThreadChannelActor.WithAnnouncementArchived.WithArchived.WithActive.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface WithActive : 
            IThreadChannelActor.Indexable,
            IThreadChannelActor.WithActive
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                IThreadChannelActor.Indexable.WithActive,
                IThreadChannelActor.Indexable.BackLink<TSource>,
                IThreadChannelActor.WithActive.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithAnnouncementArchived : 
                IThreadChannelActor.Indexable.WithActive,
                IThreadChannelActor.Indexable.WithAnnouncementArchived,
                IThreadChannelActor.WithActive.WithAnnouncementArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithArchived : 
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived,
                    IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.WithArchived,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithAnnouncementArchived.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithAnnouncementArchived.WithArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithArchived : 
                IThreadChannelActor.Indexable.WithActive,
                IThreadChannelActor.Indexable.WithArchived,
                IThreadChannelActor.WithActive.WithArchived
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                    IThreadChannelActor.Indexable.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.BackLink<TSource>,
                    IThreadChannelActor.Indexable.WithArchived.BackLink<TSource>,
                    IThreadChannelActor.WithActive.WithArchived.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithAnnouncementArchived : 
                    IThreadChannelActor.Indexable.WithActive.WithArchived,
                    IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived,
                    IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived,
                    IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.WithAnnouncementArchived,
                        IThreadChannelActor.Indexable.WithActive.WithArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithActive.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.Indexable.WithArchived.WithAnnouncementArchived.BackLink<TSource>,
                        IThreadChannelActor.WithActive.WithArchived.WithAnnouncementArchived.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
            IThreadChannelActor.Indexable,
            IThreadChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IThreadChannelActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel, Discord.Models.IThreadChannelModel>,
        Discord.IChannelActor.Link
    {
        Discord.IThreadChannelActor Discord.IActorProvider<Discord.IThreadChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadChannel Discord.IEntityProvider<Discord.IThreadChannel, Discord.Models.IThreadChannelModel>.CreateEntity(Discord.Models.IThreadChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
