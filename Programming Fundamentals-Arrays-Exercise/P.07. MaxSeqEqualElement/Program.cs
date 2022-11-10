using System;
using System.Linq;

namespace P._07._MaxSeqEqualElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            short counter = 1;
            short theMost = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > theMost)
                {
                    theMost = counter;
                    element = numbers[i];
                }
            }

            for (int i = 1; i <= theMost; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
