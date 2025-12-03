using System;

namespace char_literal
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'a';
            Console.WriteLine("Single Quote: " + ch1);

            char ch2 = '\u0041';
            Console.WriteLine("Unicdoe: " + ch2);

            // character literal using escape sequence
            Console.WriteLine("Escape: Hello\nDotNet\nTutorials");
        }
    }
}