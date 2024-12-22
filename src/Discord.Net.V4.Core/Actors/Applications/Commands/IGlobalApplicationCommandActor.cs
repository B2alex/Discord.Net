using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetApplicationCommand>,
    Deletable<Routes.DeleteApplicationCommand>,
    Modifiable<Routes.UpdateApplicationCommand, ModifyGlobalApplicationCommandProperties>,
    Creatable<Routes.CreateApplicationCommand, CreateGlobalApplicationCommandProperties>,
    Refreshable<Routes.GetApplicationCommand>,
    FetchableOfMany<Routes.ListApplicationCommands>
]
public partial interface IGlobalApplicationCommandActor :
    IApplicationCommandActor,
    IActor<ulong, IGlobalApplicationCommand>;