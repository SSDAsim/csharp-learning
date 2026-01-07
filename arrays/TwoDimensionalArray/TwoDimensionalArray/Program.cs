using System;
namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize an 2d array
            int[,] RectangleArray = new int[4, 5];
            int a = 0;

            // printing the values of 2d array using foreach loop 
            foreach (int i in RectangleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Assigning values using for loop 
            // arr.GetLength(0) returns the size of the rows 
            // arr. GetLength(1) returns the size of the columns
            for(int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    a += 5;
                    RectangleArray[i, j] = a;
                }
            }

            // Printing values using for loop 
            // arr.GetLength(0) returns the size of the rows 
            // arr. GetLength(1) returns the size of the columns
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    Console.Write(RectangleArray[i, j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
