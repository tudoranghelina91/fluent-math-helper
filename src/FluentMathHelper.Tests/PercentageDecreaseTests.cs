namespace FluentMathHelper.Tests;

public class PercentageDecreaseTests
{
    [Theory]
    [InlineData(100, 50, 50)]
    [InlineData(400, 200, 50)]
    [InlineData(60, 30, 50)]
    [InlineData(90, 45, 50)]
    [InlineData(100, 0, 100)]
    [InlineData(100, -100, 200)]
    [InlineData(100, 10, 90)]
    public void PercentageDecreaseFromOldValueToNewValue_Should_BeExpected(decimal from, decimal to, decimal expected)
    {
        Assert.Equal(expected, from.CalculatePercentageDecreaseTo(to));
    }
}