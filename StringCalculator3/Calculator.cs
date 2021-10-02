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

            var delimiters = new string[] {",", "\n"};

            if (input.StartsWith("//"))
            {
                var customDelimiterStartIndex = 2;
                var customDelimiterEndIndex = input.IndexOf("\n") - 1;

                var customDelimiter =  input.Substring(customDelimiterStartIndex, customDelimiterEndIndex - customDelimiterStartIndex + 1);
                delimiters = new string[] { ",", "\n", customDelimiter };

                input = input.Substring(customDelimiterEndIndex + 1 + 1, (input.Length - 1) - (customDelimiterEndIndex + 2) + 1);
            }

            return input.Split(delimiters, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
        }
    }
}
