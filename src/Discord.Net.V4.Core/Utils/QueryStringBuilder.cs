using System.Collections;
using System.Text;
using System.Web;

namespace Discord.Utils;

public readonly ref struct QueryStringBuilder 
{
    private readonly StringBuilder _stringBuilder;

    public QueryStringBuilder()
    {
        _stringBuilder = new StringBuilder();
    }

    private void Add(string name, string value)
    {
        _stringBuilder
            .Append(
                _stringBuilder.Length == 0
                    ? '?'
                    : '&'
            )
            .Append(name)
            .Append('=')
            .Append(HttpUtility.UrlEncode(value));
    }

    public void Add<T>(string name, T value)
    {
        if (value?.ToString() is not { } str)
            return;

        Add(name, str);
    }
    
    public void MaybeAdd<T>(string name, Optional<T> value)
    {
        if (!value.IsSpecified || value.Value?.ToString() is not {} str)
            return;
        
        Add(name, str);
    }

    public override string ToString()
        => _stringBuilder.ToString();

    public void Dispose()
    {
        _stringBuilder.Clear();
    }
}