using System;
using System.Threading;

namespace SemaphoreSlimDemo
{
    class Program
    {
        static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount: 3);
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                int count = i;
                Thread t = new Thread(() => SemaphoreSlimFunction("Thread" + count, count * 1000));
                t.Start();
            }

            Console.ReadKey();
        }

        static void SemaphoreSlimFunction(string name, int seconds)
        {
            Console.WriteLine($"{name} waits to access resource");
            semaphore.Wait();
            Console.WriteLine($"{name} was granted access to resource");

            Thread.Sleep(seconds);
            Console.WriteLine($"{name} is completed");
            semaphore.Release();
        }
    }
}
