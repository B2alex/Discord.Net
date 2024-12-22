using System.Net;

namespace Discord.Rest;

public interface IRestResponse
{
    IRouteOperation Route { get; }
    RequestOptions Options { get; }
    
    HttpStatusCode StatusCode { get; }
    
    bool HasContent { get; }
    
    ValueTask<T> DeserializeAsync<T>(CancellationToken cancellationToken = default);

    void EnsureSuccessStatusCode()
    {
        if((int)StatusCode is < 200 or >= 300)
            throw new HttpRequestException($"Expected a successful status code, got {StatusCode}");
    }
}