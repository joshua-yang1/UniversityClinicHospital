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
            IsMedicalEmployee = true;
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} | Number: {EmployeeNumber} | Salary: {Salary} | Has Been Paid? {HasBeenPaid} | Number of Patients: {NumberofPatients}");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 3;
            Console.WriteLine("Patient blood level has decreased by 3.");
        }

        public override void CareForPatient(Patient patient)
        {
            patient.HealthStatus += 3;
            Console.WriteLine("Patient health status has increased by 3.");
        }
    }
}
