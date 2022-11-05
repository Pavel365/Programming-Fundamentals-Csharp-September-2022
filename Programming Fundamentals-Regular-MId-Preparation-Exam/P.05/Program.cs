using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P._05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArg[0];

                if (cmdType == "Loot")
                {
                    for (int i = 1; i < cmdArg.Length; i++)
                    {
                        if (!initialLoot.Contains(cmdArg[i]))
                        {
                            initialLoot.Insert(0, cmdArg[i]);
                        }
                    }
                }
                else if (cmdType == "Drop")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index >= 0 && index < initialLoot.Count)
                    {
                        string temp = initialLoot[index];
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(temp);
                    }
                }
                else if (cmdType == "Steal")
                {
                    int stealEl = int.Parse(cmdArg[1]);
                    List<string> staelEl = new List<string>();

                    if (stealEl >= initialLoot.Count)
                    {
                        for (int i = 0; i < initialLoot.Count; i++)
                        {
                            staelEl.Add(initialLoot[i]);
                        }
                        initialLoot.RemoveRange(0, initialLoot.Count);
                    }
                    else
                    {
                        for (int i = initialLoot.Count - stealEl; i < initialLoot.Count; i++)
                        {
                            staelEl.Add(initialLoot[i]);
                        }
                        initialLoot.RemoveRange(initialLoot.Count - stealEl, stealEl);
                    }
                    Console.WriteLine(string.Join(", ", staelEl));
                }
            }

            if (initialLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                decimal sum = 0;
                for (int i = 0; i < initialLoot.Count; i++)
                {
                    string currElement = initialLoot[i];

                    int currLength = currElement.Length;

                    sum += currLength;
                }

                decimal average = sum / initialLoot.Count;
                Console.WriteLine($"Average treasure gain: {average:F2} pirate credits.");
            }
        }
    }
}
