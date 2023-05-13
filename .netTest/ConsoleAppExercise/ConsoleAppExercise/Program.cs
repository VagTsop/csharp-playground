using ClassLibrary1;
using System;

namespace ConsoleAppExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            Employee.OrganizationName = "Harsha Inc.";
            Console.WriteLine("::::Please enter Employee Details::::");
            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    Employee emp1 = new Employee();
                    Console.WriteLine("Employee " + i + " Id: ");
                    emp1.EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " EmpName: ");
                    emp1.EmpName = Console.ReadLine();
                    Console.WriteLine("Employee " + i + " SalaryPerHour: ");
                    emp1.SalaryPerHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " NoOfWorkingHours: ");
                    emp1.NoOfWorkingHours = int.Parse(Console.ReadLine());
                    emp1.NetSalary = emp1.SalaryPerHour * emp1.NoOfWorkingHours;
                    Console.Clear();
                    Console.WriteLine("Employee " + i + " details: ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Id: " + emp1.EmpID);
                    Console.WriteLine("EmpName: " + emp1.EmpName);
                    Console.WriteLine("SalaryPerHour: " + emp1.SalaryPerHour);
                    Console.WriteLine("NoOfWorkingHours: " + emp1.NoOfWorkingHours);
                    Console.WriteLine("NetSalary : " + emp1.NetSalary);
                    Console.WriteLine("Do you want to continue to next employee");
                    choice = Console.ReadLine();
                    if (choice == "NO".ToLower())
                        break;
                   
                    Console.Clear();
                }
                if (i == 2)
                {
                    Employee emp2 = new Employee();
                    Console.WriteLine("Employee " + i + " Id: ");
                    emp2.EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " EmpName: ");
                    emp2.EmpName = Console.ReadLine();
                    Console.WriteLine("Employee " + i + " SalaryPerHour: ");
                    emp2.SalaryPerHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " NoOfWorkingHours: ");
                    emp2.NoOfWorkingHours = int.Parse(Console.ReadLine());
                    emp2.NetSalary = emp2.SalaryPerHour * emp2.NoOfWorkingHours;
                    Console.Clear();
                    Console.WriteLine("Employee " + i + " details: ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Id: " + emp2.EmpID);
                    Console.WriteLine("EmpName: " + emp2.EmpName);
                    Console.WriteLine("SalaryPerHour: " + emp2.SalaryPerHour);
                    Console.WriteLine("NoOfWorkingHours: " + emp2.NoOfWorkingHours);
                    Console.WriteLine("NetSalary : " + emp2.NetSalary);
                    Console.WriteLine("Do you want to continue to next employee");
                    choice = Console.ReadLine();
                    if (choice == "NO".ToLower())
                        break;
                   
                    Console.Clear();
                }
                if (i == 3)
                {
                    Employee emp3 = new Employee();
                    Console.WriteLine("Employee " + i + " Id: ");
                    emp3.EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " EmpName: ");
                    emp3.EmpName = Console.ReadLine();
                    Console.WriteLine("Employee " + i + " SalaryPerHour: ");
                    emp3.SalaryPerHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " NoOfWorkingHours: ");
                    emp3.NoOfWorkingHours = int.Parse(Console.ReadLine());
                    emp3.NetSalary = emp3.SalaryPerHour * emp3.NoOfWorkingHours;
                    Console.Clear();
                    Console.WriteLine("Employee " + i + " details: ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Id: " + emp3.EmpID);
                    Console.WriteLine("EmpName: " + emp3.EmpName);
                    Console.WriteLine("SalaryPerHour: " + emp3.SalaryPerHour);
                    Console.WriteLine("NoOfWorkingHours: " + emp3.NoOfWorkingHours);
                    Console.WriteLine("NetSalary : " + emp3.NetSalary);
                    Console.WriteLine("Do you want to continue to next employee");
                    choice = Console.ReadLine();
                    if (choice == "NO".ToLower())
                        break;
                   
                    Console.Clear();
                }
                if (i == 4)
                {
                    Employee emp4 = new Employee();
                    Console.WriteLine("Employee " + i + " Id: ");
                    emp4.EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " EmpName: ");
                    emp4.EmpName = Console.ReadLine();
                    Console.WriteLine("Employee " + i + " SalaryPerHour: ");
                    emp4.SalaryPerHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " NoOfWorkingHours: ");
                    emp4.NoOfWorkingHours = int.Parse(Console.ReadLine());
                    emp4.NetSalary = emp4.SalaryPerHour * emp4.NoOfWorkingHours;
                    Console.Clear();
                    Console.WriteLine("Employee " + i + " details: ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Id: " + emp4.EmpID);
                    Console.WriteLine("EmpName: " + emp4.EmpName);
                    Console.WriteLine("SalaryPerHour: " + emp4.SalaryPerHour);
                    Console.WriteLine("NoOfWorkingHours: " + emp4.NoOfWorkingHours);
                    Console.WriteLine("NetSalary : " + emp4.NetSalary);
                    Console.WriteLine("Do you want to continue to next employee");
                    choice = Console.ReadLine();
                    if (choice == "NO".ToLower())
                        break;
                   
                    Console.Clear();
                }
                if (i == 5)
                {
                    Employee emp5 = new Employee();
                    Console.WriteLine("Employee " + i + " Id: ");
                    emp5.EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " EmpName: ");
                    emp5.EmpName = Console.ReadLine();
                    Console.WriteLine("Employee " + i + " SalaryPerHour: ");
                    emp5.SalaryPerHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Employee " + i + " NoOfWorkingHours: ");
                    emp5.NoOfWorkingHours = int.Parse(Console.ReadLine());
                    emp5.NetSalary = emp5.SalaryPerHour * emp5.NoOfWorkingHours;
                    Console.Clear();
                    Console.WriteLine("Employee " + i + " details: ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Id: " + emp5.EmpID);
                    Console.WriteLine("EmpName: " + emp5.EmpName);
                    Console.WriteLine("SalaryPerHour: " + emp5.SalaryPerHour);
                    Console.WriteLine("NoOfWorkingHours: " + emp5.NoOfWorkingHours);
                    Console.WriteLine("NetSalary : " + emp5.NetSalary);
                    Console.Clear();
                }
            }

            Console.WriteLine("Thanks for all. Have a nice day");
            Console.ReadKey();
        }
    }
}
