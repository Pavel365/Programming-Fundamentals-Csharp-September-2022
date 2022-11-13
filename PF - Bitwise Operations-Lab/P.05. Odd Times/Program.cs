using System;
using System.Linq;

namespace P._05._Odd_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = result ^ numbers[i];
            }

            Console.WriteLine(result);
        }
    }
}
