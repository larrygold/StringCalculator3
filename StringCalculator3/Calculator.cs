﻿using System;
using System.Linq;

namespace StringCalculator3
{
    public class Calculator
    {
        private string[] _delimiters;
        private string _secondLine;

        public Calculator(string[] delimiters, string secondLine)
        {
            _delimiters = delimiters;
            _secondLine = secondLine;
        }
        public static int Sum(string input)
        {
            if (input.Length == 0)
                return 0;

            var parsedData = ParseInput(input);

            return parsedData._secondLine
                             .Split(parsedData._delimiters, StringSplitOptions.None)
                             .Select(num => int.Parse(num))
                             .Sum();
        }

        private static Calculator ParseInput(string input)
        {
            var delimiters = new string[] { ",", "\n" };

            if (input.StartsWith("//"))
            {
                var customDelimiterStartIndex = 2;
                var customDelimiterEndIndex = input.IndexOf("\n") - 1;
                var startSecondLine = customDelimiterEndIndex + 2;

                var customDelimiter = input.Substring(customDelimiterStartIndex,
                    customDelimiterEndIndex - customDelimiterStartIndex + 1);

                delimiters = new string[] {",", "\n", customDelimiter};
                input = input.Substring(startSecondLine);
            }

            return new Calculator(delimiters, input);
        }
    }
}
