using System;
using System.Linq;

namespace P._08.__LettChNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];

                string numAsAString = item[1..^1];

                double fromString = double.Parse(numAsAString);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    fromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    fromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    fromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    fromString += positionOfTheLetter;
                }

                sum += fromString;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
