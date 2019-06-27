using System;
using Xunit;
using FizzBuzz.Function;

namespace FizzBuzz.UnitTests.Functions
{
    public class FizzBuzzFunctionTests
    {
        private readonly FizzBuzzFunction _fizzBuzzFunction;

        public FizzBuzzFunctionTests()
        {
            _fizzBuzzFunction = new FizzBuzzFunction();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(21)]
        public void ReturnFizzGivenValueOf3(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals("Fizz");

            Assert.True(result, $"{currentNumber} should be Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(80)]
        public void ReturnBuzzGivenValueIsMultipleOf5(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals("Buzz");

            Assert.True(result, $"{currentNumber} should be Buzz");
        }
    }
}
