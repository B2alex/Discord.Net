using Discord.Rest;

namespace Discord;

[
    Deletable<Routes.DeleteApplicationEmoji>,
    Loadable<Routes.GetApplicationEmoji>,
    Modifiable<Routes.UpdateApplicationEmoji, ModifyApplicationEmoteProperties>,
    Creatable<Routes.CreateApplicationEmoji, CreateApplicationEmoteProperties>
    (
        WhenBackLinkingFrom = [typeof(ICurrentApplicationActor)]
    )
]
public partial interface IApplicationEmoteActor :
    IActor<ulong, IApplicationEmote>,
    IApplicationActor.CanonicalRelationship;