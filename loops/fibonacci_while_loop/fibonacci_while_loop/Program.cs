using System;
namespace fibonacci_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            k = i + j;
            while (k <= n)
            {
                Console.Write($" {k} ");

                i = j;
                j = k;
                k = i + j;
            }

            Console.ReadKey();
        }
    }
}