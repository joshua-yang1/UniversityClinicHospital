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

        public void MenuLoop()
        {
            Console.WriteLine("University Clinic Hospital");
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. View List of Employees");
            Console.WriteLine("2. Select Medical Employee");
            Console.WriteLine("3. Pay Employees");
            Console.WriteLine("4. Check Patient Status");
            Console.WriteLine("5. Draw Blood");
            Console.WriteLine("6. Care For Patient");
            Console.WriteLine("7. Exit Interface");
        }
        
        public virtual void PrintEmployeeInfo()
        {
            
        }

        public void AddEmployeesToList()
        {
            listOfEmployees.Add(new Doctor("Doctor Jones", 11, "foot"));
            listOfEmployees.Add(new Doctor("Doctor Paul", 22, "heart"));
            listOfEmployees.Add(new Nurse("Nurse Joy", 33, 2));
            listOfEmployees.Add(new Nurse("Nurse Robert", 44, 1));
            listOfEmployees.Add(new Receptionist("Receptionist Nathan", 55, true));
            listOfEmployees.Add(new Receptionist("Receptionist Veronica", 66, false));
            listOfEmployees.Add(new Janitor("Janitor John", 77, false));
            listOfEmployees.Add(new Janitor("Janitor Ralph", 88, true));
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
