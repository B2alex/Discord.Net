using System.Runtime.CompilerServices;
using Discord.Models.Json;

namespace Discord.Rest;

public sealed class RouteTypeProvider : IRouteMapper
{
    public IEnumerable<string> IgnoredRoutes => ["/applications/{application_id}/attachment"];
}