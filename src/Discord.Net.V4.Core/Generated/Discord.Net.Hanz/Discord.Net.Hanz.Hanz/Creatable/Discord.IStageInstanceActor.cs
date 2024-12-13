using Discord.Models;
using Discord;

namespace Discord;

public partial interface IStageInstanceActor : 
    Discord.ICreatable<Discord.IStageInstanceActor, Discord.IStageInstance, ulong, Discord.CreateStageInstanceProperties, Discord.Models.CreateStageInstanceParams, Discord.Models.IStageInstanceModel>
{
    internal static new IApiInOutRoute<Discord.Models.CreateStageInstanceParams, Discord.Models.IStageInstanceModel> CreateRoute(IPathable path, Discord.Models.CreateStageInstanceParams args) => Discord.Rest.Routes.CreateStageInstance(args);

    static IApiInOutRoute<Discord.Models.CreateStageInstanceParams, Discord.Models.IStageInstanceModel> Discord.ICreatable<Discord.IStageInstanceActor, Discord.IStageInstance, ulong, Discord.CreateStageInstanceProperties, Discord.Models.CreateStageInstanceParams, Discord.Models.IStageInstanceModel>.CreateRoute(IPathable path, Discord.Models.CreateStageInstanceParams args) => CreateRoute(path, args);
}
public static class CreatableStageInstanceExtensions
{
    public static async Task<Discord.IStageInstance> CreateAsync(
        this Discord.IStageInstanceActor.BackLink<Discord.IStageChannelActor> link,
        Discord.CreateStageInstanceProperties args,
        RequestOptions? options = null,
        CancellationToken token = default
    )
    {
        var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
            Discord.IStageInstanceActor.CreateRoute(link, args.ToApiModel()),
            options,
            token
        );
        
        return await link.CreateEntityAsync(model);
    }
    
}
