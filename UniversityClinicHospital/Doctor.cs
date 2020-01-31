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
            IsMedicalEmployee = true;
        }
        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Specialty: {Specialty}");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
            Console.WriteLine("Patient blood level has decreased by 5.");
        }

        public override void CareForPatient(Patient patient)
        {
            patient.HealthStatus += 5;
            Console.WriteLine("Patient health level has increased by 5.");
        }
    }
}

