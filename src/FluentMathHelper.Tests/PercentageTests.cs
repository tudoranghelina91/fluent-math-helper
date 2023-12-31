﻿namespace FluentMathHelper.Tests;

public class PercentageTests
{
    [Theory]
    [InlineData(50, 100, 50)]
    [InlineData(100, 100, 100)]
    [InlineData(150, 100, 150)]
    public void PercentageAmountOfValue_Should_BeExpected(decimal percentage, decimal value, decimal expected)
    {
        decimal x = new Percentage()
            .Amount(percentage).Of(value);

        Assert.Equal(expected, x);
    }
}