using System;

namespace StringCalculator3
{
    public class Calculator
    {
        public static int Sum(string input)
        {
            int.TryParse(input, out var output);
            return output;
        }
    }
}
