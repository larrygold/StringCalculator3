using System;
using System.Collections.Generic;
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
            var numbers = GetNumbers(parsedData);

            return Sum(numbers);
        }

        private static int Sum(IEnumerable<int> input)
        {
            if (input.Any(x => x < 0))
                throw new ArgumentOutOfRangeException();

            return input.Sum();
        }

        private static IEnumerable<int> GetNumbers(Calculator parsedData)
        {
            return parsedData._secondLine
                .Split(parsedData._delimiters, StringSplitOptions.None)
                .Select(num => int.Parse(num));
        }

        private static Calculator ParseInput(string input)
        {
            var delimiters = new string[] { ",", "\n" };

            if (input.StartsWith("//"))
            {
                var twoPartsOfInput = input.Split("\n");
                var customDelimiter = twoPartsOfInput[0].Substring(2);
                var secondLine = twoPartsOfInput[1];

                delimiters = new string[] {",", "\n", customDelimiter};
                input = secondLine;
            }

            return new Calculator(delimiters, input);
        }
    }
}
