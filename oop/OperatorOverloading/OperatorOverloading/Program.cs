using System;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex(1, 2);
            Complex C2 = new Complex(3, 4);
            //Complex C3 = Complex.Add(C1, C2);
            Complex C3 = C1 + C2;
            C3.Display();

            Console.ReadKey();
        }
    }

    public class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }

        // operator overloading 
        //public static Complex Add(Complex a, Complex b)
        public static Complex operator +(Complex a, Complex b)
        {
            Complex temp = new Complex();
            temp.real = a.real + b.real;
            temp.img = a.img + b.img;
            return temp;
        }

        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
}
