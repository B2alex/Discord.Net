using Discord.Models;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

[FetchableOfMany<Routes.GetSoundboardDefaultSounds>]
public partial interface ISoundboardSoundActor :
    IActor<ulong, ISoundboardSound>
{
    async ValueTask SendAsync(
        IdOrEntity<ulong, IChannelActor> channel,
        ulong? soundGuildId = null,
        RequestOptions? options = null,
        CancellationToken token = default
    ) => await Routes
        .SendSoundboardSound
        .Create(channel.Id)
        .AsPipeline(
            new SendSoundboardSoundParams()
            {
                SoundId = Id,
                SourceGuildId = this is IGuildSoundboardSoundActor guildSound
                    ? guildSound.Id
                    : default
            },
            options
        )
        .RunAsync(Client, token);
}