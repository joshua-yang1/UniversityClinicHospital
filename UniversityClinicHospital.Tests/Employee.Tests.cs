using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {

        // Employees can be paid
        [Fact]
        public void Employees_Can_Be_Paid()
        {
            Employee newEmployee = new Employee();

            newEmployee.PayEmployees();

            Assert.True(newEmployee.HasBeenPaid);
        }

        // DrawBlood increases BloodLevel by 5
        [Fact]
        public void DrawBlood_Increases_BloodLevel_By_5()
        {
            Doctor newDoctor = new Doctor();
            Patient newPatient = new Patient();

            newDoctor.DrawBlood();

            Assert.Equal(25, newPatient.BloodLevel);
        }
    }
}
