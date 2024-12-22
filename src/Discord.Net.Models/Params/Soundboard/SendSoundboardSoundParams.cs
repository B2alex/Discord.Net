using System.Text.Json.Serialization;

namespace Discord.Models;

public sealed class SendSoundboardSoundParams : IBodyParams
{
    [JsonPropertyName("sound_id")]
    public required ulong SoundId { get; set; }
    
    [JsonPropertyName("source_guild_id")]
    public Optional<ulong> SourceGuildId { get; set; }
}