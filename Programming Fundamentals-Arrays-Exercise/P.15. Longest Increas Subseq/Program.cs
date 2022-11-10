using System;
using System.Linq;

namespace P._15._Longest_Increas_Subseq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] index = new int[numbers.Length];

            int maxIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && index[j] > index[i] - 1)
                    {
                        index[i] = index[j] + 1;
                        if (index[i] > index[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                }
            }

            Print(maxIndex, numbers, index);
        }
        static void Print(int maxIndex, int[] nums, int[] index)
        {
            bool isFirst = true;
            for (int i = 0; i < maxIndex; i++)
            {
                if (nums[i] < nums[maxIndex] && index[i] == index[maxIndex] - 1 && isFirst)
                {
                    isFirst = false;
                    Print(i, nums, index);
                }
            }

            Console.Write(nums[maxIndex] + " ");
        }
    }
}
