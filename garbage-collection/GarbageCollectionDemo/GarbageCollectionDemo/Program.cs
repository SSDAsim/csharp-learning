using System;
        
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 1000000; i++)
            {
                MyClass1 myClass1 = new MyClass1();
                MyClass2 myClass2 = new MyClass2();
                MyClass3 myClass3 = new MyClass3();
            }

            Console.Read();
        }
    }

    class MyClass1
    {

    }
    class MyClass2
    {

    }
    class MyClass3
    {

    }
}
