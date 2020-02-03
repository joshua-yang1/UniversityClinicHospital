using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {
        // Employee name can be assigned
        [Fact]
        public void Employee_Name_Can_Be_Assigned()
        {
            Employee newEmployee = new Employee();

            newEmployee.Name = "George";

            Assert.Equal("George", newEmployee.Name);
        }

        // Employee salary can be assigned
        [Fact]
        public void Employee_Salary_Can_Be_Assigned()
        {
            Employee newEmployee = new Employee();

            newEmployee.Salary = 90000;

            Assert.Equal(90000, newEmployee.Salary);
        }

        // Employee number can be assigned
        [Fact]
        public void Employee_Number_Can_Be_Assigned()
        {
            Employee newEmployee = new Employee();

            newEmployee.EmployeeNumber = 01;

            Assert.Equal(01, newEmployee.EmployeeNumber);
        }

        // HasBeenPaid is false by default
        [Fact]
        public void HasBeenPaid_Is_False_By_Default()
        {
            Employee newEmployee = new Employee();

            newEmployee.HasBeenPaid = false;

            Assert.False(newEmployee.HasBeenPaid);
        }

        // Employees can be paid
        [Fact]
        public void Employees_Can_Be_Paid()
        {
            Employee newEmployee = new Employee();
            newEmployee.listOfEmployees.Add(newEmployee);

            newEmployee.PayEmployees();

            Assert.True(newEmployee.HasBeenPaid);
        }

        // DrawBlood decreases BloodLevel by 5
        [Fact]
        public void DrawBlood_Decreases_BloodLevel_By_5()
        {
            Doctor newDoctor = new Doctor();
            Patient newPatient = new Patient();

            newDoctor.DrawBlood(newPatient);

            Assert.Equal(15, newPatient.BloodLevel);
        }

        // CareForPatient increases HealthStatus by 5
        [Fact]
        public void CareForPatient_Increases_HealthStatus_By_5()
        {
            Doctor newDoctor = new Doctor();
            Patient newPatient = new Patient();

            newDoctor.CareForPatient(newPatient);

            Assert.Equal(15, newPatient.HealthStatus);
        }
    }
}
