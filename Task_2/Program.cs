using System;
using System.Runtime.Intrinsics.X86;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number type int: ");
                int a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number type double: ");
                double b = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number type long: ");
                long c = long.Parse(Console.ReadLine());

                Console.WriteLine($"a = {a}; b = {b}; c = {c}");
            }
            catch
            {
                Console.WriteLine("Exaption");
            }

        }
    }
}
