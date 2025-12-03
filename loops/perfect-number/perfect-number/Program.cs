using System;
namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, sum = 0;
            Console.Write("Enter a number to check if it is a perfect number or not: ");
            number = Convert.ToInt32(Console.ReadLine());

            

            // calculate the sum
            for (i = 1; i <= number / 2; i++)
            {
                if(number % 2 == 0)
                {
                    sum += i;
                }
            }

            if (sum == number && number != 0)
            {
                Console.WriteLine($"{number} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{number} is a not perfect number");
            }

            Console.ReadKey();
        }
    }

    /* A number is a perfect number if the sum of its positive divisors is equal to the number. For example, the positive divisor of 6 are 1, 2, and 3 and 1+2+3 = 6 */
}