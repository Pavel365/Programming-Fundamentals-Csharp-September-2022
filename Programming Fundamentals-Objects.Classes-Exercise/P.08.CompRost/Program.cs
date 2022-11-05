using System;
using System.Collections.Generic;
using System.Linq;

namespace P._08.CompRost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!departments.Any(d => d.DepartmentName == cmdArgs[2]))
                {
                    departments.Add(new Department(cmdArgs[2]));
                }

                departments.Find(d => d.DepartmentName == cmdArgs[2])
                    .AddNewEmployee(cmdArgs[0], decimal.Parse(cmdArgs[1]));
            }

            Department bestDepartment = departments
                .OrderByDescending(d => d.TotalSalaries / d.Employees.Count())
                .First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (Employee employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class Department
    {
        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string empName, decimal empSalary)
        {
            this.TotalSalaries += empSalary;

            this.Employees.Add(new Employee(empName, empSalary));
        }
    }
}
