using System;
namespace StaticConstructorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started");

            Example ex1 = new Example();
        }
    }

    public class Example
    {
        static Example()
        {
            Console.WriteLine("Static constructor implicit call");
        }
    }
}