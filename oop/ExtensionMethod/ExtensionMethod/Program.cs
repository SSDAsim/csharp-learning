using System;
using System.Linq;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();

            Console.WriteLine("string: " + myWord);
            Console.WriteLine("count: " + wordCount);
            Console.ReadKey();
        }
    }

    // extend String class Functionlaity

    public static class StringExtension
    {
        public static int GetWordCount(this string inputString)
        {
            // null check 
            if (!string.IsNullOrEmpty(inputString))
            {
                // split the array by space - create an array of words 
                string[] strArray = inputString.Split(' ');
                return strArray.Count();
            } else
            {
                return 0;
            }
        }
    }
}
