using System;
namespace non_static_variables
{
    class Program
    {
        static int x = 100;
        int y = 200;

        // x is static variable and does not require any instance of class.
        // y is non-static variable and it is going to be created only if we creat an instance of the Program class 
        // any variable created inside a static block is a static variable
        static void Main(string[] args)
        {
            Console.WriteLine($"x value: {x}");
            //Console.WriteLine($"y value: {y}"); will require an instance to create this variable 
            Program obj = new Program();
            Console.WriteLine($"y value is: {obj.y}");
            Console.ReadKey();
        }

        // you can initialize the static as well as non-static variable through class constructor but each time you call the constructor the value of the static variable will be over-ridden.
        // in case of non-static variable, each object will have an own copy of the variable while we can have only one copy of the static variable

        // scope of instance variable is throughout the class except in static methods 
        // scope of the static variable is throughout the class
    }
}
