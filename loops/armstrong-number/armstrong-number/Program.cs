using System;
namespace armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;

            Console.Write("Enter the number : ");
            int number = int.Parse(Console.ReadLine());

            int temporaryNumber = number;

            while (number > 0)
            {
                digitArray[i++] = number % 10;
                number = number / 10;
                digitCount++;
            }

            Console.Write(digitArray);

            Console.ReadKey();

            //for(i = 0; i < digitCount; i++)
            //{
            //    sum += Math.Pow(digitArray[i], digitCount);
            //}
        }
    }

    /* An Armstrong number equal the sum of, power of each digit by the total number of digits */
}