using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            employee.listOfEmployees.Add(new Doctor("George", 1234, "foot"));
            employee.listOfEmployees.Add(new Doctor("Paul", 12345, "heart"));
            employee.listOfEmployees.Add(new Nurse("Anne", 123456, 2));
            employee.listOfEmployees.Add(new Nurse("Robert", 1234567, 1));
            employee.listOfEmployees.Add(new Receptionist("Nathan", 123456, true));
            employee.listOfEmployees.Add(new Receptionist("Veronica", 1234567, false));
            employee.listOfEmployees.Add(new Janitor("John", 123456, false));
            employee.listOfEmployees.Add(new Janitor("Ralph", 1234567, true));

            Console.WriteLine("University Clinic Hospital");
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. View List of Employees");
            Console.WriteLine("2. Pay Employees");
            Console.WriteLine("3. Select Medical Employee Task");
            Console.WriteLine("4. Exit Interface");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    {
                        employee.PrintEmployeeList();
                        break;
                    }
            }
        }
    }
}
