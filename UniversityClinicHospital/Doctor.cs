using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor()
        {

        }
        
        public Doctor(string name, int employeeNumber, string specialty) : base(name, employeeNumber)
        {
            Specialty = specialty;
            Salary = 90000;
        }
        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Specialty: {Specialty}");
        }
    }
}
