using Discord.Models;

namespace Discord;

public interface IEntity<out TId, out TModel> : IEntity<TId>, IEntityOf<TModel>
    where TId : IEquatable<TId>
    where TModel : IModel;

public interface IEntity<out TId> : IEntity, IIdentifiable<TId> where TId : IEquatable<TId>;

public interface IEntity : IClientProvider;
