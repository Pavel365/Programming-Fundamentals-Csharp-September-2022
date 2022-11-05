using System;
using System.Collections.Generic;
using System.Linq;

namespace P._01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Add")
                {
                    int lastNum = int.Parse(cmdArg[1]);
                    wagons.Add(lastNum);
                }
                else
                {
                    
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(cmdArg[0]);
                        if (wagons[i]+passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
