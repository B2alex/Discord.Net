using Discord.Rest;

namespace Discord;

[FetchableOfMany<Routes.ListSKUSubscriptions>]
public partial interface ISkuActor :
    IActor<ulong, ISku>,
    IApplicationActor.CanonicalRelationship;