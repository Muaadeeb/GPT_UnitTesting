using Xunit;

namespace ApplicationCode.Tests;

public class CalculatorTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 2, 1)]
    [InlineData(0, 0, 0)]
    public void Add_ValidInput_ReturnsCorrectResult(int a, int b, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(-1, 2, -3)]
    [InlineData(0, 0, 0)]
    public void Subtract_ValidInput_ReturnsCorrectResult(int a, int b, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Subtract(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-1, 2, -2)]
    [InlineData(0, 5, 0)]
    public void Multiply_ValidInput_ReturnsCorrectResult(int a, int b, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Multiply(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(-4, 2, -2)]
    [InlineData(0, 5, 0)]
    public void Divide_ValidInput_ReturnsCorrectResult(double a, double b, double expected)
    {
        var calculator = new Calculator();

        var result = calculator.Divide(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_DivideByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }

}