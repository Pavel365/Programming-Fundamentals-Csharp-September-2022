using System;
using System.Linq;

namespace P._08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            int currSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currNum = num[i];
                
                for (int j = i + 1; j < num.Length; j++)
                {
                    int currNum2 = num[j];
                    currSum = currNum + currNum2;

                    if (currSum == sum)
                    {
                        Console.WriteLine($"{currNum} {currNum2}");
                    }
                }
            }
        }
    }
}
