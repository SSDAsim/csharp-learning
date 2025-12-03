using System;
namespace StaticConstrcutor
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("static constructor was called");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method was called");
            Console.ReadKey();
        }
    }
    // static constructor will be executed first and then the Main method
}