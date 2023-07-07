namespace FluentMathHelper;

public class PercentageDecrease
{
    private decimal oldValue = 0;

    public PercentageDecrease From(decimal oldValue)
    {
        this.oldValue = oldValue;
        return this;
    }

    public decimal To(decimal newValue)
    {
        decimal result = (oldValue - newValue) / oldValue * 100;
        oldValue = 0;
        return result;
    }
}