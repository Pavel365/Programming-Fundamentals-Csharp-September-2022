using System;
using System.Collections.Generic;
using System.Linq;

namespace P._07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> array = new List<int>();

            List<int> finalList = new List<int>();

            for ( int i = arrays.Count - 1; i >= 0; i--)
            {
                array = arrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (int num in array)
                {
                    finalList.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
