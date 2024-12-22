using Discord.Rest;

namespace Discord;

[
    Loadable<Routes.GetMyApplication>,
    Modifiable<Routes.UpdateMyApplication, ModifyCurrentApplicationProperties>
]
public partial interface ICurrentApplicationActor : 
    IApplicationActor,
    IActor<ulong, ICurrentApplication>;