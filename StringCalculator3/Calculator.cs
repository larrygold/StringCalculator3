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

            return input.Split(new string[] {",", "\n"}, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
        }
    }
}
