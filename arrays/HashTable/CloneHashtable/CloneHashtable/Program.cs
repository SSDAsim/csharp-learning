using System;
using System.Collections;

namespace CloneHashtable
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
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");

            // Hashtable elements
            Console.WriteLine("Hashtable elements: ");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // Creating a clone Hashtable 
            Hashtable cloneHashtable = (Hashtable)hashtable.Clone();

            Console.WriteLine("\nClone Hashtable Elements: ");
            foreach (DictionaryEntry entry in cloneHashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.ReadKey();

        }
    }
}
