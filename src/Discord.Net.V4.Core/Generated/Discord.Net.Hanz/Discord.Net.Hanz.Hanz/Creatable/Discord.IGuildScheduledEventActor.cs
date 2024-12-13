using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildScheduledEventActor : 
    Discord.ICreatable<Discord.IGuildScheduledEventActor, Discord.IGuildScheduledEvent, ulong, Discord.CreateGuildScheduledEventProperties, Discord.Models.Json.CreateGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> CreateRoute(IPathable path, Discord.Models.Json.CreateGuildScheduledEventParams args) => Discord.Rest.Routes.CreateGuildScheduledEvent(path.Require<Discord.IGuild>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel> Discord.ICreatable<Discord.IGuildScheduledEventActor, Discord.IGuildScheduledEvent, ulong, Discord.CreateGuildScheduledEventProperties, Discord.Models.Json.CreateGuildScheduledEventParams, Discord.Models.IGuildScheduledEventModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateGuildScheduledEventParams args) => CreateRoute(path, args);
}
public static class CreatableGuildScheduledEventExtensions
{
    public static async Task<Discord.IGuildScheduledEvent> CreateAsync(
        this Discord.IBackLink<Discord.IGuildActor, Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent, Discord.Models.IGuildScheduledEventModel> link,
        Discord.CreateGuildScheduledEventProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IGuildScheduledEventActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
