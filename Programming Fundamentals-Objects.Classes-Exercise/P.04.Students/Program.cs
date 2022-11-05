using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace P._04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] cmdArgs = Console.ReadLine().
                    Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = cmdArgs[0];
                string lasName = cmdArgs[1];
                decimal grade = decimal.Parse(cmdArgs[2]);

                Student student = new Student(firstName, lasName, grade);
                
                students.Add(student);
            }

            List<Student> orderedstudents = students
                .OrderByDescending(student => student.Grade)
                .ToList();

            foreach (Student student1 in orderedstudents)
            {
                Console.WriteLine($"{student1.FirstName} {student1.LastName}: {student1.Grade:F2}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal Grade { get; private set; }
    }
}


