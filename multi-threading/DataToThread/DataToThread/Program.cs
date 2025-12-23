using System;
using System.Threading;

namespace DataToThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            ParameterizedThreadStart PTSD = new ParameterizedThreadStart(obj.DisplayNumber);
            Thread t1 = new Thread(PTSD);

            t1.Start("Hi"); // this line might cause an error
            Console.ReadKey();

        }

        public void DisplayNumber (object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 0; i <= Number; i++)
            {
                Console.WriteLine("Method1 " + i);
            }
        }
    }
}
