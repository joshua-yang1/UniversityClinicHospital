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
            employee.listOfEmployees.Add(new Doctor("George", 11, "foot"));
            employee.listOfEmployees.Add(new Doctor("Paul", 22, "heart"));
            employee.listOfEmployees.Add(new Nurse("Anne", 33, 2));
            employee.listOfEmployees.Add(new Nurse("Robert", 44, 1));
            employee.listOfEmployees.Add(new Receptionist("Nathan", 55, true));
            employee.listOfEmployees.Add(new Receptionist("Veronica", 66, false));
            employee.listOfEmployees.Add(new Janitor("John", 77, false));
            employee.listOfEmployees.Add(new Janitor("Ralph", 88, true));

            Console.WriteLine("University Clinic Hospital");
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. View List of Employees");
            Console.WriteLine("2. Pay Employees");
            Console.WriteLine("3. Draw Blood");
            Console.WriteLine("4. Care For Patient");
            Console.WriteLine("5. Exit Interface");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    {
                        employee.PrintEmployeeList();
                        break;
                    }

                case "2":
                    {
                        employee.PayEmployees();
                        break;
                    }
                case "3":
                    {
                        break;
                    }
            }
        }
    }
}
