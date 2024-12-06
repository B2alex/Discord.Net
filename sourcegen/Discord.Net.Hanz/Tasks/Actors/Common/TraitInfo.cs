using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Tasks.Actors.Common;

public interface ITraitInfo : IEquatable<ITraitInfo>
{
    AssemblyTarget Assembly { get; }
    TypeRef Trait { get; }
    TypeRef Id { get; }
}

public sealed record TraitInfo(
    AssemblyTarget Assembly,
    TypeRef Trait,
    TypeRef Id
) : ITraitInfo
{
    public bool Equals(ITraitInfo other)
        => other is TraitInfo otherTrait && Equals(otherTrait);
}

public record ActorTraitInfo(
    AssemblyTarget Assembly,
    TypeRef Trait,
    TypeRef Id,
    TypeRef Entity,
    TypeRef Model
) : ActorOrTraitInfo(Assembly, Trait, Entity, Id, Model), ITraitInfo
{
    public bool Equals(ITraitInfo other)
        => other is ActorTraitInfo otherTrait && Equals(otherTrait);
}