using Discord.Models;
using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

#pragma warning disable CS9113 // Parameter is unread.

[AttributeUsage(AttributeTargets.Interface)]
internal sealed class ModifiableAttribute<TRoute, TProperties> : Attribute
    where TRoute : IRouteOperation<TRoute>;

#pragma warning restore CS9113 // Parameter is unread.

public interface IModifiable<TRoute, in TParams, TModel> :
    IClientProvider,
    IPathable
    where TRoute : IRouteOperation<TRoute>
    where TParams : IRequestParams
    where TModel : class, IModel
{
    internal sealed IRestPipeline<TModel?> CreatePipeline(TParams args, RequestOptions? options)
        => TRoute.Create(this)
            .AsPipeline(args, options)
            .Deserialize<TModel>();
    async ValueTask ModifyAsync(
        TParams args,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await CreatePipeline(args, options).RunAsync(Client, token);

    public interface Entity : 
        IModifiable<TRoute, TParams, TModel>,
        IUpdatable<TModel>
    {
        new async ValueTask ModifyAsync(
            TParams args,
            RequestOptions? options = null,
            CancellationToken token = default
        ) => await CreatePipeline(args, options)
            .IfNotNull()
            .Continue(UpdateAsync)
            .RunAsync(Client, token);
        
        async ValueTask IModifiable<TRoute, TParams, TModel>.ModifyAsync(
            TParams args,
            RequestOptions? options,
            CancellationToken token
        ) => await ModifyAsync(args, options, token);
    }
    
    public interface Actor<TEntity> :
        IModifiable<TRoute, TParams, TModel>,
        IEntityProvider<TEntity, TModel>
        where TEntity : IEntity
    {
        new async ValueTask<TEntity> ModifyAsync(
            TParams args,
            RequestOptions? options = null,
            CancellationToken token = default
        ) => await CreatePipeline(args, options)
            .Required()
            .Transform(CreateEntityAsync)
            .RunAsync(Client, token);

        async ValueTask IModifiable<TRoute, TParams, TModel>.ModifyAsync(
            TParams args,
            RequestOptions? options,
            CancellationToken token
        ) => await ModifyAsync(args, options, token);
    }
}

//
// public interface IModifiable<TId, in TParams, TApi, TModel> :
//     IIdentifiable<TId>,
//     IClientProvider,
//     IPathable
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApi>
//     where TApi : class
//     where TModel : class, IEntityModel<TId>
// {
//     Task ModifyAsync(TParams args, RequestOptions? options = null, CancellationToken token = default);
//
//     internal static abstract IApiInRoute<TApi> ModifyRoute(IPathable path, TId id, TApi args);
//
//     public interface Actor<TSelf, TEntity> : 
//         IModifiable<TId, TParams, TApi, TModel>,
//         IEntityProvider<TEntity, TModel>
//         where TSelf : Actor<TSelf, TEntity>, IActor<TId, TEntity>, IEntityProvider<TEntity, TModel>
//         where TEntity : IEntity<TId>
//     {
//         new sealed async Task<TEntity> ModifyAsync(TParams args, RequestOptions? options = null, CancellationToken token = default)
//         {
//             var model = await Client.RestApiClient.ExecuteRequiredAsync(
//                 TSelf.ModifyRoute(this, Id, args.ToApiModel()),
//                 options,
//                 token
//             );
//
//             return await CreateEntityAsync(model, token);
//         }
//         
//         internal new static abstract IApiInOutRoute<TApi, TModel> ModifyRoute(IPathable path, TId id, TApi args);
//         
//         static IApiInRoute<TApi> IModifiable<TId, TParams, TApi, TModel>.ModifyRoute(
//             IPathable path, TId id, TApi args
//         ) => TSelf.ModifyRoute(path, id, args);
//
//         Task IModifiable<TId, TParams, TApi, TModel>.ModifyAsync(
//             TParams args,
//             RequestOptions? options,
//             CancellationToken token
//         ) => ModifyAsync(args, options, token);
//     }
//
//     public interface Entity<TSelf> :
//         IModifiable<TId, TParams, TApi, TModel>,
//         IUpdatable<TModel>
//         where TSelf : Entity<TSelf>, IModifiable<TId, TParams, TApi, TModel>
//     {
//         new sealed async Task ModifyAsync(TParams args, RequestOptions? options = null, CancellationToken token = default)
//         {
//             var model = await Client.RestApiClient.ExecuteRequiredAsync(
//                 TSelf.ModifyRoute(this, Id, args.ToApiModel()),
//                 options,
//                 token
//             );
//
//             await UpdateAsync(model, token);
//         }
//
//         internal new static abstract IApiInOutRoute<TApi, TModel> ModifyRoute(IPathable path, TId id, TApi args);
//
//         static IApiInRoute<TApi> IModifiable<TId, TParams, TApi, TModel>.ModifyRoute(
//             IPathable path, TId id, TApi args
//         ) => TSelf.ModifyRoute(path, id, args);
//
//         Task IModifiable<TId, TParams, TApi, TModel>.ModifyAsync(
//             TParams args,
//             RequestOptions? options,
//             CancellationToken token
//         ) => ModifyAsync(args, options, token);
//     }
// }

// [TemplateExtension(TakesPrecedenceOver = typeof(IModifiable<,,,,,>))]
// public interface IModifiable<TId, in TSelf, out TParams, TApi, in TModel> :
//     IModifiable<TId, TSelf, TParams, TApi>,
//     IUpdatable<TModel>
//     where TSelf :
//     IModifiable<TId, TSelf, TParams, TApi, TModel>,
//     IEntity<TId>,
//     IUpdatable<TModel>
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApi>, new()
//     where TApi : class
//     where TModel : class, IEntityModel<TId>
// {
//     new sealed Task ModifyAsync(Action<TParams> func, RequestOptions? options = null, CancellationToken token = default)
//         => ModifyAsync(Client, (TSelf)this, Id, func, options, token);
//
//     internal new static async Task ModifyAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options,
//         CancellationToken token)
//     {
//         var args = new TParams();
//         func(args);
//
//         var model = await client.RestApiClient.ExecuteRequiredAsync(
//             TSelf.ModifyRoute(self, id, args.ToApiModel()
//             ),
//             options ?? client.DefaultRequestOptions,
//             token
//         );
//
//         if (model is not TModel entityModel)
//             throw new DiscordException($"Expected model type '{typeof(TModel).Name}', got '{model.GetType().Name}'");
//
//         await self.UpdateAsync(entityModel, token);
//     }
//
//     static Task IModifiable<TId, TSelf, TParams, TApi>.ModifyAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options,
//         CancellationToken token
//     ) => ModifyAsync(client, self, id, func, options, token);
//
//     Task IModifiable<TId, TSelf, TParams, TApi>.ModifyAsync(Action<TParams> func, RequestOptions? options,
//         CancellationToken token)
//         => ModifyAsync(func, options, token);
//
//     internal new static abstract IApiInOutRoute<TApi, IModel> ModifyRoute(IPathable path, TId id, TApi args);
//
//     static IApiInRoute<TApi> IModifiable<TId, TSelf, TParams, TApi>.ModifyRoute(IPathable path, TId id, TApi args)
//         => TSelf.ModifyRoute(path, id, args);
// }
//
// [TemplateExtension]
// public interface IModifiable<TId, in TSelf, out TParams, TApi, TEntity, in TModel> :
//     IModifiable<TId, TSelf, TParams, TApi>,
//     IEntityProvider<TEntity, TModel>
//     where TSelf :
//     IModifiable<TId, TSelf, TParams, TApi, TEntity, TModel>,
//     IActor<TId, TEntity>,
//     IEntityProvider<TEntity, TModel>
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApi>, new()
//     where TApi : class
//     where TEntity : IEntity<TId>
//     where TModel : class, IEntityModel<TId>
// {
//     [return: TypeHeuristic(nameof(CreateEntity))]
//     new sealed Task<TEntity> ModifyAsync(Action<TParams> func, RequestOptions? options = null,
//         CancellationToken token = default)
//         => ModifyAsync(Client, (TSelf)this, Id, func, options, token);
//
//     [return: TypeHeuristic(nameof(CreateEntity))]
//     internal new static async Task<TEntity> ModifyAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options,
//         CancellationToken token)
//     {
//         return self.CreateEntity(
//             await ModifyAndReturnModelAsync(client, self, id, func, options, token)
//         );
//     }
//
//     internal static async Task<TModel> ModifyAndReturnModelAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options,
//         CancellationToken token)
//     {
//         var args = new TParams();
//         func(args);
//
//         var model = await client.RestApiClient.ExecuteRequiredAsync(
//             TSelf.ModifyRoute(self, id, args.ToApiModel()
//             ),
//             options ?? client.DefaultRequestOptions,
//             token
//         );
//
//         if (model is not TModel entityModel)
//             throw new DiscordException($"Expected model type '{typeof(TModel).Name}', got '{model.GetType().Name}'");
//
//         return entityModel;
//     }
//
//     static Task IModifiable<TId, TSelf, TParams, TApi>.ModifyAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options,
//         CancellationToken token
//     ) => ModifyAsync(client, self, id, func, options, token);
//
//     Task IModifiable<TId, TSelf, TParams, TApi>.ModifyAsync(Action<TParams> func, RequestOptions? options,
//         CancellationToken token)
//         => ModifyAsync(func, options, token);
//
//     internal new static abstract IApiInOutRoute<TApi, IModel> ModifyRoute(IPathable path, TId id, TApi args);
//
//     static IApiInRoute<TApi> IModifiable<TId, TSelf, TParams, TApi>.ModifyRoute(IPathable path, TId id, TApi args)
//         => TSelf.ModifyRoute(path, id, args);
// }
//
// [TemplateExtension, NoExposure]
// public interface IModifiable<TId, in TSelf, out TParams, TApi> :
//     IIdentifiable<TId>,
//     IClientProvider,
//     IPathable
//     where TSelf : IModifiable<TId, TSelf, TParams, TApi>
//     where TId : IEquatable<TId>
//     where TParams : IEntityProperties<TApi>, new()
//     where TApi : class
// {
//     Task ModifyAsync(Action<TParams> func, RequestOptions? options = null, CancellationToken token = default)
//         => TSelf.ModifyAsync(Client, (TSelf)this, Id, func, options, token);
//
//     internal static virtual Task ModifyAsync(
//         IDiscordClient client,
//         TSelf self,
//         TId id,
//         Action<TParams> func,
//         RequestOptions? options = null,
//         CancellationToken token = default)
//     {
//         var args = new TParams();
//         func(args);
//         return client.RestApiClient.ExecuteAsync(
//             TSelf.ModifyRoute(self, id, args.ToApiModel()),
//             options ?? client.DefaultRequestOptions,
//             token
//         );
//     }
//
//     internal static abstract IApiInRoute<TApi> ModifyRoute(IPathable path, TId id, TApi args);
// }