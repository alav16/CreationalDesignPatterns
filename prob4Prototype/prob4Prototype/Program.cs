/*
Create a system for managing employee records where you can quickly copy an existing employee
and modify only specific fields like name or address.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4Prototype
{

    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public Employee(string name, string lastName, string position, int age)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            Age = age;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}  Lastname: {LastName} Position: {Position} Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Aram", "Asatryan", "Head", 39);

            employee.Show();
           
            var cloned = (Employee)employee.Clone();
            cloned.Name = "Ani";
            cloned.Age = 30;

            cloned.Show();
        }
    }
}
