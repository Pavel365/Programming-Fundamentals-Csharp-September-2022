using System;
using System.Linq;

namespace P._06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            bool isDifferent = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sumRight += numbers[j];
                }

                for (int k = 0; k < i; k++)
                {
                    sumLeft += numbers[k];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    return;
                }
                else if (sumRight != sumLeft)
                {
                    isDifferent = true;
                }
                sumLeft = 0;
                sumRight = 0;
            }

            if (isDifferent)
            {
                Console.WriteLine("no");
            }

            
        }
    }
}
