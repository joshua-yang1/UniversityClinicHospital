using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }

        public Nurse()
        {

        }

        public Nurse(string name, int employeeNumber, int numberofPatients) : base(name, employeeNumber)
        {
            NumberofPatients = numberofPatients;
            Salary = 50000;
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Number of Patients: {NumberofPatients}");
        }
    }
}
