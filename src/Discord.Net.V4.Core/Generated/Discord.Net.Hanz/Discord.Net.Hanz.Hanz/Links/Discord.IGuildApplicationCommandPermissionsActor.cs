using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationCommandPermissionsActor
{
    public new interface Paged<in TParams> : 
        Discord.IGuildApplicationCommandPermissionsActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IGuildApplicationCommandPermissionses> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IGuildApplicationCommandPermissionses> Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
            IGuildApplicationCommandPermissionsActor.Paged<TParams>,
            IGuildApplicationCommandPermissionsActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandPermissionsActor.Paged<TParams>,
            IGuildApplicationCommandPermissionsActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                IGuildApplicationCommandPermissionsActor.Paged<TParams>.Indexable,
                IGuildApplicationCommandPermissionsActor.Paged<TParams>.BackLink<TSource>,
                IGuildApplicationCommandPermissionsActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IGuildApplicationCommandPermissionsActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
            IGuildApplicationCommandPermissionsActor.Paged<TPaged, TParams>,
            IGuildApplicationCommandPermissionsActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandPermissionsActor.Paged<TPaged, TParams>,
            IGuildApplicationCommandPermissionsActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                IGuildApplicationCommandPermissionsActor.Paged<TPaged, TParams>.Indexable,
                IGuildApplicationCommandPermissionsActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IGuildApplicationCommandPermissionsActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IGuildApplicationCommandPermissionsActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
            IGuildApplicationCommandPermissionsActor.Defined,
            IGuildApplicationCommandPermissionsActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandPermissionsActor.Defined,
            IGuildApplicationCommandPermissionsActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                IGuildApplicationCommandPermissionsActor.Defined.Indexable,
                IGuildApplicationCommandPermissionsActor.Defined.BackLink<TSource>,
                IGuildApplicationCommandPermissionsActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IGuildApplicationCommandPermissionsActor.Defined,
            IGuildApplicationCommandPermissionsActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                IGuildApplicationCommandPermissionsActor.Defined.Enumerable,
                IGuildApplicationCommandPermissionsActor.Defined.BackLink<TSource>,
                IGuildApplicationCommandPermissionsActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IGuildApplicationCommandPermissionsActor.Defined.Enumerable,
                IGuildApplicationCommandPermissionsActor.Defined.Indexable,
                IGuildApplicationCommandPermissionsActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                    IGuildApplicationCommandPermissionsActor.Defined.Enumerable.Indexable,
                    IGuildApplicationCommandPermissionsActor.Defined.Enumerable.BackLink<TSource>,
                    IGuildApplicationCommandPermissionsActor.Defined.Indexable.BackLink<TSource>,
                    IGuildApplicationCommandPermissionsActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IGuildApplicationCommandPermissionsActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IGuildApplicationCommandPermissionses>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IGuildApplicationCommandPermissionses>> Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
            IGuildApplicationCommandPermissionsActor.Enumerable,
            IGuildApplicationCommandPermissionsActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IGuildApplicationCommandPermissionsActor.Enumerable,
            IGuildApplicationCommandPermissionsActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
                IGuildApplicationCommandPermissionsActor.Enumerable.Indexable,
                IGuildApplicationCommandPermissionsActor.Enumerable.BackLink<TSource>,
                IGuildApplicationCommandPermissionsActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IGuildApplicationCommandPermissionsActor.Link,
        Discord.ILinkType<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.Indexable
    {
        internal Discord.IGuildApplicationCommandPermissionsActor this[Discord.IIdentifiable<ulong, Discord.IGuildApplicationCommandPermissionses, Discord.IGuildApplicationCommandPermissionsActor, Discord.Models.IGuildApplicationCommandPermissionsModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
            IGuildApplicationCommandPermissionsActor.Indexable,
            IGuildApplicationCommandPermissionsActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>,
        Discord.IGuildApplicationCommandPermissionsActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>
    {
        Discord.IGuildApplicationCommandPermissionsActor Discord.IActorProvider<Discord.IGuildApplicationCommandPermissionsActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IGuildApplicationCommandPermissionses Discord.IEntityProvider<Discord.IGuildApplicationCommandPermissionses, Discord.Models.IGuildApplicationCommandPermissionsModel>.CreateEntity(Discord.Models.IGuildApplicationCommandPermissionsModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
