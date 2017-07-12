using Xunit;

namespace Calc.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_AddingTwoPositiveNumbers1And2_ShouldReturn3()
        {
            var actual = Calculator.Add(1, 2);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Add_AddingTwoNegativeNumbersNegative1AndNegative2_ShouldReturnNegative3()
        {
            var actual = Calculator.Add(-1, -2);

            Assert.Equal(-3, actual);
        }

        [Fact]
        public void Add_AddingOneNegativeNumbers1AndNegative2_ShouldReturnNegative1()
        {
            var actual = Calculator.Add(1, -2);

            Assert.Equal(-1, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(1, -2, -1)]
        [InlineData(100, 200, 300)]
        public void Add_TwoNumbers_ShouldReturnExpectedValue(int x, int y, int expected)
        {
            var actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
