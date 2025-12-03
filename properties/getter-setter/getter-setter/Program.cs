using System;
using System.Xml.Linq;
namespace getter_setter
{
    class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark;

        // getter and setter 
        public void SetID(int ID)
        {
            if(ID < 0)
            {
                throw new Exception("ID value should be greater than zero.");
            }

            _ID = ID;
        }

        public int GetID()
        {
            return _ID;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name can not be empty.");
            }
            _Name = Name;
        }

        public string GetName()
        {
            return _Name;
        }

        public int GetPassMarks()
        {
            return _PassMark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            // set properties
            student.SetID(110);
            student.SetName("Pranaya");

            // get properties
            Console.WriteLine($"ID = {student.GetID()}");
            Console.WriteLine($"Name = {student.GetName()}");
            Console.WriteLine($"PassMarks = {student.GetPassMarks()}");
            Console.ReadKey();
        }
    }
}