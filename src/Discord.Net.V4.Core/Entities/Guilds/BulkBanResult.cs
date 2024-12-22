using Discord.Models.Json;
using System.Collections.Immutable;

namespace Discord;

public readonly struct BulkBanResult(ulong[] bannedUsers, ulong[] failedUsers)
    : IModelConstructable<BulkBanResult, BulkBanResponse>
{
    public readonly IReadOnlyCollection<ulong> BannedUsers = bannedUsers.AsReadOnly();
    public readonly IReadOnlyCollection<ulong> FailedUsers = failedUsers.AsReadOnly();

    public static BulkBanResult Construct(IDiscordClient client, BulkBanResponse model) =>
        new(model.BannedUsers, model.FailedUsers);
}
