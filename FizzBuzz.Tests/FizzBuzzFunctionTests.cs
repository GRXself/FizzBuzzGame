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

        [Fact]
        public void ReturnFalseGivenValueOf3()
        {
            var realOutPut = _fizzBuzzFunction.GetRealOutput(3);

            bool result = realOutPut.Equals("Fizz");

            Assert.False(result, "3 should be Fizz");
        }
    }
}
