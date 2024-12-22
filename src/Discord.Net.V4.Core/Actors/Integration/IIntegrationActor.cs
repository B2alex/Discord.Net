using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Deletable<Routes.DeleteGuildIntegration>, 
    FetchableOfMany<Routes.ListGuildIntegrations>
]
public partial interface IIntegrationActor :
    IGuildActor.CanonicalRelationship,
    IEntityProvider<IIntegration, IIntegrationModel>,
    IActor<ulong, IIntegration>;