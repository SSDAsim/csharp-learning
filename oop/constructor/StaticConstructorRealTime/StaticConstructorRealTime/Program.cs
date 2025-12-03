using System;
namespace StaticConstructorReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Example exmp1 = new Example();
            exmp1.Display();
            exmp1.Increment();
            exmp1.Display();

            Example exmp2 = new Example();
            exmp2.Display();
            exmp2.Increment();
            exmp2.Display();

            Console.ReadKey();

            // static constructor will be executed first
        }
    }

    public class Example
    {
        int i;
        static int j; // will be initialized using Static Constructor

        // Default Constructor 
        public Example()
        {
            Console.WriteLine("Default constructor called!");
            i = 100;
        }

        // Static Constructor 
        static Example()
        {
            Console.WriteLine("Static Constructor called!");
            j = 200;
        }

        // Increment 
        public  void Increment()
        {
            i++;
            j++;
        }

        public void Display()
        {
            Console.WriteLine($"Value of i is: {i}");
            Console.WriteLine($"Value of j is: {j}");
        }
    }
}