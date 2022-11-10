using System;
using System.Linq;

namespace P._11._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            int [] field = new int[sizeField];

            int[] initialIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }


            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int ladyBugs = int.Parse(cmdArg[0]);
                string cdirection = cmdArg[1];
                int flyLength = int.Parse(cmdArg[2]);

                if (ladyBugs < 0 || ladyBugs >= field.Length)
                {
                    continue;
                }

                if (field[ladyBugs] == 0)
                {
                    continue;
                }

                field[ladyBugs] = 0;

                if (cdirection == "left")
                {
                    flyLength *= -1;
                }

                int nextIndex = ladyBugs + flyLength;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
