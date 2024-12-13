using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IUserActor
{
    public interface WithCurrent
    {
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.WithCurrent,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IUserActor.Link,
        Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IUser> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IUser> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IUserActor.Paged<TParams>,
            IUserActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Paged<TParams>.WithCurrent,
                IUserActor.Paged<TParams>.BackLink<TSource>,
                IUserActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.Paged<TParams>,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IUserActor.Paged<TParams>,
            IUserActor.Indexable
        {
            public interface WithCurrent : 
                IUserActor.Paged<TParams>.Indexable,
                IUserActor.Paged<TParams>.WithCurrent,
                IUserActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Paged<TParams>.Indexable.WithCurrent,
                    IUserActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IUserActor.Paged<TParams>.WithCurrent.BackLink<TSource>,
                    IUserActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Paged<TParams>.Indexable,
                IUserActor.Paged<TParams>.BackLink<TSource>,
                IUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IUserActor.Link,
        Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IUserActor.Paged<TPaged, TParams>,
            IUserActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Paged<TPaged, TParams>.WithCurrent,
                IUserActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IUserActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.Paged<TPaged, TParams>,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IUserActor.Paged<TPaged, TParams>,
            IUserActor.Indexable
        {
            public interface WithCurrent : 
                IUserActor.Paged<TPaged, TParams>.Indexable,
                IUserActor.Paged<TPaged, TParams>.WithCurrent,
                IUserActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Paged<TPaged, TParams>.Indexable.WithCurrent,
                    IUserActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IUserActor.Paged<TPaged, TParams>.WithCurrent.BackLink<TSource>,
                    IUserActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Paged<TPaged, TParams>.Indexable,
                IUserActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IUserActor.Link,
        Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Defined.Ids => Ids;
    
    
        public interface WithCurrent : 
            IUserActor.Defined,
            IUserActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Defined.WithCurrent,
                IUserActor.Defined.BackLink<TSource>,
                IUserActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.Defined,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IUserActor.Defined,
            IUserActor.Indexable
        {
            public interface WithCurrent : 
                IUserActor.Defined.Indexable,
                IUserActor.Defined.WithCurrent,
                IUserActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Defined.Indexable.WithCurrent,
                    IUserActor.Defined.Indexable.BackLink<TSource>,
                    IUserActor.Defined.WithCurrent.BackLink<TSource>,
                    IUserActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Defined.Indexable,
                IUserActor.Defined.BackLink<TSource>,
                IUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IUserActor.Defined,
            IUserActor.Enumerable
        {
            public interface WithCurrent : 
                IUserActor.Defined.Enumerable,
                IUserActor.Defined.WithCurrent,
                IUserActor.Enumerable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Defined.Enumerable.WithCurrent,
                    IUserActor.Defined.Enumerable.BackLink<TSource>,
                    IUserActor.Defined.WithCurrent.BackLink<TSource>,
                    IUserActor.Enumerable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Defined.Enumerable,
                IUserActor.Defined.BackLink<TSource>,
                IUserActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IUserActor.Defined.Enumerable,
                IUserActor.Defined.Indexable,
                IUserActor.Enumerable.Indexable
            {
                public interface WithCurrent : 
                    IUserActor.Defined.Enumerable.Indexable,
                    IUserActor.Defined.Enumerable.WithCurrent,
                    IUserActor.Defined.Indexable.WithCurrent,
                    IUserActor.Enumerable.Indexable.WithCurrent
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                        IUserActor.Defined.Enumerable.Indexable.WithCurrent,
                        IUserActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IUserActor.Defined.Enumerable.WithCurrent.BackLink<TSource>,
                        IUserActor.Defined.Indexable.WithCurrent.BackLink<TSource>,
                        IUserActor.Enumerable.Indexable.WithCurrent.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Defined.Enumerable.Indexable,
                    IUserActor.Defined.Enumerable.BackLink<TSource>,
                    IUserActor.Defined.Indexable.BackLink<TSource>,
                    IUserActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IUserActor.Link,
        Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IUser>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IUser>> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithCurrent : 
            IUserActor.Enumerable,
            IUserActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Enumerable.WithCurrent,
                IUserActor.Enumerable.BackLink<TSource>,
                IUserActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.Enumerable,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IUserActor.Enumerable,
            IUserActor.Indexable
        {
            public interface WithCurrent : 
                IUserActor.Enumerable.Indexable,
                IUserActor.Enumerable.WithCurrent,
                IUserActor.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                    IUserActor.Enumerable.Indexable.WithCurrent,
                    IUserActor.Enumerable.Indexable.BackLink<TSource>,
                    IUserActor.Enumerable.WithCurrent.BackLink<TSource>,
                    IUserActor.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Enumerable.Indexable,
                IUserActor.Enumerable.BackLink<TSource>,
                IUserActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IUserActor.Link,
        Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable
    {
        internal Discord.IUserActor this[Discord.IIdentifiable<ulong, Discord.IUser, Discord.IUserActor, Discord.Models.IUserModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface WithCurrent : 
            IUserActor.Indexable,
            IUserActor.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
                IUserActor.Indexable.WithCurrent,
                IUserActor.Indexable.BackLink<TSource>,
                IUserActor.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
            IUserActor.Indexable,
            IUserActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>,
        Discord.IUserActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>
    {
        Discord.IUserActor Discord.IActorProvider<Discord.IUserActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IUser Discord.IEntityProvider<Discord.IUser, Discord.Models.IUserModel>.CreateEntity(Discord.Models.IUserModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
