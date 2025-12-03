using System;
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number to caluclate the factorial: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The factorial of {n} is {factorial(n)}");
        }

        static int factorial(int number)
        {
            // base condition 
            if(number == 1)
            {
                return 1;
            } else
            {
                return (number * factorial(number - 1));
            }
        }
    }
}