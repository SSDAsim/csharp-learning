using System;

namespace DestructorExplicit
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Objected Created");
        }

        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine("Object {type} is destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo demo1 = new DestructorDemo();
            DestructorDemo demo2 = new DestructorDemo();

            // making an object null for garbage collection 
            demo1 = null;
            demo2 = null;
            GC.Collect(); // explicit call to garbage collection
            Console.ReadKey();
        }
    }
}
