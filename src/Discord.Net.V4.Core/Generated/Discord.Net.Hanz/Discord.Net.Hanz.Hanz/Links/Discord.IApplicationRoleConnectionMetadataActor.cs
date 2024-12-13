using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationRoleConnectionMetadataActor
{
    public new interface Paged<in TParams> : 
        Discord.IApplicationRoleConnectionMetadataActor.Link,
        Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IApplicationRoleConnectionMetadata> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IApplicationRoleConnectionMetadata> Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
            IApplicationRoleConnectionMetadataActor.Paged<TParams>,
            IApplicationRoleConnectionMetadataActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationRoleConnectionMetadataActor.Paged<TParams>,
            IApplicationRoleConnectionMetadataActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                IApplicationRoleConnectionMetadataActor.Paged<TParams>.Indexable,
                IApplicationRoleConnectionMetadataActor.Paged<TParams>.BackLink<TSource>,
                IApplicationRoleConnectionMetadataActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IApplicationRoleConnectionMetadataActor.Link,
        Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
            IApplicationRoleConnectionMetadataActor.Paged<TPaged, TParams>,
            IApplicationRoleConnectionMetadataActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationRoleConnectionMetadataActor.Paged<TPaged, TParams>,
            IApplicationRoleConnectionMetadataActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                IApplicationRoleConnectionMetadataActor.Paged<TPaged, TParams>.Indexable,
                IApplicationRoleConnectionMetadataActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IApplicationRoleConnectionMetadataActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IApplicationRoleConnectionMetadataActor.Link,
        Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
            IApplicationRoleConnectionMetadataActor.Defined,
            IApplicationRoleConnectionMetadataActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationRoleConnectionMetadataActor.Defined,
            IApplicationRoleConnectionMetadataActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                IApplicationRoleConnectionMetadataActor.Defined.Indexable,
                IApplicationRoleConnectionMetadataActor.Defined.BackLink<TSource>,
                IApplicationRoleConnectionMetadataActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IApplicationRoleConnectionMetadataActor.Defined,
            IApplicationRoleConnectionMetadataActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                IApplicationRoleConnectionMetadataActor.Defined.Enumerable,
                IApplicationRoleConnectionMetadataActor.Defined.BackLink<TSource>,
                IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IApplicationRoleConnectionMetadataActor.Defined.Enumerable,
                IApplicationRoleConnectionMetadataActor.Defined.Indexable,
                IApplicationRoleConnectionMetadataActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                    IApplicationRoleConnectionMetadataActor.Defined.Enumerable.Indexable,
                    IApplicationRoleConnectionMetadataActor.Defined.Enumerable.BackLink<TSource>,
                    IApplicationRoleConnectionMetadataActor.Defined.Indexable.BackLink<TSource>,
                    IApplicationRoleConnectionMetadataActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IApplicationRoleConnectionMetadataActor.Link,
        Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IApplicationRoleConnectionMetadata>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IApplicationRoleConnectionMetadata>> Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
            IApplicationRoleConnectionMetadataActor.Enumerable,
            IApplicationRoleConnectionMetadataActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IApplicationRoleConnectionMetadataActor.Enumerable,
            IApplicationRoleConnectionMetadataActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
                IApplicationRoleConnectionMetadataActor.Enumerable.Indexable,
                IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<TSource>,
                IApplicationRoleConnectionMetadataActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IApplicationRoleConnectionMetadataActor.Link,
        Discord.ILinkType<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.Indexable
    {
        internal Discord.IApplicationRoleConnectionMetadataActor this[Discord.IIdentifiable<string, Discord.IApplicationRoleConnectionMetadata, Discord.IApplicationRoleConnectionMetadataActor, Discord.Models.IApplicationRoleConnectionMetadataModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
            IApplicationRoleConnectionMetadataActor.Indexable,
            IApplicationRoleConnectionMetadataActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>,
        Discord.IApplicationRoleConnectionMetadataActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>
    {
        Discord.IApplicationRoleConnectionMetadataActor Discord.IActorProvider<Discord.IApplicationRoleConnectionMetadataActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IApplicationRoleConnectionMetadata Discord.IEntityProvider<Discord.IApplicationRoleConnectionMetadata, Discord.Models.IApplicationRoleConnectionMetadataModel>.CreateEntity(Discord.Models.IApplicationRoleConnectionMetadataModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
