using System;
namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        private int Id;
        public void Display1()
        {
            //Private Member Accessible with the Containing Type only
            //Where they are created, they are available only within that type
            Console.WriteLine(Id);
        }
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //You cannot access the Private Member from the Derived Class
            //Within the Same Assembly
            Console.WriteLine(Id); //Compile Time Error
        }
    }

    public class AssemblyOneClass3
    {
        public void Dispplay3()
        {
            //You cannot access the Private Member from the Non-Derived Classes
            //Within the Same Assembly
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //Compile Time Error
        }
    }
}