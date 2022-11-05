using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> bombNumandPower = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bombNum = bombNumandPower[0];
            int power = bombNumandPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    int start = i - power;
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int end = i + power;
                    if (end > numbers.Count)
                    {
                        end = numbers.Count - 1;
                    }

                    for (int j = start; j <= end; j++)
                    {
                        numbers.RemoveAt(start);
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
