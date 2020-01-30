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
            /*this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.Specialty = specialty;*/
            Specialty = specialty;
            Salary = 90000;
        }
    }
}
