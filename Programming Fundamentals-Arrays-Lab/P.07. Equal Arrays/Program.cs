using System;
using System.Linq;

namespace P._07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isIdentic = false;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isIdentic = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else   
                {
                    isIdentic = true;
                    sum += firstArr[i];
                }
            }
            if (isIdentic)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            

        }
    }
}
