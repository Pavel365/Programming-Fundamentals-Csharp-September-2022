using System;
using System.Collections.Generic;
using System.Linq;

namespace P._12._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int middleEl = times.Count / 2;

            double sum1 = 0;
            for (int i = 0; i < middleEl; i++)
            {
                if (times[i] == 0)
                {
                    double currSum = sum1 - (sum1 * 0.20);
                    sum1 = currSum;
                    continue;
                }

                sum1 += times[i];
            }

            double sum2 = 0;
            for (int i = times.Count - 1; i >= middleEl + 1; i--)
            {
                if (times[i] == 0)
                {
                    double currSum = sum2 - (sum2 * 0.20);
                    sum2 = currSum;
                    continue;
                }

                sum2 += times[i];
            }

            if (sum1 < sum2)
            {
                Console.WriteLine($"The winner is left with total time: {sum1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sum2}");
            }
        }
    }
}
