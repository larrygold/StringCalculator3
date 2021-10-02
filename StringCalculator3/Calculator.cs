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
                var customDelimiter =  input.Substring(2, input.IndexOf("\n") - 2);
                delimiters = new string[] { ",", "\n", customDelimiter };
                input = input.Substring(4, input.Length - 4);
            }

            return input.Split(delimiters, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
        }
    }
}
