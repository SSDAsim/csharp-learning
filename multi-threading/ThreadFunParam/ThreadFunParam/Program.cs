using System;
using System.Threading;

namespace ThreadFunParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            Thread t1 = new Thread(obj.DisplayNumber);

            t1.Start(6);
            Console.ReadKey();
        }

        public void DisplayNumber(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 0; i <= Number; i++)
            {
                Console.WriteLine("Display Number " + i);
            }
        }
    }
}
