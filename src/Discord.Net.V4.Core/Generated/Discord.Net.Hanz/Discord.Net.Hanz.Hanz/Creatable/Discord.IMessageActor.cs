using Discord.Models;
using Discord;

namespace Discord;

public partial interface IMessageActor : 
    Discord.ICreatable<Discord.IMessageActor, Discord.IMessage, ulong, Discord.CreateMessageProperties, Discord.Models.Json.CreateMessageParams, Discord.Models.IMessageModel>
{
    internal static virtual new IApiInOutRoute<Discord.Models.Json.CreateMessageParams, Discord.Models.IMessageModel> CreateRoute(IPathable path, Discord.Models.Json.CreateMessageParams args) => Discord.Rest.Routes.CreateMessage(path.Require<Discord.IChannel>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateMessageParams, Discord.Models.IMessageModel> Discord.ICreatable<Discord.IMessageActor, Discord.IMessage, ulong, Discord.CreateMessageProperties, Discord.Models.Json.CreateMessageParams, Discord.Models.IMessageModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateMessageParams args) => CreateRoute(path, args);
}
public static class CreatableMessageExtensions
{
    public static async Task<Discord.IMessage> CreateAsync(
        this Discord.IBackLink<Discord.IMessageChannelTrait, Discord.IMessageActor, ulong, Discord.IMessage, Discord.Models.IMessageModel> link,
        Discord.CreateMessageProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IMessageActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
