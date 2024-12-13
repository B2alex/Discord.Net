namespace Discord.Rest;

public interface IRouteWithRequestBody<out T> : IRouteOperation
{
    T Body { get; }
}