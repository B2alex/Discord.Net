using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetGuildApplicationCommand>,
    Deletable<Routes.DeleteGuildApplicationCommand>,
    Modifiable<Routes.UpdateGuildApplicationCommand, ModifyGuildApplicationCommandProperties>,
    Creatable<Routes.CreateGuildApplicationCommand, CreateGuildApplicationCommandProperties>,
    Refreshable,
    FetchableOfMany<Routes.ListGuildApplicationCommands>
]
public partial interface IGuildApplicationCommandActor :
    IApplicationCommandActor,
    IGuildActor.CanonicalRelationship,
    IActor<ulong, IGuildApplicationCommand>
{
    IGuildApplicationCommandPermissionsActor.Enumerable.Indexable Permissions { get; }
}