using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadMemberActor
{
    public interface WithPagedVariant
    {
        Discord.IThreadMemberActor.Paged<Discord.PageThreadMembersParams>.Indexable AsPaged { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.WithPagedVariant,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithCurrentMember : 
            IThreadMemberActor.WithPagedVariant,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public interface WithCurrentMember
    {
        Discord.IThreadMemberActor Current { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.WithCurrentMember,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public interface WithPagedVariant : 
            IThreadMemberActor.WithCurrentMember,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<in TParams> : 
        Discord.IThreadMemberActor.Link,
        Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IThreadMember> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IThreadMember> Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithPagedVariant : 
            IThreadMemberActor.Paged<TParams>,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TParams>.WithPagedVariant,
                IThreadMemberActor.Paged<TParams>.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Paged<TParams>.WithPagedVariant,
                IThreadMemberActor.Paged<TParams>.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TParams>.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Paged<TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Paged<TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithCurrentMember : 
            IThreadMemberActor.Paged<TParams>,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TParams>.WithCurrentMember,
                IThreadMemberActor.Paged<TParams>.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithPagedVariant : 
                IThreadMemberActor.Paged<TParams>.WithCurrentMember,
                IThreadMemberActor.Paged<TParams>.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TParams>.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Paged<TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Paged<TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.Paged<TParams>,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadMemberActor.Paged<TParams>,
            IThreadMemberActor.Indexable
        {
            public interface WithPagedVariant : 
                IThreadMemberActor.Paged<TParams>.Indexable,
                IThreadMemberActor.Paged<TParams>.WithPagedVariant,
                IThreadMemberActor.Indexable.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Paged<TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TParams>.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Paged<TParams>.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Paged<TParams>.Indexable,
                IThreadMemberActor.Paged<TParams>.WithCurrentMember,
                IThreadMemberActor.Indexable.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Paged<TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithPagedVariant : 
                    IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TParams>.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Paged<TParams>.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Paged<TParams>.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TParams>.Indexable,
                IThreadMemberActor.Paged<TParams>.BackLink<TSource>,
                IThreadMemberActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IThreadMemberActor.Link,
        Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithPagedVariant : 
            IThreadMemberActor.Paged<TPaged, TParams>,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant,
                IThreadMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant,
                IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithCurrentMember : 
            IThreadMemberActor.Paged<TPaged, TParams>,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember,
                IThreadMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithPagedVariant : 
                IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember,
                IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.Paged<TPaged, TParams>,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadMemberActor.Paged<TPaged, TParams>,
            IThreadMemberActor.Indexable
        {
            public interface WithPagedVariant : 
                IThreadMemberActor.Paged<TPaged, TParams>.Indexable,
                IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant,
                IThreadMemberActor.Indexable.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Paged<TPaged, TParams>.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Paged<TPaged, TParams>.Indexable,
                IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember,
                IThreadMemberActor.Indexable.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithPagedVariant : 
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember,
                    IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant,
                    IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Paged<TPaged, TParams>.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Paged<TPaged, TParams>.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Paged<TPaged, TParams>.Indexable,
                IThreadMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IThreadMemberActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IThreadMemberActor.Link,
        Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Defined.Ids => Ids;
    
    
        public interface WithPagedVariant : 
            IThreadMemberActor.Defined,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Defined.WithPagedVariant,
                IThreadMemberActor.Defined.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Defined.WithPagedVariant,
                IThreadMemberActor.Defined.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Defined.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithCurrentMember : 
            IThreadMemberActor.Defined,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Defined.WithCurrentMember,
                IThreadMemberActor.Defined.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithPagedVariant : 
                IThreadMemberActor.Defined.WithCurrentMember,
                IThreadMemberActor.Defined.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Defined.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.Defined,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadMemberActor.Defined,
            IThreadMemberActor.Indexable
        {
            public interface WithPagedVariant : 
                IThreadMemberActor.Defined.Indexable,
                IThreadMemberActor.Defined.WithPagedVariant,
                IThreadMemberActor.Indexable.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.Indexable.WithPagedVariant,
                    IThreadMemberActor.Defined.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Defined.Indexable.WithPagedVariant,
                    IThreadMemberActor.Defined.Indexable.WithCurrentMember,
                    IThreadMemberActor.Defined.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Indexable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Defined.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Defined.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Defined.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Defined.Indexable,
                IThreadMemberActor.Defined.WithCurrentMember,
                IThreadMemberActor.Indexable.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.Indexable.WithCurrentMember,
                    IThreadMemberActor.Defined.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithPagedVariant : 
                    IThreadMemberActor.Defined.Indexable.WithCurrentMember,
                    IThreadMemberActor.Defined.Indexable.WithPagedVariant,
                    IThreadMemberActor.Defined.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Indexable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Defined.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Defined.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Defined.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Defined.Indexable,
                IThreadMemberActor.Defined.BackLink<TSource>,
                IThreadMemberActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IThreadMemberActor.Defined,
            IThreadMemberActor.Enumerable
        {
            public interface WithPagedVariant : 
                IThreadMemberActor.Defined.Enumerable,
                IThreadMemberActor.Defined.WithPagedVariant,
                IThreadMemberActor.Enumerable.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.Enumerable.WithPagedVariant,
                    IThreadMemberActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Defined.Enumerable.WithPagedVariant,
                    IThreadMemberActor.Defined.Enumerable.WithCurrentMember,
                    IThreadMemberActor.Defined.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Enumerable.WithPagedVariant.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Enumerable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Defined.Enumerable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Defined.Enumerable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Defined.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Defined.Enumerable,
                IThreadMemberActor.Defined.WithCurrentMember,
                IThreadMemberActor.Enumerable.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.Enumerable.WithCurrentMember,
                    IThreadMemberActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadMemberActor.Defined.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithPagedVariant : 
                    IThreadMemberActor.Defined.Enumerable.WithCurrentMember,
                    IThreadMemberActor.Defined.Enumerable.WithPagedVariant,
                    IThreadMemberActor.Defined.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Enumerable.WithCurrentMember.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Enumerable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Defined.Enumerable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Defined.Enumerable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Defined.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Defined.Enumerable,
                IThreadMemberActor.Defined.BackLink<TSource>,
                IThreadMemberActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IThreadMemberActor.Defined.Enumerable,
                IThreadMemberActor.Defined.Indexable,
                IThreadMemberActor.Enumerable.Indexable
            {
                public interface WithPagedVariant : 
                    IThreadMemberActor.Defined.Enumerable.Indexable,
                    IThreadMemberActor.Defined.Enumerable.WithPagedVariant,
                    IThreadMemberActor.Defined.Indexable.WithPagedVariant,
                    IThreadMemberActor.Enumerable.Indexable.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant,
                        IThreadMemberActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IThreadMemberActor.Defined.Enumerable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Defined.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithCurrentMember : 
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant,
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember,
                        IThreadMemberActor.Defined.Enumerable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Defined.Indexable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.WithCurrentMember
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant.WithCurrentMember,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant.BackLink<TSource>,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember.BackLink<TSource>,
                            IThreadMemberActor.Defined.Enumerable.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                            IThreadMemberActor.Defined.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                            IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Defined.Enumerable.Indexable,
                    IThreadMemberActor.Defined.Enumerable.WithCurrentMember,
                    IThreadMemberActor.Defined.Indexable.WithCurrentMember,
                    IThreadMemberActor.Enumerable.Indexable.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember,
                        IThreadMemberActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IThreadMemberActor.Defined.Enumerable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Defined.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                
                    public interface WithPagedVariant : 
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember,
                        IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant,
                        IThreadMemberActor.Defined.Enumerable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Defined.Indexable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant
                    {
                        public interface BackLink<out TSource> : 
                            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember.WithPagedVariant,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithCurrentMember.BackLink<TSource>,
                            IThreadMemberActor.Defined.Enumerable.Indexable.WithPagedVariant.BackLink<TSource>,
                            IThreadMemberActor.Defined.Enumerable.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                            IThreadMemberActor.Defined.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                            IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                            where TSource : class, IPathable;
                    }
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Defined.Enumerable.Indexable,
                    IThreadMemberActor.Defined.Enumerable.BackLink<TSource>,
                    IThreadMemberActor.Defined.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IThreadMemberActor.Link,
        Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IThreadMember>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IThreadMember>> Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithPagedVariant : 
            IThreadMemberActor.Enumerable,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Enumerable.WithPagedVariant,
                IThreadMemberActor.Enumerable.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Enumerable.WithPagedVariant,
                IThreadMemberActor.Enumerable.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Enumerable.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Enumerable.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithCurrentMember : 
            IThreadMemberActor.Enumerable,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Enumerable.WithCurrentMember,
                IThreadMemberActor.Enumerable.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithPagedVariant : 
                IThreadMemberActor.Enumerable.WithCurrentMember,
                IThreadMemberActor.Enumerable.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Enumerable.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Enumerable.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.Enumerable,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IThreadMemberActor.Enumerable,
            IThreadMemberActor.Indexable
        {
            public interface WithPagedVariant : 
                IThreadMemberActor.Enumerable.Indexable,
                IThreadMemberActor.Enumerable.WithPagedVariant,
                IThreadMemberActor.Indexable.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Enumerable.Indexable.WithPagedVariant,
                    IThreadMemberActor.Enumerable.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithCurrentMember : 
                    IThreadMemberActor.Enumerable.Indexable.WithPagedVariant,
                    IThreadMemberActor.Enumerable.Indexable.WithCurrentMember,
                    IThreadMemberActor.Enumerable.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.WithCurrentMember,
                        IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.WithPagedVariant.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Enumerable.Indexable,
                IThreadMemberActor.Enumerable.WithCurrentMember,
                IThreadMemberActor.Indexable.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Enumerable.Indexable.WithCurrentMember,
                    IThreadMemberActor.Enumerable.Indexable.BackLink<TSource>,
                    IThreadMemberActor.Enumerable.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            
                public interface WithPagedVariant : 
                    IThreadMemberActor.Enumerable.Indexable.WithCurrentMember,
                    IThreadMemberActor.Enumerable.Indexable.WithPagedVariant,
                    IThreadMemberActor.Enumerable.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                        IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant,
                        IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.Indexable.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Enumerable.WithCurrentMember.WithPagedVariant.BackLink<TSource>,
                        IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Enumerable.Indexable,
                IThreadMemberActor.Enumerable.BackLink<TSource>,
                IThreadMemberActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IThreadMemberActor.Link,
        Discord.ILinkType<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>.Indexable
    {
        internal Discord.IThreadMemberActor this[Discord.IIdentifiable<ulong, Discord.IThreadMember, Discord.IThreadMemberActor, Discord.Models.IThreadMemberModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface WithPagedVariant : 
            IThreadMemberActor.Indexable,
            IThreadMemberActor.WithPagedVariant
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Indexable.WithPagedVariant,
                IThreadMemberActor.Indexable.BackLink<TSource>,
                IThreadMemberActor.WithPagedVariant.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithCurrentMember : 
                IThreadMemberActor.Indexable.WithPagedVariant,
                IThreadMemberActor.Indexable.WithCurrentMember,
                IThreadMemberActor.WithPagedVariant.WithCurrentMember
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Indexable.WithPagedVariant.WithCurrentMember,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.WithPagedVariant.WithCurrentMember.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface WithCurrentMember : 
            IThreadMemberActor.Indexable,
            IThreadMemberActor.WithCurrentMember
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                IThreadMemberActor.Indexable.WithCurrentMember,
                IThreadMemberActor.Indexable.BackLink<TSource>,
                IThreadMemberActor.WithCurrentMember.BackLink<TSource>
                where TSource : class, IPathable;
        
            public interface WithPagedVariant : 
                IThreadMemberActor.Indexable.WithCurrentMember,
                IThreadMemberActor.Indexable.WithPagedVariant,
                IThreadMemberActor.WithCurrentMember.WithPagedVariant
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
                    IThreadMemberActor.Indexable.WithCurrentMember.WithPagedVariant,
                    IThreadMemberActor.Indexable.WithCurrentMember.BackLink<TSource>,
                    IThreadMemberActor.Indexable.WithPagedVariant.BackLink<TSource>,
                    IThreadMemberActor.WithCurrentMember.WithPagedVariant.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
            IThreadMemberActor.Indexable,
            IThreadMemberActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>,
        Discord.IThreadMemberActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IThreadMemberActor, ulong, Discord.IThreadMember, Discord.Models.IThreadMemberModel>
    {
        Discord.IThreadMemberActor Discord.IActorProvider<Discord.IThreadMemberActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IThreadMember Discord.IEntityProvider<Discord.IThreadMember, Discord.Models.IThreadMemberModel>.CreateEntity(Discord.Models.IThreadMemberModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
