using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Tasks.Actors;

public abstract record ActorOrTraitInfo(
    AssemblyTarget Assembly,
    TypeRef Type,
    TypeRef Entity,
    TypeRef Id,
    TypeRef Model
)
{
    public bool IsCore => Assembly is AssemblyTarget.Core;

    public string FormattedRelation
        => $"Discord.IRelation<{Id}, {Entity}>";
    
    public string FormattedRelationship
        => $"Discord.IRelationship<{Type}, {Id}, {Entity}>";
    
    public string FormattedCanonicalRelationship
        => $"Discord.ICanonicalRelationship<{Type}, {Id}, {Entity}>";
    
    public string FormattedIdentifiable
        => $"Discord.IIdentifiable<{Id}, {Entity}, {Type}, {Model}>";

    public string FormattedBackLinkType
        => $"Discord.IBackLink<TSource, {Type}, {Id}, {Entity}, {Model}>";

    public string FormattedBackLinkOfType(TypeRef type)
        => $"Discord.IBackLink<{type}, {Type}, {Id}, {Entity}, {Model}>";

    public string FormattedLinkType
        => $"Discord.ILinkType<{Type}, {Id}, {Entity}, {Model}>";

    public string FormattedLink
        => $"Discord.ILink<{Type}, {Id}, {Entity}, {Model}>";

    public string FormattedRestLinkType =>
        $"Discord.Rest.IRestLinkType<{Type}, {Id}, {Entity}, {Model}>";

    public string FormattedActorProvider
        => $"Discord.IActorProvider<{Type}, {Id}>";

    public string FormattedRestActorProvider
        => $"Discord.Rest.RestActorProvider<{Type}, {Id}>";

    public string FormattedEntityProvider
        => $"Discord.IEntityProvider<{Entity}, {Model}>";
}