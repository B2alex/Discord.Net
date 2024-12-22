using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.ListGuildApplicationCommandPermissions>,
    Modifiable<Routes.SetGuildApplicationCommandPermissions, ModifyApplicationCommandPermissionsProperties>
]
public partial interface IGuildApplicationCommandPermissionsActor :
    IActor<ulong, IGuildApplicationCommandPermissionses>,
    IGuildApplicationCommandActor.CanonicalRelationship;