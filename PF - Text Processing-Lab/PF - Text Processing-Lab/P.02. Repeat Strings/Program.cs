using System;

namespace P._02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (string currWord in words)
            {
                for (int i = 0; i < currWord.Length; i++)
                {
                    result += currWord;
                }
            }

            Console.WriteLine(result);
        }
    }
}
