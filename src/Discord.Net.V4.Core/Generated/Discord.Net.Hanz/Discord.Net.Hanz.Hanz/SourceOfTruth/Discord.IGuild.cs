using System.Globalization;
using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;

namespace Discord;

public partial interface IGuild
{
    Discord.Models.IGuildModel IEntityOf<IGuildModel>.GetModel() => GetModel();

    Discord.Models.IPartialGuildModel IEntityOf<IPartialGuildModel>.GetModel() => GetModel();
}
