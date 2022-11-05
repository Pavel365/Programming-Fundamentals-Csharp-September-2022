using System;
using System.Linq;

namespace P._08.__Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            while (array.Length-1 > 0)
            {
                int[] condensed = new int[array.Length-1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                }
                array = condensed;
            }

            Console.WriteLine(array[0]);
        }
    }
}
