namespace FluentMathHelper.Tests;

public class PercentageOfTests
{
    [Theory]
    [InlineData(100, 50, 50)]
    [InlineData(100, 25, 25)]
    [InlineData(200, 100, 50)]
    [InlineData(50, 25, 50)]
    [InlineData(60, 15, 25)]
    public void Should_PercentageOfWholeAmount_ReturnExpected(decimal whole, decimal value, decimal expected)
    {
        decimal x = new PercentageOf().Whole(whole).Is(value);

        Assert.Equal(expected, x);
    }
}