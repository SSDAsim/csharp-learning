using System;
using System.Threading;

namespace ThreadLambdaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method1 " + i);
                }
            });

            t1.Start();
            Console.ReadKey();
        }
    }
}
