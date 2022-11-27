using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, Plant> plants = new Dictionary<string, Plant> ();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plantName = info[0];
                int rarity = int.Parse(info[1]); 

                if (!plants.ContainsKey(plantName))
                {
                    Plant plant = new Plant
                    {
                        Rarity = rarity
                    };

                    plants.Add(plantName, plant);
                }

                plants[plantName].Rarity = rarity;
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command
                    .Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdName = cmdArgs[0];
                string plantName = cmdArgs[1];

                if (cmdName == "Rate")
                {
                    double rating = double.Parse(cmdArgs[2]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdName == "Update")
                {
                    int rarity = int.Parse(cmdArgs[2]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdName == "Reset")
                {
                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var kvp in plants)
            {
                if (kvp.Value.Rating.Count > 0)
                {
                    double average = kvp.Value.Rating.Average();
                    
                    Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value.Rarity}; Rating: {average:F2}");
                }
                else
                {
                    Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value.Rarity}; Rating: {0:F2}");
                }
            }
        }
    }

    class Plant
    {
        public Plant()
        {
            Rating = new List<double>();
        }

        public int Rarity { get; set; }

        public List<double> Rating { get; set; }
    }
}
