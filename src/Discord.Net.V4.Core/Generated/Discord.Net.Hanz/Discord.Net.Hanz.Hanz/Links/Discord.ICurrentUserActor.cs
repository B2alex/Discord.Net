using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentUserActor
{
    public new interface Paged<in TParams> : 
        Discord.IUserActor.Paged<TParams>,
        Discord.ICurrentUserActor.Link,
        Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ICurrentUser> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ICurrentUser> Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IUser> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
            ICurrentUserActor.Paged<TParams>,
            ICurrentUserActor.BackLink<TSource>,
            Discord.IUserActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserActor.Paged<TParams>,
            ICurrentUserActor.Indexable,
            Discord.IUserActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                ICurrentUserActor.Paged<TParams>.Indexable,
                ICurrentUserActor.Paged<TParams>.BackLink<TSource>,
                ICurrentUserActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IUserActor.Paged<TPaged, TParams>,
        Discord.ICurrentUserActor.Link,
        Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
            ICurrentUserActor.Paged<TPaged, TParams>,
            ICurrentUserActor.BackLink<TSource>,
            Discord.IUserActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserActor.Paged<TPaged, TParams>,
            ICurrentUserActor.Indexable,
            Discord.IUserActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                ICurrentUserActor.Paged<TPaged, TParams>.Indexable,
                ICurrentUserActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ICurrentUserActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IUserActor.Defined,
        Discord.ICurrentUserActor.Link,
        Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
            ICurrentUserActor.Defined,
            ICurrentUserActor.BackLink<TSource>,
            Discord.IUserActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserActor.Defined,
            ICurrentUserActor.Indexable,
            Discord.IUserActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                ICurrentUserActor.Defined.Indexable,
                ICurrentUserActor.Defined.BackLink<TSource>,
                ICurrentUserActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ICurrentUserActor.Defined,
            ICurrentUserActor.Enumerable,
            Discord.IUserActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                ICurrentUserActor.Defined.Enumerable,
                ICurrentUserActor.Defined.BackLink<TSource>,
                ICurrentUserActor.Enumerable.BackLink<TSource>,
                Discord.IUserActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ICurrentUserActor.Defined.Enumerable,
                ICurrentUserActor.Defined.Indexable,
                ICurrentUserActor.Enumerable.Indexable,
                Discord.IUserActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                    ICurrentUserActor.Defined.Enumerable.Indexable,
                    ICurrentUserActor.Defined.Enumerable.BackLink<TSource>,
                    ICurrentUserActor.Defined.Indexable.BackLink<TSource>,
                    ICurrentUserActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IUserActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IUserActor.Enumerable,
        Discord.ICurrentUserActor.Link,
        Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ICurrentUser>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ICurrentUser>> Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IUser>> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
            ICurrentUserActor.Enumerable,
            ICurrentUserActor.BackLink<TSource>,
            Discord.IUserActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentUserActor.Enumerable,
            ICurrentUserActor.Indexable,
            Discord.IUserActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
                ICurrentUserActor.Enumerable.Indexable,
                ICurrentUserActor.Enumerable.BackLink<TSource>,
                ICurrentUserActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IUserActor.Indexable,
        Discord.ICurrentUserActor.Link,
        Discord.ILinkType<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>.Indexable
    {
        internal new Discord.ICurrentUserActor this[Discord.IIdentifiable<ulong, Discord.ICurrentUser, Discord.ICurrentUserActor, Discord.Models.ISelfUserModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ICurrentUserActor this[ulong id] => (this as Discord.IActorProvider<Discord.ICurrentUserActor, ulong>).GetActor(id);
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ICurrentUserActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ICurrentUserActor, ulong>).GetActor(id);
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
            ICurrentUserActor.Indexable,
            ICurrentUserActor.BackLink<TSource>,
            Discord.IUserActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
        Discord.IUserActor.BackLink<TSource>,
        Discord.ICurrentUserActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser, Discord.Models.ISelfUserModel>,
        Discord.IUserActor.Link
    {
        Discord.ICurrentUserActor Discord.IActorProvider<Discord.ICurrentUserActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ICurrentUser Discord.IEntityProvider<Discord.ICurrentUser, Discord.Models.ISelfUserModel>.CreateEntity(Discord.Models.ISelfUserModel model) => CreateEntity(model);
    
        Discord.IUserActor Discord.IUserActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IUser Discord.IUserActor.Link.CreateEntity(Discord.Models.IUserModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
