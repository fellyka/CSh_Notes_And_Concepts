using System;

namespace Built_in_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true; //boolean type
            //Integral type
            sbyte smallDigit = 125;
            Console.WriteLine($"sbyte value {smallDigit}");

            int integer = 156;
            Console.WriteLine($"Integer value {integer}");
            
            Console.WriteLine($"Minimun value of integer is {int.MinValue}\nMaximum value of integer is {int.MaxValue}");

            //Float & double values
            float floatValue = 7.236f;
            Console.WriteLine($"Float value {floatValue}");

            double doubleValue = 15.695;
            Console.WriteLine($"Float value {doubleValue}"); //double provides more precision than float

            //string
            string name = "Sollers";
            Console.WriteLine(name);

            string withoutVerbatimLiteral = "D:\\Sollers\\CShTraining\\Exercises";
            Console.WriteLine(withoutVerbatimLiteral);

            string verbatimLiteral = @"C:\Sollers\CShTraining";
            Console.WriteLine(verbatimLiteral);
        }
    }
}
