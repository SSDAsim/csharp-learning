using System;
using System.Collections;

namespace HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTbl = new Hashtable();

            // Adding values to the Hash table
            hashTbl.Add("EId", 1001);
            hashTbl.Add("Name", "Pranaya");
            hashTbl.Add("Salary", 3500);
            hashTbl.Add("Location", "Mumbai");
            hashTbl.Add("Email", "a@a.com");

            // Printing Hashtable values using for loop 
            Console.WriteLine("Printing Hashtable values: ");
            foreach (object obj in hashTbl.Keys)
            {
                Console.WriteLine($"{obj} : {hashTbl[obj]}");
            }

            // Printing specific values 
            Console.WriteLine("\nPrinting specific Hashtable values: ");
            Console.WriteLine($"Location: {hashTbl["Location"]}");
            Console.WriteLine("Salary: " + hashTbl["Salary"]);

            // Creating a Hashtable using collection-initializer syntax 
            Hashtable citiesHashtable = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham" },
                {"IND", "Delhi, Mumbai, Mirzapur" },
                {"PAK", "Islamabad, Karachi, Lahore" }
            };

            Console.WriteLine("\nIterating over a Hashtable created using collection-initializer: ");
            foreach (DictionaryEntry city in citiesHashtable)
            {
                Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
            }

            Console.ReadKey();
        }
    }
}
