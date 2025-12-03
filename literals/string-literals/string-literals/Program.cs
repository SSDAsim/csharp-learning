using System;
namespace string_literal
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Literals in C# are enclosed in " " or start with @""

            string str1 = "Dot Net Tutorials";
            string str2 = @"Dot Net Tutorials";

            string str3 = "Dot\nNet\nTutorials";
            string str4 = @"Dot\nNet\nTutorials";

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str3: {str3}");
            Console.WriteLine($"str4: {str4}");

            Console.ReadKey();

            // Verbatim String Literals: A verbatim string literal starts with an @ character followed by a double-quote which may contain zero or more characters, and ends with a double-quote character. In this case, the escape sequences or characters will be printed as it is in the output.
        }
    }
}