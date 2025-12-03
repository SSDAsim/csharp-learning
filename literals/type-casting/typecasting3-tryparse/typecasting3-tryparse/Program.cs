using System;

namespace typecasting3_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tyepcasting using TryParse()
            // bool isConverted = int.TryParse("100", out int i1);
            // TryParse() method will try to convert "100" into integer. If successful, it will store value in i1 and return true in 'isConverted'. If failed, it will not store anything in i1 and return false in the 'isConverted'

            string str2 = "Hello";
            bool IsConverted2 = int.TryParse(str2, out int result2);
            if (IsConverted2)
            {
                Console.WriteLine($"Original string value {str2} and converted int value {result2}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to convert {str2} into integer");
            }

            string str1 = "100";
            bool IsConverted1 = int.TryParse(str1, out int result1);
            if (IsConverted1)
            {
                Console.WriteLine($"Original string value {str1} and converted int value {result1}");
            } else
            {
                Console.WriteLine($"Try Parse Failed to convert {str1} into integer");
            }

            
        }
    }
}
