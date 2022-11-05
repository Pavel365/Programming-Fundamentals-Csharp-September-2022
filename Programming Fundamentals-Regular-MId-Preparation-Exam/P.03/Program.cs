using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>  targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string comType = cmdArg[0];
                int index = int.Parse(cmdArg[1]);
                int value = int.Parse(cmdArg[2]);

                if (comType == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (comType == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (comType == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        targets.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
