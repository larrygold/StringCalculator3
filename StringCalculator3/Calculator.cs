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

            if (input.StartsWith("//"))
            {
                var customDelimiter = ";";
                var temp = input.Substring(4, input.Length - 4);
                return temp.Split(new string[] { ",", "\n", customDelimiter }, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
            }

            return input.Split(new string[] {",", "\n"}, StringSplitOptions.None).Select(num => int.Parse(num)).Sum();
        }
    }
}
