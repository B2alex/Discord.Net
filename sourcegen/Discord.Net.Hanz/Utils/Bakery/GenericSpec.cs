using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Utils.Bakery;

public record GenericSpec(
    string Name,
    VarianceKind Variance = VarianceKind.None
)
{
    public static GenericSpec From(ITypeParameterSymbol symbol)
        => new(symbol.Name, symbol.Variance);
    
    public override string ToString()
        => $"{(Variance is not VarianceKind.None ? $"{Variance.ToString().ToLower()} " : string.Empty)}{Name}";

    public static implicit operator GenericSpec(string str) => new(str);
    public static implicit operator GenericSpec((string, VarianceKind) tuple) => new(tuple.Item1, tuple.Item2);
}