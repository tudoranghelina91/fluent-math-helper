namespace FluentMathHelper;

public class PercentageOf
{
    private decimal whole = 0;

    public PercentageOf Whole(decimal whole)
    {
        this.whole = whole;
        return this;
    }

    public decimal Is(decimal value)
    {
        decimal result = value * 100 / whole;
        whole = 0;
        return result;
    }
}