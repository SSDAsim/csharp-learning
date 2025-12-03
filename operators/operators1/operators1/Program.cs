using System;

namespace operators1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, z;
            z = x++ * --y;

            Console.WriteLine($"x : {x}, y : {y}, z: {z}");
            Console.ReadKey();
            
        }
        // this is how expression ` x++ * --y ` is going to be evaulated 
        // pre increment/decrement first 
        // second step is substituion. substitute the value of x and y. x will be substituted by 10 and y by 19
        // evaulation of expression i.e. 10 * 19 = 190
        // assignment: assigning the value to the left side of the expression i.e z will become 190
        // last step is post increment/decrement now x will become 11
    }
}
