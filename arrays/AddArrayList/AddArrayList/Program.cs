using System;
using System.Collections;

namespace AddArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using Add() to add elements to ArrayList
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("James");
            arrayList1.Add("James"); // adding duplicate values
            arrayList1.Add(" ");
            arrayList1.Add(true);
            arrayList1.Add(4.5);
            arrayList1.Add(null);

            // while adding elements to the ArrayList, the elements are casted into object and then stored in collection.
            // while accessing the element, appropriate casting is required or you can use the 'var' keyword

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            int firstElement = (int)arrayList1[0];
            string secondElement = (string)arrayList1[1];
            Console.WriteLine($"firstElement: {firstElement}, secondElement: {secondElement}");

            var arrayList2 = new ArrayList()
            {
                102, "Sundar", false, null, 9.9
            };

            Console.WriteLine("\n\nIterating using for loop");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.WriteLine($"{arrayList2[i]}");
            }

            var firstElement1 = arrayList2[0];
            var secondElement1 = arrayList2[1];
            Console.WriteLine($"firstElement1: {firstElement1}, secondElement1: {secondElement1}");

            Console.ReadKey();
        }
    }
}
