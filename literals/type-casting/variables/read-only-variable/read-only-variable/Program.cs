using System;

namespace read_only_variable
{
    internal class Program
    {
        const float PI = 3.14f; // have to be initialzed at the time of the declaration
        static int x = 100;
        // variable y and z will be initialized through the constructor 
        int y; 
        readonly int z; // readonly variable, can only be initialized at the time of declaration or inside a constructor

        public Program(int a, int b)
        {
            y = a;
            z = b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"x value: {x}");
            Console.WriteLine($"PI value: {PI}");

            Program obj1 = new Program(200, 45);
            Program obj2 = new Program(400, 55);

            //obj1.z = 22; // this will throw an error since readonly can only be initialized inside the constructor

            Console.WriteLine($"obj1.y value: {obj1.y} and obj1.z value: {obj1.z}");
            Console.WriteLine($"obj2.y value: {obj2.y} and obj2.z value: {obj2.z}");

            Console.ReadKey();
        }
    }
}
