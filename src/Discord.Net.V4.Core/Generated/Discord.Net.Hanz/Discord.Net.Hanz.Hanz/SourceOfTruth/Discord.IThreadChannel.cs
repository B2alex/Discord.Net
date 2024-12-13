using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord.Entities.Channels.Threads;

namespace Discord;

public partial interface IThreadChannel
{
    Discord.Models.IThreadChannelModel IEntityOf<IThreadChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IGuildChannel.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
