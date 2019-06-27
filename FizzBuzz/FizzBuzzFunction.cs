using System;

namespace FizzBuzz.Function
{
    public class FizzBuzzFunction
    {
        public void DoFizzBuzzGame(int countLength)
        {
            for (int i = 1; i <= countLength; i++)
            {
                string realOutput = GetRealOutput(i);
                Console.WriteLine(realOutput);
            }
        }

        public string GetRealOutput(int currentNumber)
        {
            if (currentNumber % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return currentNumber.ToString();
            }
        }
    }
}