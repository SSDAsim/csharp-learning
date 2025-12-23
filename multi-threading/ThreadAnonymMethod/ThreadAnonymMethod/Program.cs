using System;
using System.Threading;

namespace ThreadAnonymMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a ThreadStart instance using Anonymous Expression
            Thread t1 = new Thread(delegate ()
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
