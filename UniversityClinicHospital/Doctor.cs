﻿using System;
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
            /*this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.Specialty = specialty;*/
            Specialty = specialty;
            Salary = 90000;
        }
        public override void PrintEmployeeList()
        {
            foreach (Doctor doctor in listOfEmployees)
            {
                Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Specialty: {Specialty}");
            }
        }
    }
}
