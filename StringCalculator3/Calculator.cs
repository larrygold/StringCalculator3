using System;
using System.Linq;

namespace StringCalculator3
{
    public class Calculator
    {
        public static int Sum(string input)
        {
            if (input.Contains(','))
            {
                var numbersAsStrings = input.Split(',');
                return int.Parse(numbersAsStrings[0]) + int.Parse(numbersAsStrings[1]);
            }

            int.TryParse(input, out var output);
            return output;
        }
    }
}
