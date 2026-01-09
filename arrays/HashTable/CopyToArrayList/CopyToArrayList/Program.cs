using System;
using System.Collections;

namespace CopyToArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };

            Console.WriteLine("ArrayList Elements: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }

            // Copying the arrayList to an object array
            object[] arrayListCopy = new object[arrayList.Count];
            arrayList.CopyTo(arrayListCopy);
            Console.WriteLine("\nArrayList Copy Array Elements:");
            foreach (var item in arrayListCopy) 
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
