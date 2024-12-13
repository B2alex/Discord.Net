namespace Discord.Rest;

public interface IRouteOperation : IRoute
{
    static abstract string OperationName { get; }
    static abstract RequestMethod Method { get; }
    static abstract bool RequiresBotToken { get; }

    string BuildRoute();
}