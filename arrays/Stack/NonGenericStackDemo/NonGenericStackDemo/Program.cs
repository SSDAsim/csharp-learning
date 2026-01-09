using System;
using System.Collections;

namespace NonGenericStackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack();

            // Push to stack 
            stack1.Push(10);
            stack1.Push("Hello");
            stack1.Push(3.5f);
            stack1.Push(true);
            stack1.Push(67.5);
            stack1.Push('A');

            Console.WriteLine($"All Stack Elements: {stack1.Count}");
            foreach (object item in stack1)
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine($"Old Count of Stack elements Before Pop(): {stack1.Count}");
            Console.WriteLine($"\nDeleted Element from the Stack: {stack1.Pop()}"); // remove and return top most element
            Console.WriteLine($"New Count of Stack elements: {stack1.Count}");

            Console.WriteLine($"\nLooking at the top most element of the Stack: {stack1.Peek()}"); // return top most element (without removing)
            Console.WriteLine($"New Count of Stack elements: {stack1.Count}");

            // check if stack contains specific element
            if(stack1.Contains('A'))
            {
                Console.WriteLine("\nStack Contains 'A'");
            } else
            {
                Console.WriteLine("\nStack Does not Contain 'A'");
            }

            if (stack1.Contains(3.5f))
            {
                Console.WriteLine($"\nStack Contains {3.5f}");
            } else
            {
                Console.WriteLine($"\nStack Does Not Contain {3.5f}");
            }

            Console.ReadKey();
        }
    }
}
