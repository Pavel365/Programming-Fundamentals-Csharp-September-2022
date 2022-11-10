using System;
using System.Linq;

namespace P._04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotation = int.Parse(Console.ReadLine());

            int timesToRotate = rotation % numbers.Length;
            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstElement = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", numbers));
            

        }
    }
}
