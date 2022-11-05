using System;
using System.Collections.Generic;
using System.Linq;

namespace P._04._List_Operations
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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commandType = cmdArg[0];

                if (commandType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArg[1]);
                    numbers.Add(numberToAdd);
                }
                else if (commandType == "Insert")
                {
                    int number = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);

                    if (ValidateIndexInList(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (commandType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArg[1]);

                    if (ValidateIndexInList(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(removeIndex);
                }
                else if (commandType == "Shift")
                {
                    string directions = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);

                    if (directions == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));

        }

        static bool ValidateIndexInList(List<int> numbers, int index)
         => index < 0 || index >= numbers.Count;


        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firtNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firtNum);
            }
        }

        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNum);
            }
        }
    }
}
