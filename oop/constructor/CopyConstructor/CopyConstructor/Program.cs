using System;
namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Dispaly();
            // initialize using copy constructor 
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Dispaly();

            Console.ReadKey();
        }
    }

    public class CopyConstructor
    {
        int x;

        // Parameterized constructor 
        public CopyConstructor(int i)
        {
            x = i;
        }

        // Copy Constructor 
        public CopyConstructor(CopyConstructor Obj)
        {
            x = Obj.x;
        }

        public void Dispaly()
        {
            Console.WriteLine($"Value of x is : {x}");
        }
    }
}