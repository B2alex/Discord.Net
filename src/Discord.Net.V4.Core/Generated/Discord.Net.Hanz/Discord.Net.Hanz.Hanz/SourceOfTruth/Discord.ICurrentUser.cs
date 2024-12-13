using System.Diagnostics.CodeAnalysis;
using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;

namespace Discord;

public partial interface ICurrentUser
{
    Discord.Models.ISelfUserModel IEntityOf<ISelfUserModel>.GetModel() => GetModel();

    Discord.Models.IUserModel IEntityOf<IUserModel>.GetModel() => GetModel();
}
