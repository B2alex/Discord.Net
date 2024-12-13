using MorseCode.ITask;
using Discord.Models;
using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInviteActor
{
    public new interface Paged<in TParams> : 
        Discord.IInviteActor.Link,
        Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TParams>
        where TParams : Discord.IPagingParams
    {
        new IAsyncPaged<Discord.IInvite> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<Discord.IInvite> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
            IInviteActor.Paged<TParams>,
            IInviteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInviteActor.Paged<TParams>,
            IInviteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                IInviteActor.Paged<TParams>.Indexable,
                IInviteActor.Paged<TParams>.BackLink<TSource>,
                IInviteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Paged<out TPaged, in TParams> : 
        Discord.IInviteActor.Link,
        Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        new IAsyncPaged<TPaged> PagedAsync(TParams? args = default, RequestOptions? options = null);
    
        IAsyncPaged<TPaged> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Paged<TPaged, TParams>.PagedAsync(TParams? args = default, RequestOptions? options = null) => PagedAsync(args, options);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
            IInviteActor.Paged<TPaged, TParams>,
            IInviteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInviteActor.Paged<TPaged, TParams>,
            IInviteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                IInviteActor.Paged<TPaged, TParams>.Indexable,
                IInviteActor.Paged<TPaged, TParams>.BackLink<TSource>,
                IInviteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Defined : 
        Discord.IInviteActor.Link,
        Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Defined
    {
        new IReadOnlyCollection<string> Ids { get; }
    
        IReadOnlyCollection<string> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Defined.Ids => Ids;
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
            IInviteActor.Defined,
            IInviteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInviteActor.Defined,
            IInviteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                IInviteActor.Defined.Indexable,
                IInviteActor.Defined.BackLink<TSource>,
                IInviteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    
        public new interface Enumerable : 
            IInviteActor.Defined,
            IInviteActor.Enumerable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                IInviteActor.Defined.Enumerable,
                IInviteActor.Defined.BackLink<TSource>,
                IInviteActor.Enumerable.BackLink<TSource>
                where TSource : class, IPathable;
        
            public new interface Indexable : 
                IInviteActor.Defined.Enumerable,
                IInviteActor.Defined.Indexable,
                IInviteActor.Enumerable.Indexable
            {
                public interface BackLink<out TSource> : 
                    Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                    IInviteActor.Defined.Enumerable.Indexable,
                    IInviteActor.Defined.Enumerable.BackLink<TSource>,
                    IInviteActor.Defined.Indexable.BackLink<TSource>,
                    IInviteActor.Enumerable.Indexable.BackLink<TSource>
                    where TSource : class, IPathable;
            }
        }
    }

    public new interface Enumerable : 
        Discord.IInviteActor.Link,
        Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Enumerable
    {
        new ITask<IReadOnlyCollection<Discord.IInvite>> AllAsync(RequestOptions? options = null, CancellationToken token = default);
    
        ITask<IReadOnlyCollection<Discord.IInvite>> Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Enumerable.AllAsync(RequestOptions? options = null, CancellationToken token = default) => AllAsync(options: options, token: token);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
            IInviteActor.Enumerable,
            IInviteActor.BackLink<TSource>
            where TSource : class, IPathable;
    
        public new interface Indexable : 
            IInviteActor.Enumerable,
            IInviteActor.Indexable
        {
            public interface BackLink<out TSource> : 
                Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
                IInviteActor.Enumerable.Indexable,
                IInviteActor.Enumerable.BackLink<TSource>,
                IInviteActor.Indexable.BackLink<TSource>
                where TSource : class, IPathable;
        }
    }

    public new interface Indexable : 
        Discord.IInviteActor.Link,
        Discord.ILinkType<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>.Indexable
    {
        internal Discord.IInviteActor this[Discord.IIdentifiable<string, Discord.IInvite, Discord.IInviteActor, Discord.Models.IInviteModel> identity] => identity.Actor ?? GetActor(identity.Id);
    
    
        public interface BackLink<out TSource> : 
            Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
            IInviteActor.Indexable,
            IInviteActor.BackLink<TSource>
            where TSource : class, IPathable;
    }

    public interface BackLink<out TSource> : 
        Discord.IBackLink<TSource, Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>,
        Discord.IInviteActor
        where TSource : class, IPathable;

    public interface Link : 
        Discord.ILink<Discord.IInviteActor, string, Discord.IInvite, Discord.Models.IInviteModel>
    {
        Discord.IInviteActor Discord.IActorProvider<Discord.IInviteActor, string>.GetActor(string id) => GetActor(id);
    
        Discord.IInvite Discord.IEntityProvider<Discord.IInvite, Discord.Models.IInviteModel>.CreateEntity(Discord.Models.IInviteModel model) => CreateEntity(model);
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
