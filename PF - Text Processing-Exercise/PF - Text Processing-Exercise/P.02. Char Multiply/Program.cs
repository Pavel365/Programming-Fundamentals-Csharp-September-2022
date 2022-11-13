using System;
using System.Linq;

namespace P._02._Char_Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            GetStringSum(words[0], words[1]);
        }

        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longesString = stringOne;

            if (longesString.Length < stringTwo.Length)
            {
                longesString = stringTwo;
            }

            for (int i = minLength; i < longesString.Length; i++)
            {
                sum += longesString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
