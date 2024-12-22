using Discord.Models;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

#pragma warning disable CS9113 // Parameter is unread.

[AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
internal sealed class CreatableAttribute<TRoute> : Attribute
    where TRoute : IRouteOperation<TRoute>
{
    public string? MethodName { get; set; }
    public Type[]? WhenBackLinkingFrom { get; set; }
}

[AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
internal sealed class CreatableAttribute<TRoute, TParams> : Attribute
    where TRoute : IRouteOperation<TRoute>
{
    public string? MethodName { get; set; }
    public Type[]? WhenBackLinkingFrom { get; set; }
}

// [AttributeUsage(AttributeTargets.Interface)]
// internal sealed class ActorCreatableAttribute<TParams>(string route) : Attribute
// {
//     public Type[]? RouteGenerics { get; set; }
//     public Type[]? WhenBackLinkingFrom { get; set; }
// }

#pragma warning restore CS9113 // Parameter is unread.

public interface ICreatable<TRoute, in TParams, TEntity, in TModel> :
    IEntityProvider<TEntity, TModel>,
    IPathable
    where TEntity : IEntity
    where TModel : class, IModel
    where TRoute : IRouteOperation<TRoute>
    where TParams : IRequestParams
{
    internal IRestPipeline<TEntity> CreatePipeline(TParams args, RequestOptions? options = null)
        => TRoute.Create(this)
            .AsPipeline(args, options)
            .Deserialize<TModel>()
            .Required()
            .Transform(CreateEntityAsync);
}

//
// public interface ICreatable<TActor, out TEntity, out TId, in TParams, TApiParams, TModel> :
//     IIdentifiable<TId>,
//     IEntityProvider<TEntity, TModel>,
//     IPathable
//     where TActor : ICreatable<TActor, TEntity, TId, TParams, TApiParams, TModel>, IEntityProvider<TEntity, TModel>
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApiParams>
//     where TModel : IEntityModel<TId>
//     where TEntity : IEntity<TId, TModel>
// {
//     static abstract IApiInOutRoute<TApiParams, TModel> CreateRoute(IPathable path, TApiParams args);
// }
//
// public interface IActorCreatable<TActor, out TId, in TParams, out TApiParams, out TApi> :
//     IIdentifiable<TId>,
//     IPathable
//     where TActor : IActorCreatable<TActor, TId, TParams, TApiParams, TApi>
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApiParams>
//     where TApi : class
// {
//     static abstract IApiInOutRoute<TApiParams, TApi> CreateRoute(IPathable path, TParams args);
// }