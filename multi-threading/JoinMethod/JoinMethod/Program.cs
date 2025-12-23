using System;
using System.Threading;

namespace JoinMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join(); // Blocks the main thread until the execution of this thread
            thread2.Join(); // Blocks the main thread until the execution of this thread
            // Now, Main Thread will not wait for thread3 to complete its execution

            Console.WriteLine("Main Thread Ended");
            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Thread1 - Started");
            Thread.Sleep(1000);
            Console.WriteLine("Thread1 - Ended");
        }

        static void Method2()
        {
            Console.WriteLine("Thread2 - Started");
            Thread.Sleep(2000);
            Console.WriteLine("Thread2 - Ended");
        }

        static void Method3()
        {
            Console.WriteLine("Thread3 - Started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread3 - Ended");
        }
    }
}
