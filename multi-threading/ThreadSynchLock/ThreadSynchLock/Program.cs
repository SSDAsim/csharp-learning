using System;
using System.Threading;

namespace ThreadSynchLock
{
    internal class Program
    {
        static object lockObj = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SomeMethod)
            {
                Name = "Thread1"
            };

            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "Thread2"
            };

            Thread thread3 = new Thread(SomeMethod)
            {
                Name = "Thread3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Console.ReadKey();
        }

        static void SomeMethod ()
        {
            lock(lockObj)
            {
                Console.WriteLine("[Welcome to C#");
                Thread.Sleep(1000);
                Console.WriteLine("and Angular Course]");
            }
        }
    }
}

// The first thread to enter the method gets its sole access until it exits the method, thereby avoiding the collision between multiple threads trying to access a method.
