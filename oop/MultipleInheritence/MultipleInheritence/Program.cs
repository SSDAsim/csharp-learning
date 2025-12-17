using System;
using System.Security.Cryptography.X509Certificates;

namespace MultipleInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // laser jet printer 
            LaserJetPrinter laserPrinter = new LaserJetPrinter();
            laserPrinter.Print("LaserJet Print Content");
            laserPrinter.Scan("LaserJet Scan Content");
            laserPrinter.Fax("LaserJet Fax Content");
            laserPrinter.PrintDuplex("LaserJet PrintDuplex Content");

            // Ink jet printer 
            InkJetPrinter inkjerPrinter = new InkJetPrinter();
            inkjerPrinter.Print("Inkjet Print Content");
            inkjerPrinter.Scan("LaserJet Scan Content");

            Console.ReadKey();
        }
    }

    // multiple inheritence: instead of having all the methods in same interface, split them into multiple interfaces. (in case some class does not want to implement all methods)
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }

    public interface IFaxTasks
    {
        void Fax(string content);
    }

    public interface IDuplexTasks
    {
        void PrintDuplex(string content);
    }
    
    // classes 
    // this class wants to implement all the methods of the interfaces
    public class LaserJetPrinter : IPrinterTasks, IFaxTasks, IDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }

        public void Fax(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine(content);
        }
    }

    // this class wants to implement only two methods. so it will only inherit that interface and not participate in multiple inheritence.
    public class InkJetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
}
