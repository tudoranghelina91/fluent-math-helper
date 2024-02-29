namespace FluentMathHelper;

public static class PercentageExtensions
{
    public static decimal Percent(this decimal value, decimal amount)
    {
        return amount * value / 100;
    }

    public static decimal CalculatePercentageIncreaseTo(this decimal absoluteValueFrom, decimal absoluteValueTo)
    {
        return (absoluteValueTo - absoluteValueFrom) / absoluteValueFrom * 100;
    }

    public static decimal CalculatePercentageDecreaseTo(this decimal absoluteValueFrom, decimal absoluteValueTo)
    {
        return (absoluteValueFrom - absoluteValueTo) / absoluteValueFrom * 100;
    }

    public static decimal DeterminePercentageFromAbsoluteValue(this decimal value, decimal percentage)
    {
        return percentage * 100 / value;
    }
}