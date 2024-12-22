namespace Discord.Rest;

public partial interface IRouteMapper
{
    IEnumerable<string> IgnoredRoutes => [];
}
