using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMemberActor
{
    public interface WithCurrent : 
        Discord.IUserActor.WithCurrent
    {
        Discord.ICurrentMemberActor Current { get; }
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.WithCurrent,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.WithCurrent.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public new interface Paged<in TParams> : 
        Discord.IUserActor.Paged<TParams>,
        Discord.IMemberActor.Link,
        Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IMember> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IMember> Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<Discord.IUser> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IMemberActor.Paged<TParams>,
            IMemberActor.WithCurrent,
            Discord.IUserActor.Paged<TParams>.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Paged<TParams>.WithCurrent,
                IMemberActor.Paged<TParams>.BackLink<TSource>,
                IMemberActor.WithCurrent.BackLink<TSource>,
                Discord.IUserActor.Paged<TParams>.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.Paged<TParams>,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.Paged<TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMemberActor.Paged<TParams>,
            IMemberActor.Indexable,
            Discord.IUserActor.Paged<TParams>.Indexable
        {
            public interface WithCurrent : 
                IMemberActor.Paged<TParams>.Indexable,
                IMemberActor.Paged<TParams>.WithCurrent,
                IMemberActor.Indexable.WithCurrent,
                Discord.IUserActor.Paged<TParams>.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Paged<TParams>.Indexable.WithCurrent,
                    IMemberActor.Paged<TParams>.Indexable.BackLink<TSource>,
                    IMemberActor.Paged<TParams>.WithCurrent.BackLink<TSource>,
                    IMemberActor.Indexable.WithCurrent.BackLink<TSource>,
                    Discord.IUserActor.Paged<TParams>.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Paged<TParams>.Indexable,
                IMemberActor.Paged<TParams>.BackLink<TSource>,
                IMemberActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IUserActor.Paged<TPaged, TParams>,
        Discord.IMemberActor.Link,
        Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface WithCurrent : 
            IMemberActor.Paged<TPaged, TParams>,
            IMemberActor.WithCurrent,
            Discord.IUserActor.Paged<TPaged, TParams>.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Paged<TPaged, TParams>.WithCurrent,
                IMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IMemberActor.WithCurrent.BackLink<TSource>,
                Discord.IUserActor.Paged<TPaged, TParams>.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.Paged<TPaged, TParams>,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.Paged<TPaged, TParams>.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMemberActor.Paged<TPaged, TParams>,
            IMemberActor.Indexable,
            Discord.IUserActor.Paged<TPaged, TParams>.Indexable
        {
            public interface WithCurrent : 
                IMemberActor.Paged<TPaged, TParams>.Indexable,
                IMemberActor.Paged<TPaged, TParams>.WithCurrent,
                IMemberActor.Indexable.WithCurrent,
                Discord.IUserActor.Paged<TPaged, TParams>.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Paged<TPaged, TParams>.Indexable.WithCurrent,
                    IMemberActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>,
                    IMemberActor.Paged<TPaged, TParams>.WithCurrent.BackLink<TSource>,
                    IMemberActor.Indexable.WithCurrent.BackLink<TSource>,
                    Discord.IUserActor.Paged<TPaged, TParams>.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Paged<TPaged, TParams>.Indexable,
                IMemberActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IMemberActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Paged<TPaged, TParams>.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IUserActor.Defined,
        Discord.IMemberActor.Link,
        Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Defined.Ids => Ids;
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Defined.Ids => Ids;
    
    
        public interface WithCurrent : 
            IMemberActor.Defined,
            IMemberActor.WithCurrent,
            Discord.IUserActor.Defined.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Defined.WithCurrent,
                IMemberActor.Defined.BackLink<TSource>,
                IMemberActor.WithCurrent.BackLink<TSource>,
                Discord.IUserActor.Defined.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.Defined,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.Defined.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMemberActor.Defined,
            IMemberActor.Indexable,
            Discord.IUserActor.Defined.Indexable
        {
            public interface WithCurrent : 
                IMemberActor.Defined.Indexable,
                IMemberActor.Defined.WithCurrent,
                IMemberActor.Indexable.WithCurrent,
                Discord.IUserActor.Defined.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Defined.Indexable.WithCurrent,
                    IMemberActor.Defined.Indexable.BackLink<TSource>,
                    IMemberActor.Defined.WithCurrent.BackLink<TSource>,
                    IMemberActor.Indexable.WithCurrent.BackLink<TSource>,
                    Discord.IUserActor.Defined.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Defined.Indexable,
                IMemberActor.Defined.BackLink<TSource>,
                IMemberActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Defined.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IMemberActor.Defined,
            IMemberActor.Enumerable,
            Discord.IUserActor.Defined.Enumerable
        {
            public interface WithCurrent : 
                IMemberActor.Defined.Enumerable,
                IMemberActor.Defined.WithCurrent,
                IMemberActor.Enumerable.WithCurrent,
                Discord.IUserActor.Defined.Enumerable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Defined.Enumerable.WithCurrent,
                    IMemberActor.Defined.Enumerable.BackLink<TSource>,
                    IMemberActor.Defined.WithCurrent.BackLink<TSource>,
                    IMemberActor.Enumerable.WithCurrent.BackLink<TSource>,
                    Discord.IUserActor.Defined.Enumerable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Defined.Enumerable,
                IMemberActor.Defined.BackLink<TSource>,
                IMemberActor.Enumerable.BackLink<TSource>,
                Discord.IUserActor.Defined.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IMemberActor.Defined.Enumerable,
                IMemberActor.Defined.Indexable,
                IMemberActor.Enumerable.Indexable,
                Discord.IUserActor.Defined.Enumerable.Indexable
            {
                public interface WithCurrent : 
                    IMemberActor.Defined.Enumerable.Indexable,
                    IMemberActor.Defined.Enumerable.WithCurrent,
                    IMemberActor.Defined.Indexable.WithCurrent,
                    IMemberActor.Enumerable.Indexable.WithCurrent,
                    Discord.IUserActor.Defined.Enumerable.Indexable.WithCurrent
                {
                    public interface BackLink<out TSource> : 
                        Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                        IMemberActor.Defined.Enumerable.Indexable.WithCurrent,
                        IMemberActor.Defined.Enumerable.Indexable.BackLink<TSource>,
                        IMemberActor.Defined.Enumerable.WithCurrent.BackLink<TSource>,
                        IMemberActor.Defined.Indexable.WithCurrent.BackLink<TSource>,
                        IMemberActor.Enumerable.Indexable.WithCurrent.BackLink<TSource>,
                        Discord.IUserActor.Defined.Enumerable.Indexable.WithCurrent.BackLink<TSource>
                        where TSource : class, IPathable;
                }
            
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Defined.Enumerable.Indexable,
                    IMemberActor.Defined.Enumerable.BackLink<TSource>,
                    IMemberActor.Defined.Indexable.BackLink<TSource>,
                    IMemberActor.Enumerable.Indexable.BackLink<TSource>,
                    Discord.IUserActor.Defined.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IUserActor.Enumerable,
        Discord.IMemberActor.Link,
        Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IMember>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IMember>> Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
        ITask<IReadOnlyCollection<Discord.IUser>> Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface WithCurrent : 
            IMemberActor.Enumerable,
            IMemberActor.WithCurrent,
            Discord.IUserActor.Enumerable.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Enumerable.WithCurrent,
                IMemberActor.Enumerable.BackLink<TSource>,
                IMemberActor.WithCurrent.BackLink<TSource>,
                Discord.IUserActor.Enumerable.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.Enumerable,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.Enumerable.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IMemberActor.Enumerable,
            IMemberActor.Indexable,
            Discord.IUserActor.Enumerable.Indexable
        {
            public interface WithCurrent : 
                IMemberActor.Enumerable.Indexable,
                IMemberActor.Enumerable.WithCurrent,
                IMemberActor.Indexable.WithCurrent,
                Discord.IUserActor.Enumerable.Indexable.WithCurrent
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                    IMemberActor.Enumerable.Indexable.WithCurrent,
                    IMemberActor.Enumerable.Indexable.BackLink<TSource>,
                    IMemberActor.Enumerable.WithCurrent.BackLink<TSource>,
                    IMemberActor.Indexable.WithCurrent.BackLink<TSource>,
                    Discord.IUserActor.Enumerable.Indexable.WithCurrent.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Enumerable.Indexable,
                IMemberActor.Enumerable.BackLink<TSource>,
                IMemberActor.Indexable.BackLink<TSource>,
                Discord.IUserActor.Enumerable.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IUserActor.Indexable,
        Discord.IMemberActor.Link,
        Discord.ILinkType<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>.Indexable
    {
        internal new Discord.IMemberActor this[Discord.IIdentifiable<ulong, Discord.IMember, Discord.IMemberActor, Discord.Models.IMemberModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
        new Discord.IMemberActor this[ulong id] => (this as Discord.IActorProvider<Discord.IMemberActor, ulong>).GetActor(id);
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.this[ulong id] => this[id];
    
    
        new Discord.IMemberActor Specifically(ulong id) => (this as Discord.IActorProvider<Discord.IMemberActor, ulong>).GetActor(id);
    
        Discord.IUserActor Discord.ILinkType<Discord.IUserActor, ulong, Discord.IUser, Discord.Models.IUserModel>.Indexable.Specifically(ulong id) => Specifically(id);
    
    
        public interface WithCurrent : 
            IMemberActor.Indexable,
            IMemberActor.WithCurrent,
            Discord.IUserActor.Indexable.WithCurrent
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
                IMemberActor.Indexable.WithCurrent,
                IMemberActor.Indexable.BackLink<TSource>,
                IMemberActor.WithCurrent.BackLink<TSource>,
                Discord.IUserActor.Indexable.WithCurrent.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
            IMemberActor.Indexable,
            IMemberActor.BackLink<TSource>,
            Discord.IUserActor.Indexable.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
        Discord.IUserActor.BackLink<TSource>,
        Discord.IMemberActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IMemberActor, ulong, Discord.IMember, Discord.Models.IMemberModel>,
        Discord.IUserActor.Link
    {
        Discord.IUserActor Discord.IUserActor.Link.GetActor(ulong id) => GetActor(id);
    
        Discord.IUser Discord.IUserActor.Link.CreateEntity(Discord.Models.IUserModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
