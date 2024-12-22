using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class ModifyGuildMfaLevelParams : IBodyParams
{
    [JsonPropertyName("level")]
    public int Level { get; set; }
}
