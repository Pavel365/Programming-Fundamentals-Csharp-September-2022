using System;
using System.Collections.Generic;
using System.Linq;

namespace P._09.OldFaMem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfMembers; i++)
            {
                family.AddMember(Console.ReadLine().Split());
            }

            Person oldest = family.GetOledestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
    public class Family
    {
        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public void AddMember(string[] memberInfo)
        {
            Person newMember = new Person(memberInfo[0], int.Parse(memberInfo[1]));

            this.FamilyMembers.Add(newMember);
        }

        public Person GetOledestMember()
        {
            return FamilyMembers.OrderByDescending(m => m.Age).First();
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        
    }
}
