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
            if (currentNumber % 3 == 0 || currentNumber.ToString().Contains('3'))
            {
                result += "Fizz";
                isChanged = true;
            }
            if (currentNumber % 5 == 0 || currentNumber.ToString().Contains('5'))
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
    }
}