using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentMemberActor
{
    public new interface Paged<in TParams> : 
        Discord.IMemberActor.Paged<TParams>,
        Discord.ICurrentUserActor.Paged<TParams>,
        Discord.IUserActor.Paged<TParams>,
        Discord.ICurrentMemberActor.Link,
        Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.ICurrentMember> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.ICurrentMember> Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IMember> Discord.IMemberActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.ICurrentUser> Discord.ICurrentUserActor.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IUser> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
            ICurrentMemberActor.Paged<TParams>,
            ICurrentMemberActor.BackLink<TSource>,
            Discord.IMemberActor.Paged<TParams>.BackLink<TSource>,
            Discord.ICurrentUserActor.Paged<TParams>.BackLink<TSource>,
            Discord.IUserActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentMemberActor.Paged<TParams>,
            ICurrentMemberActor.Indexable,
            Discord.IMemberActor.Paged<TParams>.Indexable,
            Discord.ICurrentUserActor.Paged<TParams>.Indexable,
            Discord.IUserActor.Paged<TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                ICurrentMemberActor.Paged<TParams>.Indexable,
                ICurrentMemberActor.Paged<TParams>.BackLink<TSource>,
                ICurrentMemberActor.Indexable.BackLink<TSource>,
                Discord.IMemberActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.ICurrentUserActor.Paged<TParams>.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IMemberActor.Paged<TPaged, TParams>,
        Discord.ICurrentUserActor.Paged<TPaged, TParams>,
        Discord.IUserActor.Paged<TPaged, TParams>,
        Discord.ICurrentMemberActor.Link,
        Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.IMemberActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ICurrentUserActor.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
            ICurrentMemberActor.Paged<TPaged, TParams>,
            ICurrentMemberActor.BackLink<TSource>,
            Discord.IMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.ICurrentUserActor.Paged<TPaged, TParams>.BackLink<TSource>,
            Discord.IUserActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentMemberActor.Paged<TPaged, TParams>,
            ICurrentMemberActor.Indexable,
            Discord.IMemberActor.Paged<TPaged, TParams>.Indexable,
            Discord.ICurrentUserActor.Paged<TPaged, TParams>.Indexable,
            Discord.IUserActor.Paged<TPaged, TParams>.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                ICurrentMemberActor.Paged<TPaged, TParams>.Indexable,
                ICurrentMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                ICurrentMemberActor.Indexable.BackLink<TSource>,
                Discord.IMemberActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.ICurrentUserActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IMemberActor.Defined,
        Discord.ICurrentUserActor.Defined,
        Discord.IUserActor.Defined,
        Discord.ICurrentMemberActor.Link,
        Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.IMemberActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ICurrentUserActor.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
            ICurrentMemberActor.Defined,
            ICurrentMemberActor.BackLink<TSource>,
            Discord.IMemberActor.Defined.BackLink<TSource>,
            Discord.ICurrentUserActor.Defined.BackLink<TSource>,
            Discord.IUserActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentMemberActor.Defined,
            ICurrentMemberActor.Indexable,
            Discord.IMemberActor.Defined.Indexable,
            Discord.ICurrentUserActor.Defined.Indexable,
            Discord.IUserActor.Defined.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                ICurrentMemberActor.Defined.Indexable,
                ICurrentMemberActor.Defined.BackLink<TSource>,
                ICurrentMemberActor.Indexable.BackLink<TSource>,
                Discord.IMemberActor.Defined.Indexable.BackLink<TSource>,
                Discord.ICurrentUserActor.Defined.Indexable.BackLink<TSource>,
                Discord.IUserActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            ICurrentMemberActor.Defined,
            ICurrentMemberActor.Enumerable,
            Discord.IMemberActor.Defined.Enumerable,
            Discord.ICurrentUserActor.Defined.Enumerable,
            Discord.IUserActor.Defined.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                ICurrentMemberActor.Defined.Enumerable,
                ICurrentMemberActor.Defined.BackLink<TSource>,
                ICurrentMemberActor.Enumerable.BackLink<TSource>,
                Discord.IMemberActor.Defined.Enumerable.BackLink<TSource>,
                Discord.ICurrentUserActor.Defined.Enumerable.BackLink<TSource>,
                Discord.IUserActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                ICurrentMemberActor.Defined.Enumerable,
                ICurrentMemberActor.Defined.Indexable,
                ICurrentMemberActor.Enumerable.Indexable,
                Discord.IMemberActor.Defined.Enumerable.Indexable,
                Discord.ICurrentUserActor.Defined.Enumerable.Indexable,
                Discord.IUserActor.Defined.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                    ICurrentMemberActor.Defined.Enumerable.Indexable,
                    ICurrentMemberActor.Defined.Enumerable.BackLink<TSource>,
                    ICurrentMemberActor.Defined.Indexable.BackLink<TSource>,
                    ICurrentMemberActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IMemberActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.ICurrentUserActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IUserActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IMemberActor.Enumerable,
        Discord.ICurrentUserActor.Enumerable,
        Discord.IUserActor.Enumerable,
        Discord.ICurrentMemberActor.Link,
        Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.ICurrentMember>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.ICurrentMember>> Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IMember>> Discord.IMemberActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.ICurrentUser>> Discord.ICurrentUserActor.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IUser>> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
            ICurrentMemberActor.Enumerable,
            ICurrentMemberActor.BackLink<TSource>,
            Discord.IMemberActor.Enumerable.BackLink<TSource>,
            Discord.ICurrentUserActor.Enumerable.BackLink<TSource>,
            Discord.IUserActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            ICurrentMemberActor.Enumerable,
            ICurrentMemberActor.Indexable,
            Discord.IMemberActor.Enumerable.Indexable,
            Discord.ICurrentUserActor.Enumerable.Indexable,
            Discord.IUserActor.Enumerable.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
                ICurrentMemberActor.Enumerable.Indexable,
                ICurrentMemberActor.Enumerable.BackLink<TSource>,
                ICurrentMemberActor.Indexable.BackLink<TSource>,
                Discord.IMemberActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.ICurrentUserActor.Enumerable.Indexable.BackLink<TSource>,
                Discord.IUserActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IMemberActor.Indexable,
        Discord.ICurrentUserActor.Indexable,
        Discord.IUserActor.Indexable,
        Discord.ICurrentMemberActor.Link,
        Discord.ILinkType<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>.Indexable
    {
        internal new Discord.ICurrentMemberActor this[Discord.IIdentifiable<ulong, Discord.ICurrentMember, Discord.ICurrentMemberActor, Discord.Models.IMemberModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.ICurrentMemberActor this[ulong id] => (this as Discord.IActorProvider<Discord.ICurrentMemberActor, ulong>).GetActor(id);
    
        Discord.IMemberActor Discord.IMemberActor.Indexable.this[ulong id] => this[id];
    
        Discord.ICurrentUserActor Discord.ICurrentUserActor.Indexable.this[ulong id] => this[id];
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.ICurrentMemberActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.ICurrentMemberActor, ulong>).GetActor(id);
    
        Discord.IMemberActor Discord.IMemberActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.ICurrentUserActor Discord.ICurrentUserActor.Indexable.Specifically(ulong id) => Specifically(id);
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
            ICurrentMemberActor.Indexable,
            ICurrentMemberActor.BackLink<TSource>,
            Discord.IMemberActor.Indexable.BackLink<TSource>,
            Discord.ICurrentUserActor.Indexable.BackLink<TSource>,
            Discord.IUserActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
        Discord.IMemberActor.BackLink<TSource>,
        Discord.ICurrentUserActor.BackLink<TSource>,
        Discord.IUserActor.BackLink<TSource>,
        Discord.ICurrentMemberActor
        where TSource : class, IPathable;

    public new interface Link : 
        Discord.ILink<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember, Discord.Models.IMemberModel>,
        Discord.IMemberActor.Link,
        Discord.ICurrentUserActor.Link,
        Discord.IUserActor.Link
    {
        Discord.ICurrentMemberActor Discord.IActorProvider<Discord.ICurrentMemberActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.ICurrentMember Discord.IEntityProvider<Discord.ICurrentMember, Discord.Models.IMemberModel>.CreateEntity(Discord.Models.IMemberModel model) => CreateEntity(model);
    
        Discord.IMemberActor Discord.IActorProvider<Discord.IMemberActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IMember Discord.IEntityProvider<Discord.IMember, Discord.Models.IMemberModel>.CreateEntity(Discord.Models.IMemberModel model) => CreateEntity(model);
    
        Discord.ICurrentUserActor Discord.ICurrentUserActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.ICurrentUser Discord.ICurrentUserActor.Link.CreateEntity(Discord.Models.ISelfUserModel model) => CreateEntity(model);
    
        Discord.IUserActor Discord.IUserActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IUser Discord.IUserActor.Link.CreateEntity(Discord.Models.IUserModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
