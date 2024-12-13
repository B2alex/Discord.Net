using System.Diagnostics.CodeAnalysis;
using Discord.Rest;

namespace Discord;

public partial interface ICurrentMemberActor
{
    Discord.IVoiceStateActor IMemberActor.VoiceState => VoiceState;
}
