using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;

namespace Discord;

public partial interface IForumChannel
{
    Discord.Models.IGuildForumChannelModel IEntityOf<IGuildForumChannelModel>.GetModel() => GetModel();

    Discord.Models.IThreadableChannelModel IThreadableChannel.GetModel() => GetModel();

    Discord.Models.IThreadableChannelModel IEntityOf<IThreadableChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IGuildChannel.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
