using System;

namespace P._01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] peopleInWagons = new int[n];
            int sumPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumPeople += people;

                peopleInWagons[i] = people;
            }

            foreach (int peoples in peopleInWagons)
            {
                Console.Write(peoples + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPeople);
        }
    }
}
