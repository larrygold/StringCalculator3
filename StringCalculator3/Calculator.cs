﻿using System;
using System.Linq;

namespace StringCalculator3
{
    public class Calculator
    {
        public static int Sum(string input)
        {
            if (input.Length == 0)
                return 0;

            if (input.Contains("\n"))
                return input.Split("\n").Select(num => int.Parse(num)).Sum();

            return input.Split(',').Select(num => int.Parse(num)).Sum();

        }
    }
}
