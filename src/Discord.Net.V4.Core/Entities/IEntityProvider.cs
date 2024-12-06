using Discord.Models;
using System.Diagnostics.CodeAnalysis;
using MorseCode.ITask;

namespace Discord;

public interface IEntityProvider<out TEntity, in TModel> : IClientProvider
    where TEntity : IEntity
    where TModel : IModel?
{
    internal ITask<TEntity> CreateEntityAsync(TModel model, CancellationToken token = default);
}

public interface IEntityProvider<out TEntity, in TModel, in TContext> : IClientProvider
    where TEntity : IEntity
    where TModel : IModel?
{
    internal ITask<TEntity> CreateEntityAsync(TModel model, TContext context,  CancellationToken token = default);
}
