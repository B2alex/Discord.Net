using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IChannelActor
{
    public new interface Paged<in TParams> : 
        Discord.IChannelActor.Link,
        Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IChannel> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IChannel> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface Hierarchy : 
            IChannelActor.Paged<TParams>,
            IChannelActor.Hierarchy
        {
            Discord.IDMChannelActor.Paged<TParams> DM { get; }
        
            Discord.IGroupChannelActor.Paged<TParams> Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Paged<TParams>.Hierarchy,
                IChannelActor.Paged<TParams>.BackLink<TSource>,
                IChannelActor.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IDMChannelActor.Paged<TParams>.Hierarchy DM { get; }
            
                Discord.IGroupChannelActor.Paged<TParams>.Hierarchy Group { get; }
            
                Discord.IDMChannelActor.Paged<TParams> IChannelActor.Paged<TParams>.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Paged<TParams> IChannelActor.Paged<TParams>.Hierarchy.Group => Group;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Paged<TParams>,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelActor.Paged<TParams>,
            IChannelActor.Indexable
        {
            public interface Hierarchy : 
                IChannelActor.Paged<TParams>.Indexable,
                IChannelActor.Paged<TParams>.Hierarchy,
                IChannelActor.Indexable.Hierarchy
            {
                Discord.IDMChannelActor.Paged<TParams>.Indexable DM { get; }
            
                Discord.IGroupChannelActor.Paged<TParams>.Indexable Group { get; }
            
                Discord.IDMChannelActor.Paged<TParams> IChannelActor.Paged<TParams>.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Paged<TParams> IChannelActor.Paged<TParams>.Hierarchy.Group => Group;
                Discord.IDMChannelActor.Indexable IChannelActor.Indexable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Indexable IChannelActor.Indexable.Hierarchy.Group => Group;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Paged<TParams>.Indexable.Hierarchy,
                    IChannelActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IChannelActor.Paged<TParams>.Hierarchy.BackLink<TSource>,
                    IChannelActor.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IDMChannelActor.Paged<TParams>.Indexable.Hierarchy DM { get; }
                
                    Discord.IGroupChannelActor.Paged<TParams>.Indexable.Hierarchy Group { get; }
                
                    Discord.IDMChannelActor.Paged<TParams>.Indexable IChannelActor.Paged<TParams>.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Paged<TParams>.Indexable IChannelActor.Paged<TParams>.Indexable.Hierarchy.Group => Group;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Paged<TParams>.Indexable,
                IChannelActor.Paged<TParams>.BackLink<TSource>,
                IChannelActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IChannelActor.Link,
        Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface Hierarchy : 
            IChannelActor.Paged<TPaged, TParams>,
            IChannelActor.Hierarchy
        {
            Discord.IDMChannelActor.Paged<TPaged, TParams> DM { get; }
        
            Discord.IGroupChannelActor.Paged<TPaged, TParams> Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Paged<TPaged, TParams>.Hierarchy,
                IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IChannelActor.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IDMChannelActor.Paged<TPaged, TParams>.Hierarchy DM { get; }
            
                Discord.IGroupChannelActor.Paged<TPaged, TParams>.Hierarchy Group { get; }
            
                Discord.IDMChannelActor.Paged<TPaged, TParams> IChannelActor.Paged<TPaged, TParams>.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Paged<TPaged, TParams> IChannelActor.Paged<TPaged, TParams>.Hierarchy.Group => Group;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Paged<TPaged, TParams>,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelActor.Paged<TPaged, TParams>,
            IChannelActor.Indexable
        {
            public interface Hierarchy : 
                IChannelActor.Paged<TPaged, TParams>.Indexable,
                IChannelActor.Paged<TPaged, TParams>.Hierarchy,
                IChannelActor.Indexable.Hierarchy
            {
                Discord.IDMChannelActor.Paged<TPaged, TParams>.Indexable DM { get; }
            
                Discord.IGroupChannelActor.Paged<TPaged, TParams>.Indexable Group { get; }
            
                Discord.IDMChannelActor.Paged<TPaged, TParams> IChannelActor.Paged<TPaged, TParams>.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Paged<TPaged, TParams> IChannelActor.Paged<TPaged, TParams>.Hierarchy.Group => Group;
                Discord.IDMChannelActor.Indexable IChannelActor.Indexable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Indexable IChannelActor.Indexable.Hierarchy.Group => Group;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy,
                    IChannelActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IChannelActor.Paged<TPaged, TParams>.Hierarchy.BackLink<TSource>,
                    IChannelActor.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IDMChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy DM { get; }
                
                    Discord.IGroupChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy Group { get; }
                
                    Discord.IDMChannelActor.Paged<TPaged, TParams>.Indexable IChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Paged<TPaged, TParams>.Indexable IChannelActor.Paged<TPaged, TParams>.Indexable.Hierarchy.Group => Group;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Paged<TPaged, TParams>.Indexable,
                IChannelActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IChannelActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IChannelActor.Link,
        Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Defined.Ids => Ids;
    
    
        public interface Hierarchy : 
            IChannelActor.Defined,
            IChannelActor.Hierarchy
        {
            Discord.IDMChannelActor.Defined DM { get; }
        
            Discord.IGroupChannelActor.Defined Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Defined.Hierarchy,
                IChannelActor.Defined.BackLink<TSource>,
                IChannelActor.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IDMChannelActor.Defined.Hierarchy DM { get; }
            
                Discord.IGroupChannelActor.Defined.Hierarchy Group { get; }
            
                Discord.IDMChannelActor.Defined IChannelActor.Defined.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Defined IChannelActor.Defined.Hierarchy.Group => Group;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Defined,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelActor.Defined,
            IChannelActor.Indexable
        {
            public interface Hierarchy : 
                IChannelActor.Defined.Indexable,
                IChannelActor.Defined.Hierarchy,
                IChannelActor.Indexable.Hierarchy
            {
                Discord.IDMChannelActor.Defined.Indexable DM { get; }
            
                Discord.IGroupChannelActor.Defined.Indexable Group { get; }
            
                Discord.IDMChannelActor.Defined IChannelActor.Defined.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Defined IChannelActor.Defined.Hierarchy.Group => Group;
                Discord.IDMChannelActor.Indexable IChannelActor.Indexable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Indexable IChannelActor.Indexable.Hierarchy.Group => Group;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Defined.Indexable.Hierarchy,
                    IChannelActor.Defined.Indexable.BackLink<TSource>,
                    IChannelActor.Defined.Hierarchy.BackLink<TSource>,
                    IChannelActor.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IDMChannelActor.Defined.Indexable.Hierarchy DM { get; }
                
                    Discord.IGroupChannelActor.Defined.Indexable.Hierarchy Group { get; }
                
                    Discord.IDMChannelActor.Defined.Indexable IChannelActor.Defined.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Defined.Indexable IChannelActor.Defined.Indexable.Hierarchy.Group => Group;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Defined.Indexable,
                IChannelActor.Defined.BackLink<TSource>,
                IChannelActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IChannelActor.Defined,
            IChannelActor.Enumerable
        {
            public interface Hierarchy : 
                IChannelActor.Defined.Enumerable,
                IChannelActor.Defined.Hierarchy,
                IChannelActor.Enumerable.Hierarchy
            {
                Discord.IDMChannelActor.Defined.Enumerable DM { get; }
            
                Discord.IGroupChannelActor.Defined.Enumerable Group { get; }
            
                Discord.IDMChannelActor.Defined IChannelActor.Defined.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Defined IChannelActor.Defined.Hierarchy.Group => Group;
                Discord.IDMChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.Group => Group;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Defined.Enumerable.Hierarchy,
                    IChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IChannelActor.Defined.Hierarchy.BackLink<TSource>,
                    IChannelActor.Enumerable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IDMChannelActor.Defined.Enumerable.Hierarchy DM { get; }
                
                    Discord.IGroupChannelActor.Defined.Enumerable.Hierarchy Group { get; }
                
                    Discord.IDMChannelActor.Defined.Enumerable IChannelActor.Defined.Enumerable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Defined.Enumerable IChannelActor.Defined.Enumerable.Hierarchy.Group => Group;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Defined.Enumerable,
                IChannelActor.Defined.BackLink<TSource>,
                IChannelActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IChannelActor.Defined.Enumerable,
                IChannelActor.Defined.Indexable,
                IChannelActor.Enumerable.Indexable
            {
                public interface Hierarchy : 
                    IChannelActor.Defined.Enumerable.Indexable,
                    IChannelActor.Defined.Enumerable.Hierarchy,
                    IChannelActor.Defined.Indexable.Hierarchy,
                    IChannelActor.Enumerable.Indexable.Hierarchy
                {
                    Discord.IDMChannelActor.Defined.Enumerable.Indexable DM { get; }
                
                    Discord.IGroupChannelActor.Defined.Enumerable.Indexable Group { get; }
                
                    Discord.IDMChannelActor.Defined.Enumerable IChannelActor.Defined.Enumerable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Defined.Enumerable IChannelActor.Defined.Enumerable.Hierarchy.Group => Group;
                    Discord.IDMChannelActor.Defined.Indexable IChannelActor.Defined.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Defined.Indexable IChannelActor.Defined.Indexable.Hierarchy.Group => Group;
                    Discord.IDMChannelActor.Enumerable.Indexable IChannelActor.Enumerable.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Enumerable.Indexable IChannelActor.Enumerable.Indexable.Hierarchy.Group => Group;
                
                
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                        IChannelActor.Defined.Enumerable.Indexable.Hierarchy,
                        IChannelActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IChannelActor.Defined.Enumerable.Hierarchy.BackLink<TSource>,
                        IChannelActor.Defined.Indexable.Hierarchy.BackLink<TSource>,
                        IChannelActor.Enumerable.Indexable.Hierarchy.BackLink<TSource>
                        where TSource : class, IPathable
                    {
                        Discord.IDMChannelActor.Defined.Enumerable.Indexable.Hierarchy DM { get; }
                    
                        Discord.IGroupChannelActor.Defined.Enumerable.Indexable.Hierarchy Group { get; }
                    
                        Discord.IDMChannelActor.Defined.Enumerable.Indexable IChannelActor.Defined.Enumerable.Indexable.Hierarchy.DM => DM;
                        Discord.IGroupChannelActor.Defined.Enumerable.Indexable IChannelActor.Defined.Enumerable.Indexable.Hierarchy.Group => Group;
                    }
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Defined.Enumerable.Indexable,
                    IChannelActor.Defined.Enumerable.BackLink<TSource>,
                    IChannelActor.Defined.Indexable.BackLink<TSource>,
                    IChannelActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IChannelActor.Link,
        Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IChannel>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IChannel>> Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface Hierarchy : 
            IChannelActor.Enumerable,
            IChannelActor.Hierarchy
        {
            Discord.IDMChannelActor.Enumerable DM { get; }
        
            Discord.IGroupChannelActor.Enumerable Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Enumerable.Hierarchy,
                IChannelActor.Enumerable.BackLink<TSource>,
                IChannelActor.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IDMChannelActor.Enumerable.Hierarchy DM { get; }
            
                Discord.IGroupChannelActor.Enumerable.Hierarchy Group { get; }
            
                Discord.IDMChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.Group => Group;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Enumerable,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IChannelActor.Enumerable,
            IChannelActor.Indexable
        {
            public interface Hierarchy : 
                IChannelActor.Enumerable.Indexable,
                IChannelActor.Enumerable.Hierarchy,
                IChannelActor.Indexable.Hierarchy
            {
                Discord.IDMChannelActor.Enumerable.Indexable DM { get; }
            
                Discord.IGroupChannelActor.Enumerable.Indexable Group { get; }
            
                Discord.IDMChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Enumerable IChannelActor.Enumerable.Hierarchy.Group => Group;
                Discord.IDMChannelActor.Indexable IChannelActor.Indexable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Indexable IChannelActor.Indexable.Hierarchy.Group => Group;
            
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                    IChannelActor.Enumerable.Indexable.Hierarchy,
                    IChannelActor.Enumerable.Indexable.BackLink<TSource>,
                    IChannelActor.Enumerable.Hierarchy.BackLink<TSource>,
                    IChannelActor.Indexable.Hierarchy.BackLink<TSource>
                    where TSource : class, IPathable
                {
                    Discord.IDMChannelActor.Enumerable.Indexable.Hierarchy DM { get; }
                
                    Discord.IGroupChannelActor.Enumerable.Indexable.Hierarchy Group { get; }
                
                    Discord.IDMChannelActor.Enumerable.Indexable IChannelActor.Enumerable.Indexable.Hierarchy.DM => DM;
                    Discord.IGroupChannelActor.Enumerable.Indexable IChannelActor.Enumerable.Indexable.Hierarchy.Group => Group;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Enumerable.Indexable,
                IChannelActor.Enumerable.BackLink<TSource>,
                IChannelActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IChannelActor.Link,
        Discord.ILinkType<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>.Indexable
    {
        internal Discord.IChannelActor this[Discord.IIdentifiable<ulong, Discord.IChannel, Discord.IChannelActor, Discord.Models.IChannelModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface Hierarchy : 
            IChannelActor.Indexable,
            IChannelActor.Hierarchy
        {
            Discord.IDMChannelActor.Indexable DM { get; }
        
            Discord.IGroupChannelActor.Indexable Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
                IChannelActor.Indexable.Hierarchy,
                IChannelActor.Indexable.BackLink<TSource>,
                IChannelActor.Hierarchy.BackLink<TSource>
                where TSource : class, IPathable
            {
                Discord.IDMChannelActor.Indexable.Hierarchy DM { get; }
            
                Discord.IGroupChannelActor.Indexable.Hierarchy Group { get; }
            
                Discord.IDMChannelActor.Indexable IChannelActor.Indexable.Hierarchy.DM => DM;
                Discord.IGroupChannelActor.Indexable IChannelActor.Indexable.Hierarchy.Group => Group;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Indexable,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
        Discord.IChannelActor
        where TSource : class, IPathable;

    public interface Hierarchy
    {
        Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> DM { get; }
    
        Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> Group { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>,
            IChannelActor.Hierarchy,
            IChannelActor.BackLink<TSource>
            where TSource : class, IPathable
        {
            Discord.IDMChannelActor.Hierarchy DM { get; }
        
            Discord.IGroupChannelActor.Hierarchy Group { get; }
        
            Discord.ILink<Discord.IDMChannelActor, ulong, Discord.IDMChannel, Discord.Models.IDMChannelModel> IChannelActor.Hierarchy.DM => DM;
            Discord.ILink<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel, Discord.Models.IGroupDMChannelModel> IChannelActor.Hierarchy.Group => Group;
        }
    }

    public interface Link : 
        Discord.ILink<Discord.IChannelActor, ulong, Discord.IChannel, Discord.Models.IChannelModel>
    {
        Discord.IChannelActor Discord.IActorProvider<Discord.IChannelActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IChannel Discord.IEntityProvider<Discord.IChannel, Discord.Models.IChannelModel>.CreateEntity(Discord.Models.IChannelModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
