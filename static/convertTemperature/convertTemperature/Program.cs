using System;
namespace convert_temperature
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelisu)
        {
            double celsius = Double.Parse(temperatureCelisu);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // convert to double
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // calculate temperature
            double celsius = (fahrenheit - 32) * 5 / 9; 

            return celsius;
        }
    }

    class TestTemperatureConverter
    {
        static void Main()
        {
            Console.WriteLine("Please select a direction");
            Console.WriteLine("1. Convert from Celsius to Fahrenheit.");
            Console.WriteLine("2. Convert from Fahrenheit to Celsius.");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please Enter the temperature in Celsius: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine($"Temperature in Fahrenheit is {F}");
                    break;
                case "2":
                    Console.WriteLine("Please Enter the temperature in Fahrenheit");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine($"Temperature in Celsius is {C}");
                    break;

                default:
                    Console.WriteLine("Please select a convertor");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}