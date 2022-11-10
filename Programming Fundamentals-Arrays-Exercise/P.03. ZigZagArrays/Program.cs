using System;
using System.Linq;

namespace P._03._ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int [] firsArray = new int[n];
            int [] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int [] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firsArray[i] = numbers[0];
                    secondArray [i] = numbers[1];
                }
                else
                {
                    firsArray [i] = numbers[1];
                    secondArray [i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ",firsArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
