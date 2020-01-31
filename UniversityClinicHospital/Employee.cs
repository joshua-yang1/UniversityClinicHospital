using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        public List<Employee> listOfEmployees = new List<Employee>();
        public List<Employee> listOfMedicalEmployees = new List<Employee>();

        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public bool HasBeenPaid { get; set; }
        public bool IsMedicalEmployee { get; set; }
        //add base constructor
        public Employee()
        {

        }
        public Employee(string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
        }
        
        public virtual void PrintEmployeeInfo()
        {
            
        }
        public void PrintEmployeeList()
        {
            foreach(Employee employee in listOfEmployees)
            {
                employee.PrintEmployeeInfo();
            }
        }

        public void PrintMedicalEmployeeList()
        {
            int count = 1;
            foreach (Employee employee in listOfMedicalEmployees)
            {
                Console.WriteLine($"{count}. Name: {employee.Name} | Number: {employee.EmployeeNumber}");
                count++;
            }
        }

        public Employee SelectMedicalEmployee()
        {           
            Console.WriteLine("Select Medical Employee by typing their number:");
            int selectEmployee = Convert.ToInt32(Console.ReadLine());
            int employeeIndex = (selectEmployee - 1);
            return listOfMedicalEmployees[employeeIndex];
        }

        public void PayEmployees()
        {
            foreach (Employee employee in listOfEmployees)
            {
                if (HasBeenPaid == true)
                {
                    Console.WriteLine($"{employee.Name} has already been paid.");
                }
                else
                {
                    employee.HasBeenPaid = true;
                    Console.WriteLine($"{employee.Name} has been paid.");
                }
            }
        }

        public virtual void DrawBlood(Patient patient)
        {

        }

        public virtual void CareForPatient(Patient patient)
        {

        }
        public void ClearScreen()
        {
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
