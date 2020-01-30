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
        }
        public virtual void PrintEmployeeInfo()
        {
            
        }
        public virtual void PrintEmployeeList()
        {
            foreach(Employee employee in listOfEmployees)
            {
                employee.PrintEmployeeInfo();
                //Console.WriteLine($"Name: {employee.Name} | Number: {employee.EmployeeNumber} | Salary: {employee.Salary} | Has Been Paid? {employee.HasBeenPaid}");
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
