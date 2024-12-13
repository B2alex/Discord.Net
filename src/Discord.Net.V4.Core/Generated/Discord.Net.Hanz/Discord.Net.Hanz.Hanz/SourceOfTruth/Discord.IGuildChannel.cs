using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;

namespace Discord;

public partial interface IGuildChannel
{
    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
