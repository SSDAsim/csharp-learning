using System;

namespace datatypes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 1.123f;
            double b = 2.2234;
            decimal c = 22.234m;

            Console.WriteLine($"Size of float is {sizeof(float)}");
            Console.WriteLine($"Size of double is {sizeof(double)}");
            Console.WriteLine($"Size of decimal is {sizeof(decimal)}");
            Console.ReadKey();
        }
    }
}
