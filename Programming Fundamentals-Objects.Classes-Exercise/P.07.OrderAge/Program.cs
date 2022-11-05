using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P._07.OrderAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string nameOfPerson = cmdArgs[0];
                string idOfPerson = cmdArgs[1];
                int agePerson = int.Parse(cmdArgs[2]);

                Person person = new Person(nameOfPerson,idOfPerson,agePerson);
                people.Add(person);
            }

            List<Person> sortedpeople = people
                .OrderBy(p => p.AgePerson)
                .ToList();

            foreach (Person person in sortedpeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.IdOfPerson} is {person.AgePerson} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string idOfPerson, int agePerson)
        {
            Name = name;
            IdOfPerson = idOfPerson;
            AgePerson = agePerson;
        }

        public string Name { get; set; }
        public string IdOfPerson { get; set; }
        public int AgePerson { get; set; }
    }
}
