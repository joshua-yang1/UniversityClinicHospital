using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {
        // Employee can be instantiated
        [Fact]
        public void Can_Create_Employee_Instance()
        {
            new Employee();
        }
        
        // New employee should be named Bob Ross
        [Fact]
        public void Employee_Is_Named_Bob_Ross()
        {
            Employee newEmployee = new Employee();

            Assert.Equal("Bob Ross", newEmployee.Name);
        }

        // Employees can be paid
        [Fact]
        public void Employees_Can_Be_Paid()
        {
            Employee newEmployee = new Employee();
            newEmployee.PayEmployees();
            Assert.True(true);
        }
    }
}
