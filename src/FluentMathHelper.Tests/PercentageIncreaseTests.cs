namespace FluentMathHelper.Tests;

public class PercentageIncreaseTests
{
    [Theory]
    [InlineData(100, 150, 50)]
    [InlineData(200, 400, 100)]
    [InlineData(60, 90, 50)]
    [InlineData(50, 75, 50)]
    public void PercentageIncreaseFromOldValueToNewValue_Should_BeExpected(decimal from, decimal to, decimal expected)
    {
        decimal x = new PercentageIncrease()
            .From(from)
            .To(to);

        Assert.Equal(expected, x);
    }
}