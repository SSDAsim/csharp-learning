using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadFuncTypeSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            NumberHelper obj = new NumberHelper(num);

            Thread T1 = new Thread(new ThreadStart(obj.DisplayNumber));

            T1.Start();
            Console.ReadKey();

        }
    }

    // make a separate class 
    public class NumberHelper
    {
        private int _Number;

        public NumberHelper (int Number)
        {
            _Number = Number;
        }

        public void DisplayNumber ()
        {
            for (int i = 0; i <= _Number; i++)
            {
                Console.WriteLine("value: " + i);
            }
        }
    }
}
