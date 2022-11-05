using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P._02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            { 
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string typeOfCmd = cmdArg[0];
                if (typeOfCmd == "Delete")
                {
                    int element = int.Parse(cmdArg[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (typeOfCmd == "Insert")
                {
                    int element = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);
                    numbers.Insert(index, element);
                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
