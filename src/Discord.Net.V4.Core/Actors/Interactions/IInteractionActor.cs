namespace Discord;

// only handles https://discord.com/developers/docs/interactions/receiving-and-responding#create-interaction-response
public partial interface IInteractionActor :
    IActor<ulong, IInteraction>,
    ICurrentApplicationsInteractionActor
{   
    
    // [SourceOfTruth]
    new IInteractionMessageActor.Indexable.WithOriginal.BackLink<IInteractionActor> Responses { get; }
}

public partial interface ICurrentApplicationsInteractionActor :
    ITokenPathProvider,
    ICurrentApplicationActor.CanonicalRelationship
{
    IInteractionMessageActor.Indexable.WithOriginal Responses { get; }
}