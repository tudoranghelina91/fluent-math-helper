namespace FluentMathHelper;

public class Percentage
{
    private decimal percentage = 0;

    public Percentage Amount(decimal percentage)
    {
        this.percentage = percentage;
        return this;
    }

    public decimal Of(decimal value)
    {
        decimal result = percentage * value / 100;
        percentage = 0;
        return result;
    }
}