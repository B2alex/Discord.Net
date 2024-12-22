using Discord.Models;
using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.InviteResolve>,
    Refreshable
]
public partial interface IInviteActor :
    IActor<string, IInvite>;

