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
    }
}
