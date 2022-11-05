using System;
using System.Collections.Generic;
using System.Linq;

namespace P._15._Drum_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> price = new List<int>();
            price.AddRange(drums);

            string command;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!" )
            {
                int hit = int.Parse(command);

                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hit;
                    if (drums[i] <= 0)
                    {
                        if ((budget - (price[i] * 3)) >= 0)
                        {
                            budget -= (price[i] * 3);
                            drums[i] = price[i];
                        }
                    }
                }

                for (int i = 0; i < drums.Count; i++)
                {
                    if (drums[i] <= 0)
                    {
                        drums.Remove(drums[i]);
                        price.Remove(price[i]);
                    }
                }
            }

            foreach (int drum in drums)
            {
                Console.Write(drum + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Gabsy has {budget:F2}lv.");
        }
    }
}
