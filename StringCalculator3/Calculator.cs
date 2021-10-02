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
                var startSecondLine = customDelimiterEndIndex + 2;

                var customDelimiter =  input.Substring(customDelimiterStartIndex, customDelimiterEndIndex - customDelimiterStartIndex + 1);
                delimiters = new string[] { ",", "\n", customDelimiter };

                input = input.Substring(startSecondLine, (input.Length - 1) - startSecondLine + 1);
            }

            return input.Split(delimiters, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
        }
    }
}
