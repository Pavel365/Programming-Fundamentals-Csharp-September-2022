using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P._11._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersKeys = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int currPos = 0;
            string regex = @"&(?<type>.+)&[^<]*<(?<coord>.+)>";

            string command;
            while ((command = Console.ReadLine()) != "find")
            {
                int keyLength = numbersKeys.Count;
                int sequenceLength = command.Length;
                StringBuilder sb = new StringBuilder();

                for (int i = keyLength; i < sequenceLength; i++)
                {
                    numbersKeys.Add(numbersKeys[currPos]);
                    currPos++;
                }

                for (int i = 0; i < sequenceLength; i++)
                {
                    sb.Append((char)(command[i] - numbersKeys[i]));
                }

                Match m = Regex.Match(sb.ToString(), regex);

                if (m.Success)
                {
                    string type = m.Groups["type"].Value;
                    string coord = m.Groups["coord"].Value;
                    Console.WriteLine($"Found {type} at {coord}");
                }
            }
        }
    }
}
