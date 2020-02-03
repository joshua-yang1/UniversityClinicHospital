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

            employee.AddEmployeesToList();

            foreach(Employee emp in employee.listOfEmployees)
            {
                if (emp.IsMedicalEmployee == true)
                {
                    employee.listOfMedicalEmployees.Add(emp);
                }
            }

            do
            {
                employee.MenuLoop();
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
