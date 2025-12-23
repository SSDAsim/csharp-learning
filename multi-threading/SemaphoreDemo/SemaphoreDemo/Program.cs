using System;
using System.Threading;

namespace SemaphoreDemo
{
    class Program
    {
        public static Semaphore semaphore = null;
        static void Main(string[] args)
        {
            try
            {
                // open exisiting semaphore
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            } 
            catch (Exception ex)
            {
                // if semaphore instance does not exist, create on
                // allow only two external threads to access the application code at any given instance of time
                semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }
            Console.WriteLine("External Thread Trying to Acquire");
            semaphore.WaitOne();
            //This section can be access by maximum two external threads: Start
            Console.WriteLine("External Thread Aquired");
            Console.ReadKey();
            //This section can be access by maximum two external threads: End
            semaphore.Release();
        }
    }
}

//Now, build the project and then run the application EXE file three times. The first two times, you will see the message that External Thread Acquired, but when you run the EXE file for the 3rd time, you will see the message External Thread Trying to Acquiring only
