using System;

namespace _4_CommonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 10;
            int denominator = 2;
            int result = numerator /denominator;
            Console.WriteLine($"Result is {result}");

            int numerator1 = 9;
            int denominator1 = 6;
            int result1 = numerator1 % denominator1;
            Console.WriteLine($"Result is {result1}");

            if(numerator == numerator1)
            {
                Console.WriteLine("Both numerators are equal");
            }

            else
            {
                Console.WriteLine("Both numerators are NOT equal");
            }

            //Ternary Operator
            char c = 'A';
            char d = 'b';
            string s = c == d ? $"Char {c} and {d} are the same" : $"char {c} and {d} hold different values";
            Console.WriteLine($"{s}");

            //Nullable types
            /*
              In C#, types are divided into 2 broad categories:
               Value types - int, float, struct, enums etc (By defaullt, value types are not nullable. Use ? to make them nullable)
               Reference types - interface, class, delegates, arrays etc
             Nullable types bridge the ifferences between C# types and Database types
            */

            string name = null; //string is a reference type  - can be initialized with  a null value 
            int? integer = null; //int being a value type, add ? to make it nullable.

            int? xValue = null;
            int yValue = xValue ?? 150; // Use 150 if xValue is null

            Console.WriteLine($"Value is {yValue}");

        }
    }
}
