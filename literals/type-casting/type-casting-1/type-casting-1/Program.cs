using System;
namespace type_casting1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            int i1 = Convert.ToInt32(str1); // converting string to integer

            double d = 123.5;
            int i2 = Convert.ToInt32(d); // converting double to integer

            float f = 45.467F;
            int i3 = Convert.ToInt32(f);

            Console.WriteLine($"Original value of str1: is {str1} and the integer value is i1: {i1}");
            Console.WriteLine($"Original value of d: is {d} and the integer value is i2: {i2}");
            Console.WriteLine($"Original value of f: is {f} and the integer value is i3: {i3}");

            Console.ReadKey();

            // Conver method will try to convert your value. it will give a runtime error if the values are not compatible.
        }
    }
}