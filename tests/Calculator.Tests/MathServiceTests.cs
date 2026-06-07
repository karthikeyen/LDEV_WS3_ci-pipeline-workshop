using Calculator;
using Xunit;

namespace Calculator.Tests;

public class MathServiceTests
{
    private readonly MathService _sut = new();

    // ===== Addition Tests =====
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        var result = _sut.Add(3, 5);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_NegativeNumbers_ReturnsCorrectSum()
    {
        var result = _sut.Add(-3, -7);
        Assert.Equal(-10, result);
    }

    // ===== Subtraction Tests =====
    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _sut.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    // ===== Multiplication Tests =====
    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        var result = _sut.Multiply(3, 7);
        Assert.Equal(21, result);
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        var result = _sut.Multiply(5, 0);
        Assert.Equal(0, result);
    }

    // ===== Division Tests =====
    [Fact]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        var result = _sut.Divide(10, 2);
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _sut.Divide(10, 0));
    }

    // ===== IsEven Tests =====
    [Theory]
    [InlineData(2, true)]
    [InlineData(7, false)]
    [InlineData(0, true)]
    [InlineData(-4, true)]
    public void IsEven_ReturnsExpectedResult(int number, bool expected)
    {
        var result = _sut.IsEven(number);
        Assert.Equal(expected, result);
    }

    // ===== Factorial Tests =====
    [Fact]
    public void Factorial_Zero_ReturnsOne()
    {
        var result = _sut.Factorial(0);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Factorial_Five_Returns120()
    {
        var result = _sut.Factorial(5);
        Assert.Equal(120, result);
    }

    [Fact]
    public void Factorial_NegativeNumber_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _sut.Factorial(-1));
    }
}