using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor()
        {

        }

        public Janitor(string name, int employeeNumber, bool isSweeping) : base(name, employeeNumber)
        {
            IsSweeping = isSweeping;
            Salary = 40000;
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Is Sweeping? {IsSweeping}");
        }
    }
}
