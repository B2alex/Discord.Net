using Discord.Net.Hanz.Tasks.Actors.Links;
using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Tasks.Actors;

public interface IHasActorInfo
{
    ActorInfo ActorInfo { get; }
}

public record ActorInfo(
    AssemblyTarget Assembly,
    TypeRef Actor,
    TypeRef Entity,
    TypeRef Id,
    TypeRef Model,
    TypeRef CoreActor,
    TypeRef CoreEntity,
    bool IsTrait
) : ActorOrTraitInfo(Assembly, Actor, Entity, Id, Model)
{
    public string FormattedCoreIdentifiable
        => $"Discord.IIdentifiable<{Id}, {CoreEntity}, {CoreActor}, {Model}>";

    public string FormattedCoreBackLinkType
        => $"Discord.IBackLink<TSource, {CoreActor}, {Id}, {CoreEntity}, {Model}>";

    public string FormattedCoreLinkType
        => $"Discord.ILinkType<{CoreActor}, {Id}, {CoreEntity}, {Model}>";

    public string FormattedCoreLink
        => $"Discord.ILink<{CoreActor}, {Id}, {CoreEntity}, {Model}>";

    public string FormattedCoreActorProvider
        => $"Discord.IActorProvider<{CoreActor}, {Id}>";

    public string FormattedCoreEntityProvider
        => $"Discord.IEntityProvider<{CoreEntity}, {Model}>";

    public static ActorInfo Create(LinksTask.NodeContext context)
        => Create(context.Target);
    
    public static ActorInfo Create(ActorsTask.ActorSymbols target)
    {
        var coreActorSymbol = target.Assembly is AssemblyTarget.Core
            ? target.Actor
            : Hierarchy.GetHierarchy(target.Actor, false)
                .First(x =>
                    x.Type.ContainingAssembly.Name == "Discord.Net.V4.Core"
                    &&
                    x.Type.AllInterfaces.Any(y => y is {Name: "IActor", TypeArguments.Length: 2})
                )
                .Type;

        var isTrait = coreActorSymbol.GetAttributes().Any(x => x.AttributeClass?.Name == "TraitAttribute");
        
        var coreActor = new TypeRef(coreActorSymbol);

        var coreEntity = target.Assembly is AssemblyTarget.Core
            ? new TypeRef(target.Actor)
            : new TypeRef(
                Hierarchy.GetHierarchy(target.Entity, false)
                    .First(x =>
                        x.Type.ContainingAssembly.Name == "Discord.Net.V4.Core"
                        &&
                        x.Type.AllInterfaces.Any(y => y is {Name: "IEntity"})
                    ).Type
            );

        return new ActorInfo(
            Assembly: target.Assembly,
            Actor: new(target.Actor),
            Entity: new(target.Entity),
            Id: new(target.Id),
            Model: new(target.Model),
            CoreEntity: coreEntity,
            CoreActor: coreActor,
            IsTrait: isTrait
        );
    }
}