using System;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        static Mutex _mutex;
        static void Main(string[] args)
        {
            if(!IsSingleInstace())
            {
                Console.WriteLine("More Than One Instance");
            } else
            {
                Console.WriteLine("Only One Instance");
            }

            Console.ReadKey();
        }

        static bool IsSingleInstace ()
        {
            try
            {
                // try opening existing instance 
                // if there is no existing instance, then it will throw an exception
                Mutex.OpenExisting("MyMutex");
            }
            catch
            {
                // make new instance
                _mutex = new Mutex(true, "MyMutex");

                return true;
            }

            // More than one instance
            return false;
        }
    }
}
