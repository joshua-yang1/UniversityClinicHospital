using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool IsOnThePhone { get; set; }

        public Receptionist()
        {

        }

        public Receptionist(string name, int employeeNumber, bool isonthePhone) : base(name, employeeNumber)
        {
            IsOnThePhone = isonthePhone;
            Salary = 45000;
            IsMedicalEmployee = false;
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | On the Phone? {IsOnThePhone}");
        }
    }
}
