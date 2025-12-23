using System;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread threadObj = new Thread(MutexDemo)
                {
                    Name = "Thread " + i
                };

                threadObj.Start();
                Console.ReadKey();
            }
        }

        static void MutexDemo ()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section");
            if(mutex.WaitOne(1000))
            {
                try
                {
                    Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");

                    Thread.Sleep(2000);

                    Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " has completed its Tasks");
                } finally
                {
                    mutex.ReleaseMutex();
                    Console.WriteLine(Thread.CurrentThread.Name + " has released the Mutex");
                }
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " will not acquire mutex");
            } 
        }

        ~Program() {
            mutex.Dispose();
        }
    }
}
