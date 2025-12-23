using System;
using System.Threading;

namespace RetrieveDataFromThread
{
    public delegate void ResultCallbackDelegate(int Results);

    // Helper class 
    public class HelperNumber
    {
        private int _Number;
        private ResultCallbackDelegate _ResultCallback;

        //Initializing the private variables through constructor
        //So while creating the instance you need to pass the value for Number and callback delegate
        public HelperNumber(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _Number = Number;
            _ResultCallback = resultCallbackDelegate;
        }

        //This is the Thread function which will calculate the sum of the numbers
        public void CalculateSum ()
        {
            int Result = 0;
            for (int i = 0; i <= _Number; i++)
            {
                Result += i;
            }

            //Before the end of the thread function call the callback method
            if (_ResultCallback != null)
            {
                _ResultCallback(Result);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create the ResultCallbackDelegate instance and to its constructor 
            //pass the callback method name
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);

            int Number = 10;

            //Creating the instance of NumberHelper class by passing the Number
            //the callback delegate instance
            HelperNumber obj = new HelperNumber(Number, resultCallbackDelegate);

            //Creating the Thread using ThreadStart delegate
            Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));

            T1.Start();
            Console.WriteLine();
        }

        public static void ResultCallBackMethod (int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
