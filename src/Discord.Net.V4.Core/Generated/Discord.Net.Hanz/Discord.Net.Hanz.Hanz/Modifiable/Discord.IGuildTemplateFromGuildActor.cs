using Discord.Rest;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord;

public partial interface IGuildTemplateFromGuildActor : 
    Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.Actor<Discord.IGuildTemplateFromGuildActor, Discord.IGuildTemplate>
{
    internal static new IApiInOutRoute<Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel> ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => Discord.Rest.Routes.ModifyGuildTemplate(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel> Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.Actor<Discord.IGuildTemplateFromGuildActor, Discord.IGuildTemplate>.ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildTemplateParams> Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface IGuildTemplate : 
    Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.Entity<Discord.IGuildTemplate>,
    Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel> ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => Discord.Rest.Routes.ModifyGuildTemplate(path.Require<Discord.IGuild>(), id, body);

    static IApiInOutRoute<Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel> Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.Entity<Discord.IGuildTemplate>.ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyGuildTemplateParams> Discord.IModifiable<string, Discord.ModifyGuildTemplateProperties, Discord.Models.Json.ModifyGuildTemplateParams, Discord.Models.IGuildTemplateModel>.ModifyRoute(
        IPathable path,
        string id,
        Discord.Models.Json.ModifyGuildTemplateParams args
    ) => ModifyRoute(path, id, args);
}
