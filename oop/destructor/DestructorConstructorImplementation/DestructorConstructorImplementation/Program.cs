using System;
namespace DestructorConstructorImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Third obj = new Third();
            obj = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
    public class First
    {
        public First()
        {
            Console.WriteLine("Constructor of First is called");
        }

        ~First()
        {
            Console.WriteLine("Destructor of First is called");
        }
    }

    public class Second : First
    {
        public Second()
        {
            Console.WriteLine("Constructor of Second is called");
        }

        ~Second()
        {
            Console.WriteLine("Destructor of Second is called");
        }
    }

    public class Third : Second
    {
        public Third()
        {
            Console.WriteLine("Constructor of Third is called");
        }

        ~Third()
        {
            Console.WriteLine("Destructor of Third is called");
        }
    }
}