using System;
using System.Collections;

namespace StackClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);

            //Printing All Stack Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Creating a clone queue using Clone method
            Stack cloneStack = (Stack)stack.Clone();

            Console.WriteLine("\nCloned Stack Elements:");
            foreach (var item in cloneStack)
            {
                Console.WriteLine(item);
            }

            // Copying the queue to an object Array 
            Console.WriteLine("\nCopying the queue to an object Array");
            Object[] arrayStack = new object[stack.Count];
            stack.CopyTo(arrayStack, 0);

            Console.WriteLine("StackCopied Array Elements:");
            foreach (var item in arrayStack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
