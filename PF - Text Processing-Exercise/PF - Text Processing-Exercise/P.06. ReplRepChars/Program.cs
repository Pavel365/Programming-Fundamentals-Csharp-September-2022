using System;

namespace P._06._ReplRepChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char previousChar = input[0];

            Console.Write(previousChar);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != previousChar)
                {
                    previousChar = input[i];
                    Console.Write(previousChar);
                }
            }
        }
    }
}
