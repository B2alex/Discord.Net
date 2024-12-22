using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class BulkBanUsersParams : IBodyParams
{
    [JsonPropertyName("user_ids")]
    public required ulong[] UserIds { get; set; }
    
    [JsonPropertyName("delete_message_seconds")]
    public Optional<int> DeleteMessageSeconds { get; set; }
}
