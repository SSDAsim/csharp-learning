using System;
namespace HasARelationship
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Laker Street", "San Diego", "California");
            Employee emp = new Employee(1, "Tom", address);
            emp.Display();
            Console.ReadKey();
        }
    }

    public class Address
    {
        public string AddressLine, City, State;
        public Address(string adress, string city, string state)
        {
            AddressLine = adress;
            City = city;
            State = state;
        }
    }

    public class Employee
    {
        // using HasA relationship 
        public Address address; // HasA relationship (Employee HasA address)
        public int Id;
        public string Name;
        public Employee(int id, string name, Address adres)
        {
            Id = id;
            Name = name;
            address = adres;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID is {Id}");
            Console.WriteLine($"Employee Name is {Name}");
            Console.WriteLine($"Employee AddressLine is {address.AddressLine}");
            Console.WriteLine($"Employee City is {address.City}");
            Console.WriteLine($"Employee State is {address.State}");
        }
    }
}