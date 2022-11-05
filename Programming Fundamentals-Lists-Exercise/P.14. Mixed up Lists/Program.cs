using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace P._14._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> rule = new List<int>();
            List<int> maxList = new List<int>();
            List<int> mixedList = new List<int>();

            if (firstLine.Count > secondLine.Count)
            {
                maxList = firstLine;
            }
            else
            {
                maxList = secondLine;
                maxList.Reverse();
            }

            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                rule.Add(maxList[i]);
            }

            rule.Sort();

            if (firstLine.Count > secondLine.Count)
            {
                firstLine.RemoveRange(firstLine.Count - 2, 2);
                secondLine.Reverse();
            }
            else
            {
                secondLine.RemoveRange(secondLine.Count - 2, 2);
                secondLine.Reverse();
            }

            for (int i = 0; i < firstLine.Count; i++)
            {
                mixedList.Add(firstLine[i]);
                mixedList.Add(secondLine[i]);
            }

            List<int> output = mixedList.FindAll(x => x > rule[0] && x < rule[1]);

            output.Sort();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
