using System;
using System.Diagnostics;
using System.Text;
namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder = new StringBuilder();
            Console.WriteLine("Loop Started");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 30000; i++)
            {
                stringbuilder.Append("DotNet Tutorials");
            }
            stopwatch.Stop();

            Console.WriteLine("Loop Ended");
            Console.WriteLine("Time taken by the loop is: " + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();

            // concatenating string using the StringBuilder() is better approach as compared to using '+' and it is far more effiecient because every time the for loop runs it will not create fresh objects rather than it will use the same memory location
        }
    }
}
