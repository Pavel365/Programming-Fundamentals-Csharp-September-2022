using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P._02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> racers = new Dictionary<string, int>();


            string patternName = @"(?<name>[A-Za-z]+)";
            string patternDistance = @"(?<distance>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;
                string distance = string.Empty;

                Regex regexName = new Regex(patternName);
                Regex regexDistance = new Regex(patternDistance);

                MatchCollection matchesName = regexName.Matches(input);
                MatchCollection matchesDistance = regexDistance.Matches(input);

                foreach (Match item in matchesName)
                {
                    name += item.Groups[1].Value;
                }

                foreach (Match item in matchesDistance)
                {
                    distance += item.Groups[1].Value;
                }

                int sumDistance = distance.Sum(x => int.Parse(x.ToString()));

                if (!racers.ContainsKey(name))
                {

                    if (names.Contains(name))
                    {
                        racers.Add(name, sumDistance);
                    }
                }
                else if (racers.ContainsKey(name))
                {
                    if (names.Contains(name))
                    {
                        racers[name] += sumDistance;
                    }
                }
            }

            int counter = 0;
            foreach (var item in racers.OrderByDescending(x => x.Value))
            {
                counter++;

                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }

                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }

                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }
        }
    }
}
