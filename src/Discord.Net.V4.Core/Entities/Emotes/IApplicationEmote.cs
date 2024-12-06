using Discord.Models;
using Discord.Models.Json;

namespace Discord;

public partial interface IApplicationEmote :
    ICustomEmote,
    IApplicationEmoteActor;