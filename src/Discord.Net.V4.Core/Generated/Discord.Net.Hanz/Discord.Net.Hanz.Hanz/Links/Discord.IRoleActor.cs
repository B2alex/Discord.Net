using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IRoleActor
{
    public new interface Paged<in TParams> : 
        Discord.IRoleActor.Link,
        Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IRole> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IRole> Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
            IRoleActor.Paged<TParams>,
            IRoleActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IRoleActor.Paged<TParams>,
            IRoleActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                IRoleActor.Paged<TParams>.Indexable,
                IRoleActor.Paged<TParams>.BackLink<TSource>,
                IRoleActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IRoleActor.Link,
        Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
            IRoleActor.Paged<TPaged, TParams>,
            IRoleActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IRoleActor.Paged<TPaged, TParams>,
            IRoleActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                IRoleActor.Paged<TPaged, TParams>.Indexable,
                IRoleActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IRoleActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IRoleActor.Link,
        Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Defined
    {
        new IReadOnlyCollection<ulong> Ids { get; }
    
        IReadOnlyCollection<ulong> Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
            IRoleActor.Defined,
            IRoleActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IRoleActor.Defined,
            IRoleActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                IRoleActor.Defined.Indexable,
                IRoleActor.Defined.BackLink<TSource>,
                IRoleActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IRoleActor.Defined,
            IRoleActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                IRoleActor.Defined.Enumerable,
                IRoleActor.Defined.BackLink<TSource>,
                IRoleActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IRoleActor.Defined.Enumerable,
                IRoleActor.Defined.Indexable,
                IRoleActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                    IRoleActor.Defined.Enumerable.Indexable,
                    IRoleActor.Defined.Enumerable.BackLink<TSource>,
                    IRoleActor.Defined.Indexable.BackLink<TSource>,
                    IRoleActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IRoleActor.Link,
        Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IRole>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IRole>> Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
            IRoleActor.Enumerable,
            IRoleActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IRoleActor.Enumerable,
            IRoleActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
                IRoleActor.Enumerable.Indexable,
                IRoleActor.Enumerable.BackLink<TSource>,
                IRoleActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IRoleActor.Link,
        Discord.ILinkType<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>.Indexable
    {
        internal Discord.IRoleActor this[Discord.IIdentifiable<ulong, Discord.IRole, Discord.IRoleActor, Discord.Models.IRoleModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
            IRoleActor.Indexable,
            IRoleActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>,
        Discord.IRoleActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IRoleActor, ulong, Discord.IRole, Discord.Models.IRoleModel>
    {
        Discord.IRoleActor Discord.IActorProvider<Discord.IRoleActor, ulong>.GetActor(ulong id) => GetActor(id);
    
        Discord.IRole Discord.IEntityProvider<Discord.IRole, Discord.Models.IRoleModel>.CreateEntity(Discord.Models.IRoleModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
