using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritence obj = new MultipleInheritence();
            // you can not call the show method using obj because the Show() in explicitly implemented using interface, so you can only call it through reference of Interface1 
            // obj.show()
            obj.Test();

            // using Interface Reference call the show method
            Interface1 i1 = obj;
            i1.Show();

            // Typecast the object to interface type and call the show method
            ((Interface2)obj).Show();

            Console.ReadKey();
        }
    }

    public interface Interface1
    {
        void Test();
        void Show();
    }

    public interface Interface2
    {
        void Test();
        void Show();
    }

    public class MultipleInheritence: Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Test method is implemented in child class");
        }

        // explicitly implement interface1 method
        void Interface1.Show()
        {
            Console.WriteLine("Show method of Interface1 is implemented in child class.");
        }

        // explicit interface implementation
        void Interface2.Show()
        {
            Console.WriteLine("Show method of Interface2 is implemented in child class.");
        }
    }
}
