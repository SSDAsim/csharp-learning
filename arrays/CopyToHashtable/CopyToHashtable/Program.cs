using System;
using System.Collections;
namespace CopyToHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Location", "Mumbai");
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Hashtable Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // Copy the non-generic hashtables elements into one dimensional array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count];
            hashtable.CopyTo(myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements:");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // copy keys and values separately
            Object[] myArrayKeys = new Object[hashtable.Count];
            Object[] myArrayValues = new Object[hashtable.Count];
            Console.WriteLine("\nCopy just Hashtable Keys to the array: ");
            hashtable.Keys.CopyTo(myArrayKeys, 0);
            foreach (var key in myArrayKeys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Copy just Hashtable Values to the array: ");
            hashtable.Values.CopyTo(myArrayValues, 0);
            foreach (var value in myArrayValues)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
