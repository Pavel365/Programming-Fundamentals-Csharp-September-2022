using System;

namespace P._04._ReverseArrayStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split(" ");

            string[] newStr = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                newStr[i] = str[str.Length - i - 1];
            }
            Console.WriteLine(string.Join(" ", newStr));
        }
    }
}
