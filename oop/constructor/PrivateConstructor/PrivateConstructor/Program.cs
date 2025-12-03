using System;
namespace PrivateConstructor
{
    class Program
    {
        // if a class has a private constructor and none any other public constructor then this class is instatntiated only within the class and not from outside the class 
        private Program()
        {
            Console.WriteLine("Private Constructor Called");
        }

        public void Method1()
        {
            Console.WriteLine("Method1 called");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("It has been instantiated!!");
            Console.ReadKey();
        }
    }
}