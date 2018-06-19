using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MulticastDelegates
{
    class MathOperations
    {
        public static void MultiplyByTwo(double value)
        {
            double result = value * 2;
            WriteLine($"Multiply by 2: {value} gives {result}");
        }

        public static void Square(double value)
        {
            double result = value * value;
            WriteLine($"Squaring:{value} gives {result}");
        }
    }
}
