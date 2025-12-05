using System;

// calculate the electricity bills for commercial and domestic plans using abstract class and abstract methods.
namespace ElectricityBill
{
    public abstract class Plan
    {
        protected abstract double getRate();
        public void Calculation(int units)
        {
            double rate = getRate();
            Console.WriteLine($"The bill for {units} is {rate * units}");
        }
    }

    class CommercialPlan : Plan
    {
        protected override double getRate()
        {
            return 5.00;
        }
    }

    class DomesticPlan : Plan
    {
        protected override double getRate()
        {
            return 2.50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("Commercial Plan");
            p = new CommercialPlan();
            p.Calculation(250);

            Console.WriteLine("Domestic Plan");
            p = new DomesticPlan();
            p.Calculation(150);

            Console.ReadKey();
        }
    }
}