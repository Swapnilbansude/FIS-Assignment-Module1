using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static List<Employee> EmployeeList;

        private static void AddEmployee()
        {
            var Employee = new Employee();
            Console.WriteLine("Enter the ID : ");
            Employee.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name : ");
            Employee.Name = Console.ReadLine();

            Console.WriteLine("Enter the Email : ");
            Employee.Email = Console.ReadLine();

            Console.WriteLine("Enter the Salary : ");
            Employee.Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Location : ");
            Employee.Location = Console.ReadLine();

            EmployeeList.Add(Employee);
            Console.WriteLine("Employee added successfully...");
        }

        private static void ListOfEmployees()
        {
            Console.WriteLine("\nId\tName\tEmail\tSalary\tLocation");
            foreach (var emp in EmployeeList)
            {
                Console.WriteLine( emp.ToString());
            }
        }

        private static void DeleteEmployee()
        {
            int IDToDelete = -1;
            bool flag = false;

            Console.WriteLine("Enter Id Of Employee to delete : ");
            IDToDelete = Convert.ToInt32(Console.ReadLine());

            foreach (var emp in EmployeeList)
            {
                if (IDToDelete == emp.ID)
                {
                    EmployeeList.Remove(emp);
                    flag = true;
                    Console.WriteLine("Employee deleted successfully...");
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Employee not found...");
            }
        }

        private static void SearchEmployee()
        {
            int IDToSearch = -1;
            bool flag = false;

            Console.WriteLine("Enter Id Of Employee to search : ");
            IDToSearch = Convert.ToInt32(Console.ReadLine());

            foreach (var emp in EmployeeList)
            {
                if (IDToSearch == emp.ID)
                {
                    flag = true;
                    Console.WriteLine("Employee found");
                    Console.WriteLine(emp.ToString());
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Employee not found...");
            }
        }

        private static void UpdateEmployee()
        {
            int IDToUpdate = -1;
            bool flag = false;

            Console.WriteLine("Enter Id Of Employee to update : ");
            IDToUpdate = Convert.ToInt32(Console.ReadLine());

            foreach (var emp in EmployeeList)
            {
                if (IDToUpdate == emp.ID)
                {
                    Console.WriteLine("Enter the new Name : ");
                    emp.Name = Console.ReadLine();

                    Console.WriteLine("Enter the new Email : ");
                    emp.Email = Console.ReadLine();

                    Console.WriteLine("Enter the new Salary : ");
                    emp.Salary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the new Location : ");
                    emp.Location = Console.ReadLine();

                    flag = true;
                    Console.WriteLine("Employee updated successfully...");
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Employee not found...");
            }
        }
        static void Main(string[] args)
        {
            EmployeeList = new List<Employee>();
            while (true)
            {
                Console.WriteLine("----Employee Management----");
                Console.WriteLine("\n1. Add Employee");
                Console.WriteLine("2. List All Employees");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Update an Employee");
                Console.WriteLine("5. Search an Employee By Id");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\nEnter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ListOfEmployees();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        SearchEmployee();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice...");
                        break;
                }

            }
        }
    }
}
