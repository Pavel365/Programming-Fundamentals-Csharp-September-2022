using System;
using System.Linq;

namespace P._14._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftFoldIndex = array.Length / 4 - 1;
            int rightFoldIndex = 3 * array.Length / 4;

            int[] topArray = new int[array.Length / 2];

            int howManyNumbersSoFar = 0;
            for (int i = leftFoldIndex; i >= 0; i--)
            {
                howManyNumbersSoFar++;
                topArray[leftFoldIndex - i] = array[i];
            }
            for (int i = array.Length - 1; i >= rightFoldIndex; i--)
            {
                topArray[array.Length - 1 - i + howManyNumbersSoFar] = array[i];
            }

            int[] bottomArr = new int[array.Length / 2];

            for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
            {
                bottomArr[i - howManyNumbersSoFar] = array[i];
            }

            for (int i = 0; i < topArray.Length; i++)
            {
                Console.Write(topArray[i] + bottomArr[i] + " ");
            }
        }
    }
}
