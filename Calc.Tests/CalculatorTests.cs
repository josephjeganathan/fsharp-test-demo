using System;
using FsCheck;
using FsCheck.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace Calc.Tests
{
    public class CalculatorTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public CalculatorTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Add_AddingTwoPositiveNumbers1And2_ResultIs3()
        {
            var calculator = CreateCalculator();

            calculator.Add(1, 2);

            Assert.Equal(3, calculator.Result);
        }

        [Fact]
        public void Add_AddingTwoNegativeNumbersNegative1AndNegative2_ResultIsNegative3()
        {
            var calculator = CreateCalculator();

            calculator.Add(-1, -2);

            Assert.Equal(-3, calculator.Result);
        }

        [Fact]
        public void Add_AddingNegativeAndPositveNumbers1AndNegative2_ResultIsNegative1()
        {
            var calculator = CreateCalculator();

            calculator.Add(1, -2);

            Assert.Equal(-1, calculator.Result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(1, -2, -1)]
        [InlineData(100, 200, 300)]
        public void Add_TwoNumbers_ResultMustBeTheExpectedValue(int x, int y, int expected)
        {
            var calculator = CreateCalculator();

            calculator.Add(x, y);

            Assert.Equal(expected, calculator.Result);
        }

        [Property]
        public bool Add_TwoNumbers_Result(int x, int y)
        {
            var calculator = CreateCalculator();

            calculator.Add(x, y);

            _outputHelper.WriteLine($"x: {x}, y: {y}, result: {calculator.Result}");

            return calculator.Result == x + y;
        }

        private static Calculator CreateCalculator() => new Calculator();
    }
}
