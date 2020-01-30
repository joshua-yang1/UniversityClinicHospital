using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        public List<Employee> listOfEmployees = new List<Employee>();
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public bool HasBeenPaid { get; set; }
        //add base constructor
        public Employee()
        {

        }
        public Employee(string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            HasBeenPaid = false;
        }
        public void FillEmployeeList()
        {
            listOfEmployees.Add(new Employee("George", 1234));
            listOfEmployees.Add(new Employee("Paul", 12345));
        }
        public void PrintEmployeeList()
        {
            foreach(Employee employee in listOfEmployees)
            {
                Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid}");
            }
        }

        public void PayEmployees()
        {
            foreach (Employee employee in listOfEmployees)
            {
                if (HasBeenPaid == true)
                {
                    Console.WriteLine($"{Name} has already been paid.");
                }
                else
                {
                    HasBeenPaid = true;
                    Console.WriteLine($"{Name} has been paid.");
                }
            }
        }
    }
}
