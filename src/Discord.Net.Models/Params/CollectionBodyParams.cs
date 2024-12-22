using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord.Models;

file sealed class Converter : JsonConverter<ICollectionBodyParams>
{
    public override ICollectionBodyParams? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => throw new InvalidOperationException();

    public override void Write(Utf8JsonWriter writer, ICollectionBodyParams value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        foreach (var entry in value.Body)
        {
            JsonSerializer.Serialize(writer, entry, value.ElementType, options);
        }
        
        writer.WriteEndArray();
    }
}

[JsonConverter(typeof(Converter))]
file interface ICollectionBodyParams : IBodyParams
{
    IEnumerable<IBodyParams> Body { get; }
    
    Type ElementType { get; }
}

[JsonConverter(typeof(Converter))]
internal sealed class CollectionBodyParams<T> : ICollectionBodyParams
    where T : IBodyParams
{
    public IEnumerable<T> Body { get; }
    
    public CollectionBodyParams(IEnumerable<T> body)
    {
        Body = body;
    }

    IEnumerable<IBodyParams> ICollectionBodyParams.Body => Body.Cast<IBodyParams>();
    Type ICollectionBodyParams.ElementType => typeof(T);
}

