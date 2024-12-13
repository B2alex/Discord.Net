using System.Collections.Immutable;

namespace Discord.Rest;

public interface IRoute
{
    static abstract string Path { get; }
}