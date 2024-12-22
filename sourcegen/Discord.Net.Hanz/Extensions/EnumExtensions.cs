namespace Discord.Net.Hanz;

public static class EnumExtensions
{
    public static TEnum If<TEnum>(this TEnum value, bool condition)
        where TEnum : Enum
        => condition ? value : default(TEnum)!;
}