using System;
using System.Linq;

namespace P._06._EvenOdd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                {
                    sumOdd += currNum;
                }
            }

            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
