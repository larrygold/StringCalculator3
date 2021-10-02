using System;
using System.Linq;

namespace StringCalculator3
{
    public class Calculator
    {
        public static int Sum(string input)
        {
            if (input.Length == 0)
                return 0;

            var numbersAsStrings = input.Split(',');
            var numbersAsInts = numbersAsStrings.Select(num => int.Parse(num));
            return numbersAsInts.Sum();

        }
    }
}
