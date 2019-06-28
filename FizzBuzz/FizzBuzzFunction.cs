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
            string result = "";
            bool isChanged = false;
            if (IsContainSpecificNumber(currentNumber, 3))
            {
                result += "Fizz";
                isChanged = true;
            }
            if (IsContainSpecificNumber(currentNumber, 5))
            {
                result += "Buzz";
                isChanged = true;
            }
            if (!isChanged)
            {
                result += currentNumber.ToString();
            }

            return result;
        }

        private bool IsContainSpecificNumber(int currentNumber, int specificNUmber)
        {
            return currentNumber % specificNUmber == 0 || currentNumber.ToString().Contains(specificNUmber.ToString());
        }
    }
}