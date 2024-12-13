using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IChannelActor.Paged<TParams>,
        Discord.IGuildChannelActor.Link,
        Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildChannel> Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface Hierarchy : 
            IGuildChannelActor.Paged<TParams>,
            IGuildChannelActor.Hierarchy
        {
            Discord.IVoiceChannelActor.Paged<TParams> Voice { get; }
        
            Discord.ITextChannelActor.Paged<TParams> Text { get; }
        
            Discord.IStageChannelActor.Paged<TParams> Stage { get; }
        
            Discord.IAnnouncementChannelActor.Paged<TParams> Announcement { get; }
        
            Discord.IMediaChannelActor.Paged<TParams> Media { get; }
        
            Discord.IForumChannelActor.Paged<TParams> Forum { get; }
        
            Discord.ICategoryChannelActor.Paged<TParams> Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Paged<TParams>.Hierarchy,
                IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelActor.Hierarchy.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IVoiceChannelActor.Paged<TParams>.Hierarchy Voice { get; }
            
                Discord.ITextChannelActor.Paged<TParams>.Hierarchy Text { get; }
            
                Discord.IStageChannelActor.Paged<TParams>.Hierarchy Stage { get; }
            
                Discord.IAnnouncementChannelActor.Paged<TParams>.Hierarchy Announcement { get; }
            
                Discord.IMediaChannelActor.Paged<TParams>.Hierarchy Media { get; }
            
                Discord.IForumChannelActor.Paged<TParams>.Hierarchy Forum { get; }
            
                Discord.ICategoryChannelActor.Paged<TParams>.Hierarchy Category { get; }
            
                Discord.IVoiceChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Category => Category;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Paged<TParams>,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelActor.Paged<TParams>,
            IGuildChannelActor.Indexable,
            Discord.IChannelActor.Paged<TParams>.Indexable
        {
            public interface Hierarchy : 
                IGuildChannelActor.Paged<TParams>.Indexable,
                IGuildChannelActor.Paged<TParams>.Hierarchy,
                IGuildChannelActor.Indexable.Hierarchy
            {
                Discord.IVoiceChannelActor.Paged<TParams>.Indexable Voice { get; }
            
                Discord.ITextChannelActor.Paged<TParams>.Indexable Text { get; }
            
                Discord.IStageChannelActor.Paged<TParams>.Indexable Stage { get; }
            
                Discord.IAnnouncementChannelActor.Paged<TParams>.Indexable Announcement { get; }
            
                Discord.IMediaChannelActor.Paged<TParams>.Indexable Media { get; }
            
                Discord.IForumChannelActor.Paged<TParams>.Indexable Forum { get; }
            
                Discord.ICategoryChannelActor.Paged<TParams>.Indexable Category { get; }
            
                Discord.IVoiceChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Paged<TParams> IGuildChannelActor.Paged<TParams>.Hierarchy.Category => Category;
                Discord.IVoiceChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Category => Category;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy,
                    IGuildChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelActor.Paged<TParams>.Hierarchy.BackLink<TSource>,
                    IGuildChannelActor.Indexable.Hierarchy.BackLink<TSource>,
                    Discord.IChannelActor.Paged<TParams>.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IVoiceChannelActor.Paged<TParams>.Indexable.Hierarchy Voice { get; }
                
                    Discord.ITextChannelActor.Paged<TParams>.Indexable.Hierarchy Text { get; }
                
                    Discord.IStageChannelActor.Paged<TParams>.Indexable.Hierarchy Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Paged<TParams>.Indexable.Hierarchy Announcement { get; }
                
                    Discord.IMediaChannelActor.Paged<TParams>.Indexable.Hierarchy Media { get; }
                
                    Discord.IForumChannelActor.Paged<TParams>.Indexable.Hierarchy Forum { get; }
                
                    Discord.ICategoryChannelActor.Paged<TParams>.Indexable.Hierarchy Category { get; }
                
                    Discord.IVoiceChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Paged<TParams>.Indexable IGuildChannelActor.Paged<TParams>.Indexable.Hierarchy.Category => Category;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Paged<TParams>.Indexable,
                IGuildChannelActor.Paged<TParams>.BackLink<TSource>,
                IGuildChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IChannelActor.Paged<TPaged, TParams>,
        Discord.IGuildChannelActor.Link,
        Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface Hierarchy : 
            IGuildChannelActor.Paged<TPaged, TParams>,
            IGuildChannelActor.Hierarchy
        {
            Discord.IVoiceChannelActor.Paged<TPaged, TParams> Voice { get; }
        
            Discord.ITextChannelActor.Paged<TPaged, TParams> Text { get; }
        
            Discord.IStageChannelActor.Paged<TPaged, TParams> Stage { get; }
        
            Discord.IAnnouncementChannelActor.Paged<TPaged, TParams> Announcement { get; }
        
            Discord.IMediaChannelActor.Paged<TPaged, TParams> Media { get; }
        
            Discord.IForumChannelActor.Paged<TPaged, TParams> Forum { get; }
        
            Discord.ICategoryChannelActor.Paged<TPaged, TParams> Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy,
                IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelActor.Hierarchy.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Hierarchy Voice { get; }
            
                Discord.ITextChannelActor.Paged<TPaged, TParams>.Hierarchy Text { get; }
            
                Discord.IStageChannelActor.Paged<TPaged, TParams>.Hierarchy Stage { get; }
            
                Discord.IAnnouncementChannelActor.Paged<TPaged, TParams>.Hierarchy Announcement { get; }
            
                Discord.IMediaChannelActor.Paged<TPaged, TParams>.Hierarchy Media { get; }
            
                Discord.IForumChannelActor.Paged<TPaged, TParams>.Hierarchy Forum { get; }
            
                Discord.ICategoryChannelActor.Paged<TPaged, TParams>.Hierarchy Category { get; }
            
                Discord.IVoiceChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Category => Category;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Paged<TPaged, TParams>,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelActor.Paged<TPaged, TParams>,
            IGuildChannelActor.Indexable,
            Discord.IChannelActor.Paged<TPaged, TParams>.Indexable
        {
            public interface Hierarchy : 
                IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy,
                IGuildChannelActor.Indexable.Hierarchy
            {
                Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Indexable Voice { get; }
            
                Discord.ITextChannelActor.Paged<TPaged, TParams>.Indexable Text { get; }
            
                Discord.IStageChannelActor.Paged<TPaged, TParams>.Indexable Stage { get; }
            
                Discord.IAnnouncementChannelActor.Paged<TPaged, TParams>.Indexable Announcement { get; }
            
                Discord.IMediaChannelActor.Paged<TPaged, TParams>.Indexable Media { get; }
            
                Discord.IForumChannelActor.Paged<TPaged, TParams>.Indexable Forum { get; }
            
                Discord.ICategoryChannelActor.Paged<TPaged, TParams>.Indexable Category { get; }
            
                Discord.IVoiceChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Paged<TPaged, TParams> IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.Category => Category;
                Discord.IVoiceChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Category => Category;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy,
                    IGuildChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IGuildChannelActor.Paged<TPaged, TParams>.Hierarchy.BackLink<TSource>,
                    IGuildChannelActor.Indexable.Hierarchy.BackLink<TSource>,
                    Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Voice { get; }
                
                    Discord.ITextChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Text { get; }
                
                    Discord.IStageChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Announcement { get; }
                
                    Discord.IMediaChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Media { get; }
                
                    Discord.IForumChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Forum { get; }
                
                    Discord.ICategoryChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Category { get; }
                
                    Discord.IVoiceChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Paged<TPaged, TParams>.Indexable IGuildChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Category => Category;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Paged<TPaged, TParams>.Indexable,
                IGuildChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IChannelActor.Defined,
        Discord.IGuildChannelActor.Link,
        Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface Hierarchy : 
            IGuildChannelActor.Defined,
            IGuildChannelActor.Hierarchy
        {
            Discord.IVoiceChannelActor.Defined Voice { get; }
        
            Discord.ITextChannelActor.Defined Text { get; }
        
            Discord.IStageChannelActor.Defined Stage { get; }
        
            Discord.IAnnouncementChannelActor.Defined Announcement { get; }
        
            Discord.IMediaChannelActor.Defined Media { get; }
        
            Discord.IForumChannelActor.Defined Forum { get; }
        
            Discord.ICategoryChannelActor.Defined Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Defined.Hierarchy,
                IGuildChannelActor.Defined.BackLink<TSource>,
                IGuildChannelActor.Hierarchy.BackLink<TSource>,
                Discord.IChannelActor.Defined.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IVoiceChannelActor.Defined.Hierarchy Voice { get; }
            
                Discord.ITextChannelActor.Defined.Hierarchy Text { get; }
            
                Discord.IStageChannelActor.Defined.Hierarchy Stage { get; }
            
                Discord.IAnnouncementChannelActor.Defined.Hierarchy Announcement { get; }
            
                Discord.IMediaChannelActor.Defined.Hierarchy Media { get; }
            
                Discord.IForumChannelActor.Defined.Hierarchy Forum { get; }
            
                Discord.ICategoryChannelActor.Defined.Hierarchy Category { get; }
            
                Discord.IVoiceChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Category => Category;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Defined,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelActor.Defined,
            IGuildChannelActor.Indexable,
            Discord.IChannelActor.Defined.Indexable
        {
            public interface Hierarchy : 
                IGuildChannelActor.Defined.Indexable,
                IGuildChannelActor.Defined.Hierarchy,
                IGuildChannelActor.Indexable.Hierarchy
            {
                Discord.IVoiceChannelActor.Defined.Indexable Voice { get; }
            
                Discord.ITextChannelActor.Defined.Indexable Text { get; }
            
                Discord.IStageChannelActor.Defined.Indexable Stage { get; }
            
                Discord.IAnnouncementChannelActor.Defined.Indexable Announcement { get; }
            
                Discord.IMediaChannelActor.Defined.Indexable Media { get; }
            
                Discord.IForumChannelActor.Defined.Indexable Forum { get; }
            
                Discord.ICategoryChannelActor.Defined.Indexable Category { get; }
            
                Discord.IVoiceChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Category => Category;
                Discord.IVoiceChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Category => Category;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Defined.Indexable.Hierarchy,
                    IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelActor.Defined.Hierarchy.BackLink<TSource>,
                    IGuildChannelActor.Indexable.Hierarchy.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IVoiceChannelActor.Defined.Indexable.Hierarchy Voice { get; }
                
                    Discord.ITextChannelActor.Defined.Indexable.Hierarchy Text { get; }
                
                    Discord.IStageChannelActor.Defined.Indexable.Hierarchy Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Defined.Indexable.Hierarchy Announcement { get; }
                
                    Discord.IMediaChannelActor.Defined.Indexable.Hierarchy Media { get; }
                
                    Discord.IForumChannelActor.Defined.Indexable.Hierarchy Forum { get; }
                
                    Discord.ICategoryChannelActor.Defined.Indexable.Hierarchy Category { get; }
                
                    Discord.IVoiceChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Category => Category;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Defined.Indexable,
                IGuildChannelActor.Defined.BackLink<TSource>,
                IGuildChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildChannelActor.Defined,
            IGuildChannelActor.Enumerable,
            Discord.IChannelActor.Defined.Enumerable
        {
            public interface Hierarchy : 
                IGuildChannelActor.Defined.Enumerable,
                IGuildChannelActor.Defined.Hierarchy,
                IGuildChannelActor.Enumerable.Hierarchy
            {
                Discord.IVoiceChannelActor.Defined.Enumerable Voice { get; }
            
                Discord.ITextChannelActor.Defined.Enumerable Text { get; }
            
                Discord.IStageChannelActor.Defined.Enumerable Stage { get; }
            
                Discord.IAnnouncementChannelActor.Defined.Enumerable Announcement { get; }
            
                Discord.IMediaChannelActor.Defined.Enumerable Media { get; }
            
                Discord.IForumChannelActor.Defined.Enumerable Forum { get; }
            
                Discord.ICategoryChannelActor.Defined.Enumerable Category { get; }
            
                Discord.IVoiceChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Defined IGuildChannelActor.Defined.Hierarchy.Category => Category;
                Discord.IVoiceChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Category => Category;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Defined.Enumerable.Hierarchy,
                    IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelActor.Defined.Hierarchy.BackLink<TSource>,
                    IGuildChannelActor.Enumerable.Hierarchy.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IVoiceChannelActor.Defined.Enumerable.Hierarchy Voice { get; }
                
                    Discord.ITextChannelActor.Defined.Enumerable.Hierarchy Text { get; }
                
                    Discord.IStageChannelActor.Defined.Enumerable.Hierarchy Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Defined.Enumerable.Hierarchy Announcement { get; }
                
                    Discord.IMediaChannelActor.Defined.Enumerable.Hierarchy Media { get; }
                
                    Discord.IForumChannelActor.Defined.Enumerable.Hierarchy Forum { get; }
                
                    Discord.ICategoryChannelActor.Defined.Enumerable.Hierarchy Category { get; }
                
                    Discord.IVoiceChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Category => Category;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Defined.Enumerable,
                IGuildChannelActor.Defined.BackLink<TSource>,
                IGuildChannelActor.Enumerable.BackLink<TSource>,
                Discord.IChannelActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildChannelActor.Defined.Enumerable,
                IGuildChannelActor.Defined.Indexable,
                IGuildChannelActor.Enumerable.Indexable,
                Discord.IChannelActor.Defined.Enumerable.Indexable
            {
                public interface Hierarchy : 
                    IGuildChannelActor.Defined.Enumerable.Indexable,
                    IGuildChannelActor.Defined.Enumerable.Hierarchy,
                    IGuildChannelActor.Defined.Indexable.Hierarchy,
                    IGuildChannelActor.Enumerable.Indexable.Hierarchy
                {
                    Discord.IVoiceChannelActor.Defined.Enumerable.Indexable Voice { get; }
                
                    Discord.ITextChannelActor.Defined.Enumerable.Indexable Text { get; }
                
                    Discord.IStageChannelActor.Defined.Enumerable.Indexable Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Defined.Enumerable.Indexable Announcement { get; }
                
                    Discord.IMediaChannelActor.Defined.Enumerable.Indexable Media { get; }
                
                    Discord.IForumChannelActor.Defined.Enumerable.Indexable Forum { get; }
                
                    Discord.ICategoryChannelActor.Defined.Enumerable.Indexable Category { get; }
                
                    Discord.IVoiceChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Defined.Enumerable IGuildChannelActor.Defined.Enumerable.Hierarchy.Category => Category;
                    Discord.IVoiceChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Defined.Indexable IGuildChannelActor.Defined.Indexable.Hierarchy.Category => Category;
                    Discord.IVoiceChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Category => Category;
                
                
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                        IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy,
                        IGuildChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IGuildChannelActor.Defined.Enumerable.Hierarchy.BackLink<TSource>,
                        IGuildChannelActor.Defined.Indexable.Hierarchy.BackLink<TSource>,
                        IGuildChannelActor.Enumerable.Indexable.Hierarchy.BackLink<TSource>,
                        Discord.IChannelActor.Defined.Enumerable.Indexable.Hierarchy.BackLink<TSource>
                        where TSource : class, IPathable
                    {
                        Discord.IVoiceChannelActor.Defined.Enumerable.Indexable.Hierarchy Voice { get; }
                    
                        Discord.ITextChannelActor.Defined.Enumerable.Indexable.Hierarchy Text { get; }
                    
                        Discord.IStageChannelActor.Defined.Enumerable.Indexable.Hierarchy Stage { get; }
                    
                        Discord.IAnnouncementChannelActor.Defined.Enumerable.Indexable.Hierarchy Announcement { get; }
                    
                        Discord.IMediaChannelActor.Defined.Enumerable.Indexable.Hierarchy Media { get; }
                    
                        Discord.IForumChannelActor.Defined.Enumerable.Indexable.Hierarchy Forum { get; }
                    
                        Discord.ICategoryChannelActor.Defined.Enumerable.Indexable.Hierarchy Category { get; }
                    
                        Discord.IVoiceChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Voice => Voice;
                        Discord.ITextChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Text => Text;
                        Discord.IStageChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Stage => Stage;
                        Discord.IAnnouncementChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Announcement => Announcement;
                        Discord.IMediaChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Media => Media;
                        Discord.IForumChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Forum => Forum;
                        Discord.ICategoryChannelActor.Defined.Enumerable.Indexable IGuildChannelActor.Defined.Enumerable.Indexable.Hierarchy.Category => Category;
                    }
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Defined.Enumerable.Indexable,
                    IGuildChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildChannelActor.Defined.Indexable.BackLink<TSource>,
                    IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IChannelActor.Enumerable,
        Discord.IGuildChannelActor.Link,
        Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildChannel>> Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface Hierarchy : 
            IGuildChannelActor.Enumerable,
            IGuildChannelActor.Hierarchy
        {
            Discord.IVoiceChannelActor.Enumerable Voice { get; }
        
            Discord.ITextChannelActor.Enumerable Text { get; }
        
            Discord.IStageChannelActor.Enumerable Stage { get; }
        
            Discord.IAnnouncementChannelActor.Enumerable Announcement { get; }
        
            Discord.IMediaChannelActor.Enumerable Media { get; }
        
            Discord.IForumChannelActor.Enumerable Forum { get; }
        
            Discord.ICategoryChannelActor.Enumerable Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Enumerable.Hierarchy,
                IGuildChannelActor.Enumerable.BackLink<TSource>,
                IGuildChannelActor.Hierarchy.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IVoiceChannelActor.Enumerable.Hierarchy Voice { get; }
            
                Discord.ITextChannelActor.Enumerable.Hierarchy Text { get; }
            
                Discord.IStageChannelActor.Enumerable.Hierarchy Stage { get; }
            
                Discord.IAnnouncementChannelActor.Enumerable.Hierarchy Announcement { get; }
            
                Discord.IMediaChannelActor.Enumerable.Hierarchy Media { get; }
            
                Discord.IForumChannelActor.Enumerable.Hierarchy Forum { get; }
            
                Discord.ICategoryChannelActor.Enumerable.Hierarchy Category { get; }
            
                Discord.IVoiceChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Category => Category;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Enumerable,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildChannelActor.Enumerable,
            IGuildChannelActor.Indexable,
            Discord.IChannelActor.Enumerable.Indexable
        {
            public interface Hierarchy : 
                IGuildChannelActor.Enumerable.Indexable,
                IGuildChannelActor.Enumerable.Hierarchy,
                IGuildChannelActor.Indexable.Hierarchy
            {
                Discord.IVoiceChannelActor.Enumerable.Indexable Voice { get; }
            
                Discord.ITextChannelActor.Enumerable.Indexable Text { get; }
            
                Discord.IStageChannelActor.Enumerable.Indexable Stage { get; }
            
                Discord.IAnnouncementChannelActor.Enumerable.Indexable Announcement { get; }
            
                Discord.IMediaChannelActor.Enumerable.Indexable Media { get; }
            
                Discord.IForumChannelActor.Enumerable.Indexable Forum { get; }
            
                Discord.ICategoryChannelActor.Enumerable.Indexable Category { get; }
            
                Discord.IVoiceChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Enumerable IGuildChannelActor.Enumerable.Hierarchy.Category => Category;
                Discord.IVoiceChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Category => Category;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                    IGuildChannelActor.Enumerable.Indexable.Hierarchy,
                    IGuildChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IGuildChannelActor.Enumerable.Hierarchy.BackLink<TSource>,
                    IGuildChannelActor.Indexable.Hierarchy.BackLink<TSource>,
                    Discord.IChannelActor.Enumerable.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IVoiceChannelActor.Enumerable.Indexable.Hierarchy Voice { get; }
                
                    Discord.ITextChannelActor.Enumerable.Indexable.Hierarchy Text { get; }
                
                    Discord.IStageChannelActor.Enumerable.Indexable.Hierarchy Stage { get; }
                
                    Discord.IAnnouncementChannelActor.Enumerable.Indexable.Hierarchy Announcement { get; }
                
                    Discord.IMediaChannelActor.Enumerable.Indexable.Hierarchy Media { get; }
                
                    Discord.IForumChannelActor.Enumerable.Indexable.Hierarchy Forum { get; }
                
                    Discord.ICategoryChannelActor.Enumerable.Indexable.Hierarchy Category { get; }
                
                    Discord.IVoiceChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Voice => Voice;
                    Discord.ITextChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Text => Text;
                    Discord.IStageChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Stage => Stage;
                    Discord.IAnnouncementChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Announcement => Announcement;
                    Discord.IMediaChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Media => Media;
                    Discord.IForumChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Forum => Forum;
                    Discord.ICategoryChannelActor.Enumerable.Indexable IGuildChannelActor.Enumerable.Indexable.Hierarchy.Category => Category;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Enumerable.Indexable,
                IGuildChannelActor.Enumerable.BackLink<TSource>,
                IGuildChannelActor.Indexable.BackLink<TSource>,
                Discord.IChannelActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IChannelActor.Indexable,
        Discord.IGuildChannelActor.Link,
        Discord.ILinkType<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.Indexable
    {
        internal new Discord.IGuildChannelActor this[Discord.IIdentifiable<ulong, Discord.IGuildChannel, Discord.IGuildChannelActor, Discord.Models.IGuildChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IGuildChannelActor this[ulong id] => (this as Discord.IActorProvider<Discord.IGuildChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IGuildChannelActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IGuildChannelActor, ulong>).GetActor(id);
    
        Discord.IChannelActor Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface Hierarchy : 
            IGuildChannelActor.Indexable,
            IGuildChannelActor.Hierarchy
        {
            Discord.IVoiceChannelActor.Indexable Voice { get; }
        
            Discord.ITextChannelActor.Indexable Text { get; }
        
            Discord.IStageChannelActor.Indexable Stage { get; }
        
            Discord.IAnnouncementChannelActor.Indexable Announcement { get; }
        
            Discord.IMediaChannelActor.Indexable Media { get; }
        
            Discord.IForumChannelActor.Indexable Forum { get; }
        
            Discord.ICategoryChannelActor.Indexable Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
                IGuildChannelActor.Indexable.Hierarchy,
                IGuildChannelActor.Indexable.BackLink<TSource>,
                IGuildChannelActor.Hierarchy.BackLink<TSource>,
                Discord.IChannelActor.Indexable.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IVoiceChannelActor.Indexable.Hierarchy Voice { get; }
            
                Discord.ITextChannelActor.Indexable.Hierarchy Text { get; }
            
                Discord.IStageChannelActor.Indexable.Hierarchy Stage { get; }
            
                Discord.IAnnouncementChannelActor.Indexable.Hierarchy Announcement { get; }
            
                Discord.IMediaChannelActor.Indexable.Hierarchy Media { get; }
            
                Discord.IForumChannelActor.Indexable.Hierarchy Forum { get; }
            
                Discord.ICategoryChannelActor.Indexable.Hierarchy Category { get; }
            
                Discord.IVoiceChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Voice => Voice;
                Discord.ITextChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Text => Text;
                Discord.IStageChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Stage => Stage;
                Discord.IAnnouncementChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Announcement => Announcement;
                Discord.IMediaChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Media => Media;
                Discord.IForumChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Forum => Forum;
                Discord.ICategoryChannelActor.Indexable IGuildChannelActor.Indexable.Hierarchy.Category => Category;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Indexable,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
        Discord.IChannelActor.BackLink<TSource>,
        Discord.IGuildChannelActor
        where TSource : class, IPathable;

    public interface Hierarchy
    {
        Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> Voice { get; }
    
        Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> Text { get; }
    
        Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> Stage { get; }
    
        Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> Announcement { get; }
    
        Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> Media { get; }
    
        Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> Forum { get; }
    
        Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> Category { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
            IGuildChannelActor.Hierarchy,
            IGuildChannelActor.BackLink<TSource>,
            Discord.IChannelActor.Hierarchy.BackLink<TSource>
            where TSource : class, IPathable
        {
            Discord.IVoiceChannelActor.Hierarchy Voice { get; }
        
            Discord.ITextChannelActor.Hierarchy Text { get; }
        
            Discord.IStageChannelActor.Hierarchy Stage { get; }
        
            Discord.IAnnouncementChannelActor.Hierarchy Announcement { get; }
        
            Discord.IMediaChannelActor.Hierarchy Media { get; }
        
            Discord.IForumChannelActor.Hierarchy Forum { get; }
        
            Discord.ICategoryChannelActor.Hierarchy Category { get; }
        
            Discord.ILink<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel, Discord.Models.IGuildVoiceChannelModel> IGuildChannelActor.Hierarchy.Voice => Voice;
            Discord.ILink<Discord.ITextChannelActor, ulong, Discord.ITextChannel, Discord.Models.IGuildTextChannelModel> IGuildChannelActor.Hierarchy.Text => Text;
            Discord.ILink<Discord.IStageChannelActor, ulong, Discord.IStageChannel, Discord.Models.IGuildStageChannelModel> IGuildChannelActor.Hierarchy.Stage => Stage;
            Discord.ILink<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel, Discord.Models.IGuildNewsChannelModel> IGuildChannelActor.Hierarchy.Announcement => Announcement;
            Discord.ILink<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel, Discord.Models.IGuildMediaChannelModel> IGuildChannelActor.Hierarchy.Media => Media;
            Discord.ILink<Discord.IForumChannelActor, ulong, Discord.IForumChannel, Discord.Models.IGuildForumChannelModel> IGuildChannelActor.Hierarchy.Forum => Forum;
            Discord.ILink<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel, Discord.Models.IGuildCategoryChannelModel> IGuildChannelActor.Hierarchy.Category => Category;
        }
    }

    public interface Link : 
        Discord.ILink<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel, Discord.Models.IGuildChannelModel>,
        Discord.IChannelActor.Link
    {
        Discord.IGuildChannelActor Discord.IActorProvider<Discord.IGuildChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildChannel Discord.IEntityProvider<Discord.IGuildChannel, Discord.Models.IGuildChannelModel>.CreateEntity(Discord.Models.IGuildChannelModel model) => CreateEntity(model);
    
        Discord.IChannelActor Discord.IChannelActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IChannelActor.Link.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
