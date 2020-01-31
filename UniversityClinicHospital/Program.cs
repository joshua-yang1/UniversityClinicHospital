using System;

namespace UniversityClinicHospital
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool activeSession = true;
            Employee employee = new Employee();
            Employee medicalEmployee = new Employee();
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Patient patient = new Patient();
            

            employee.listOfEmployees.Add(new Doctor("Doctor Jones", 11, "foot"));
            employee.listOfEmployees.Add(new Doctor("Doctor Paul", 22, "heart"));
            employee.listOfEmployees.Add(new Nurse("Nurse Joy", 33, 2));
            employee.listOfEmployees.Add(new Nurse("Nurse Robert", 44, 1));
            employee.listOfEmployees.Add(new Receptionist("Receptionist Nathan", 55, true));
            employee.listOfEmployees.Add(new Receptionist("Receptionist Veronica", 66, false));
            employee.listOfEmployees.Add(new Janitor("Janitor John", 77, false));
            employee.listOfEmployees.Add(new Janitor("Janitor Ralph", 88, true));

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
                Console.WriteLine("4. Check Patient Status");
                Console.WriteLine("5. Draw Blood");
                Console.WriteLine("6. Care For Patient");
                Console.WriteLine("7. Exit Interface");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            employee.PrintEmployeeList();
                            employee.ClearScreen();
                            break;
                        }

                    case "2":
                        {
                            employee.PrintMedicalEmployeeList();
                            medicalEmployee = employee.SelectMedicalEmployee();
                            Console.WriteLine($"You have selected {medicalEmployee.Name}.");
                            employee.ClearScreen();
                            break; 
                        }

                    case "3":
                        {
                            employee.PayEmployees();
                            employee.ClearScreen();
                            break;
                        }
                    case "4":
                        {
                            patient.ShowPatientStatus();
                            employee.ClearScreen();
                            break;
                        }
                    case "5":
                        {
                            medicalEmployee.DrawBlood(patient);
                            employee.ClearScreen();
                            break;
                        }

                    case "6":
                        {
                            medicalEmployee.CareForPatient(patient);
                            employee.ClearScreen();
                            break;
                        }

                    case "7":
                        {
                            activeSession = false;
                            break;
                        }
                }
            } while (activeSession == true);
        }
    }
}
