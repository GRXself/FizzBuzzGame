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
        [InlineData(13)]
        [InlineData(31)]
        [InlineData(43)]
        public void ReturnFizzGivenValueIsDivisibleByOrHas3(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals("Fizz");

            Assert.True(result, $"{currentNumber} should be Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(80)]
        [InlineData(52)]
        [InlineData(56)]
        public void ReturnBuzzGivenValueIsDivisibleByOrHas5(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals("Buzz");

            Assert.True(result, $"{currentNumber} should be Buzz");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(98)]
        public void RetrunOriginNumberGivenValueInNormalCase(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals(currentNumber.ToString());

            Assert.True(result, $"{currentNumber} should be {currentNumber}");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(75)]
        [InlineData(35)]
        [InlineData(53)]
        public void ReturnFizzBuzzGivenValueIsDivisbleByOrHas3And5(int currentNumber)
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(currentNumber);

            bool result = realOutPut.Equals("FizzBuzz");

            Assert.True(result, $"{currentNumber} should be FizzBuzz");
        }
    }
}
