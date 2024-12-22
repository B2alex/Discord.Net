using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

[
    Loadable<Routes.GetChannel>, 
    Deletable<Routes.DeleteChannel>,
    Creatable<Routes.CreateDm, CreateDMProperties>
]
public partial interface IDMChannelActor :
    IMessageChannelTrait,
    IActor<ulong, IDMChannel>;