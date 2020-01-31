using System;

namespace UniversityClinicHospital
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool activeSession = true;
            Employee employee = new Employee();
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Patient patient = new Patient();
            

            employee.listOfEmployees.Add(new Doctor("George", 11, "foot"));
            employee.listOfEmployees.Add(new Doctor("Paul", 22, "heart"));
            employee.listOfEmployees.Add(new Nurse("Anne", 33, 2));
            employee.listOfEmployees.Add(new Nurse("Robert", 44, 1));
            employee.listOfEmployees.Add(new Receptionist("Nathan", 55, true));
            employee.listOfEmployees.Add(new Receptionist("Veronica", 66, false));
            employee.listOfEmployees.Add(new Janitor("John", 77, false));
            employee.listOfEmployees.Add(new Janitor("Ralph", 88, true));

            foreach(Employee emp in employee.listOfEmployees)
            {
                if (emp.IsMedicalEmployee == true)
                {
                    employee.listOfMedicalEmployees.Add(emp);
                }
            }
            do
            {
                Console.WriteLine("University Clinic Hospital");
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. View List of Employees");
                Console.WriteLine("2. Select Medical Employee");
                Console.WriteLine("3. Pay Employees");
                Console.WriteLine("4. Draw Blood");
                Console.WriteLine("5. Care For Patient");
                Console.WriteLine("6. Exit Interface");
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
                            employee.PrintMedicalEmployeeList();
                            employee.SelectMedicalEmployee();
                            break;
                        }

                    case "3":
                        {
                            employee.PayEmployees();
                            break;
                        }

                    case "4":
                        {
                            employee.DrawBlood(patient);
                            break;
                        }

                    case "5":
                        {
                            employee.CareForPatient(patient);
                            break;
                        }

                    case "6":
                        {
                            activeSession = false;
                            break;
                        }
                }
            } while (activeSession == true);
        }
    }
}
