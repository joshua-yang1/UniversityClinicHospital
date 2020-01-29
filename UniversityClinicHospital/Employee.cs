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
        public Employee()
        {
            Name = "Bob Ross";
            EmployeeNumber = 123;
            Salary = 90000;
            HasBeenPaid = false;
        }
        public Employee(string name, int employeeNumber, int salary, bool hasBeenPaid)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            HasBeenPaid = hasBeenPaid;
        }
    }
}
