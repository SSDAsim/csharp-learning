using System;

namespace typecasting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            int i = int.Parse(str1);
            Console.WriteLine($"original value is str1: {str1} and the converted value into: {i}");

            string str2 = "TRUE";
            bool b = bool.Parse(str2);
            Console.WriteLine($"original value is str2: {str2} and the converted value b is: {b}");

            Console.ReadKey();

            // with Parse(), you will get a runtime error if the values are not compatible. to avoid breaking the flow of the code this use TryParse()
        }
    }
}
