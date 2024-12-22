namespace Discord.Models;

public interface IMultipartParams : IRequestParams
{
    IDictionary<string, object?> GetKeys();
    IDictionary<string, MultipartFile> GetFiles();
}