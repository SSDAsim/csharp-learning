using System;
using System.Collections;
namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a Queue
            Queue myQueue = new Queue();

            // enqueue -> add elements at the end of the queue
            myQueue.Enqueue(1);
            myQueue.Enqueue("Hello");
            myQueue.Enqueue(3.5);
            myQueue.Enqueue(true);

            // Clone a queue 
            Queue cloneQueue = (Queue)myQueue.Clone();

            // display queue elements
            Console.WriteLine($"Queue Elements are: {myQueue.Count}");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nQueue Elements before Dequeue operation: {myQueue.Count}");

            // Dequeue -> remove and reutrn the oldest element of the queue
            Console.WriteLine($"\nDequeuing element: {myQueue.Dequeue()}");

            // display queue elements
            Console.WriteLine($"\nQueue Elements after Dequeue operation: {myQueue.Count}");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            // Peek() -> returns the oldest element without removing it
            Console.WriteLine($"\nQueue Elements before Peek operation: {myQueue.Count}");
            Console.WriteLine($"Peeking element: {myQueue.Peek()}");
            Console.WriteLine($"\nQueue Elements after Peek operation: {myQueue.Count}");

            // Clear -> clears all queue elements
            Console.WriteLine($"\nClearing all Queue Elements..");
            myQueue.Clear();

            // display queue elements
            Console.WriteLine($"\nQueue Elements after Clear operation: {myQueue.Count}");
            if (myQueue.Count > 0)
            {
                foreach (var item in myQueue)
                {
                    Console.WriteLine(item);
                }
            }

            // display clone queue elements
            Console.WriteLine($"\nCloned Queue Elements: {cloneQueue.Count}");
            foreach (var item in cloneQueue)
            {
                Console.WriteLine(item);
            }

            // copy queue objects to an arary of object
            Object[] queueArray = new Object[cloneQueue.Count];
            cloneQueue.CopyTo(queueArray, 0);

            // display copied array elements
            Console.WriteLine($"\nCopied queue array Elements:");
            foreach (var item in queueArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
