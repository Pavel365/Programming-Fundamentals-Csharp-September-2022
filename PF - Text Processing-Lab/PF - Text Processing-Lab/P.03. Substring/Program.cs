using System;

namespace P._03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(specialWord))
            {
                int startindex = text.IndexOf(specialWord);

                text = text.Remove(startindex, specialWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
