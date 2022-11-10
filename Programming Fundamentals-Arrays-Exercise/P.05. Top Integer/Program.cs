using System;
using System.Linq;

namespace P._05._Top_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNUm = numbers[i];

                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nexNum = numbers[j];
                    if (nexNum >=  currNUm)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNUm + " ");
                }
            }

        }
    }
}
