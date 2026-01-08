using System;
using System.Collections;

namespace InsertRangeArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // insert an ArrayList into another one at specifc index 

            ArrayList arrayList1 = new ArrayList()
            {
                "IND", "PAK", "BAN"
            };

            Console.WriteLine("ArrayList1 Before: \n");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nArrayList2 Before:\n");
            ArrayList arrayList2 = new ArrayList()
            {
                "UK", "IRE", "SCO"
            };

            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }

            arrayList2.InsertRange(1, arrayList1);
            Console.WriteLine("\nArrayList2 After: \n");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
