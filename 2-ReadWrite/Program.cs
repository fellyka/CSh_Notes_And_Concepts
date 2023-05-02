using System;

namespace _2_ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName+ " " + lastName;

            Console.WriteLine($"Hello {fullName}");
        }
    }
}
