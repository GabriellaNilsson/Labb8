using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    public class Employee
    {
        // Auto-implemented properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        // Constructor
        public Employee(int Id, string name, string gender, int salary)
        {
            ID = Id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Method to print objects, using foreach loop in main method
        public void PrintInfo()
        {
            Console.WriteLine($"Employee ID: {ID} Name: {Name} Gender: {Gender} Salary: {Salary}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Employee ID: {ID} Name: {Name} Gender: {Gender} Salary: {Salary}");
        }

    }
}
