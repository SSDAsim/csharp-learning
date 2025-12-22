using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        // 1. declare a delegate
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            // create instance of delegate 
            WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);

            del1(10, WorkType.Golf);

            Console.ReadKey();
        }

        // create handler 
        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Perfomed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings, 
        GenerateReports
    }
}
