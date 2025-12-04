using System;
namespace properties
{
    // properties are used to set or get the value of the private members of the class
    public class Employee
    {
        // Private properties
        private int _EmpId;
        private string _EmpName; 
        
        // Public properties
        public int EmpId
        {
            // set the value of the private property using Set Accessor 
            set
            {
                _EmpId = value;
            }

            // get the value using Get Accessor
            get
            {
                return _EmpId;
            }
        }

        public string EmpName
        {
            set
            {
                _EmpName = value;
            }

            get
            {
                return _EmpName;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            // set the values of the private members using the set accessors
            employee.EmpId = 200;
            employee.EmpName = "test";

            // get the values of the private members
            Console.WriteLine("Employee Details: ");
            Console.WriteLine("Employee Id is " + employee.EmpId);
            Console.WriteLine("Employee Name is " + employee.EmpName);

            Console.ReadKey();
        }
    }
}