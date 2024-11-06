using Recursive_Methodology.Library;
using FluentAssertions;

namespace Recursive_Methodology.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    public void Factorial(int num, int expected)
    {
        RecursiveMath.Factorial(num).Should().Be(expected);
    }

    [Theory]
    [InlineData(0, "Must be a positive integer!")]
    [InlineData(-7, "Must be a positive integer!")]
    public void FactorialErrors(int num, string errorMessage)
    {
     FluentActions.Invoking(() => RecursiveMath.Factorial(num)).Should().Throw<DoneDidMessedUpException>().WithMessage(errorMessage);
    }
}