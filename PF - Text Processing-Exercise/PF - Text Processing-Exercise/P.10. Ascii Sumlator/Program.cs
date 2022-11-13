using System;

namespace P._10._Ascii_Sumlator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            int start = Math.Min(firstChar, secondChar);
            int end = Math.Max(firstChar, secondChar);

            for (int i = 0; i < text.Length; i++)
            {
                int currentChar = text[i];

                if (currentChar > start && currentChar < end)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
