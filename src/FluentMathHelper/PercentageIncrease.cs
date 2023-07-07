namespace FluentMathHelper;

public class PercentageIncrease
{
    private decimal oldValue = 0;

    public PercentageIncrease From(decimal oldValue)
    {
        this.oldValue = oldValue;
        return this;
    }

    public decimal To(decimal newValue)
    {
        decimal result = (newValue - oldValue) / oldValue * 100;
        oldValue = 0;
        return result;
    }
}