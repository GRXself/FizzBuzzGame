using System;
using FizzBuzz.Function;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzFunction();
            int fizzBuzzEndNumber = 100;
            fizzBuzz.DoFizzBuzzGame(fizzBuzzEndNumber);
        }
    }
}
