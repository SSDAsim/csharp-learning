using System;
namespace GetType
{
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor of class A called");
        }

        public void Method1()
        {
            Console.WriteLine("Method1 of class A called");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor of class B called");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 of class B called");
        }

        static void Main()
        {
            Object obj1 = new Object();
            Console.WriteLine($"obj1 type: {obj1.GetType()}");
            A obj2 = new A();
            Console.WriteLine($"obj2 type: {obj2.GetType()}");
            B obj3 = new B();
            Console.WriteLine($"obj3 type: {obj3.GetType()}");

            Console.ReadKey();
        }
    }
}