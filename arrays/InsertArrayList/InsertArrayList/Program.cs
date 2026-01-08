using System;
using System.Collections;
namespace InsertArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList()
            {
                202, "Izmir", false, 4.4
            };

            Console.WriteLine("Items before inserting in the ArrayList\n");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // insert at the specified location in the ArrayList
            // arrayList1.insert(int index, object? value)

            arrayList1.Insert(0, 101);

            arrayList1.Insert(2, "Panda");

            Console.WriteLine("Items after inserting in the ArrayList\n");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
