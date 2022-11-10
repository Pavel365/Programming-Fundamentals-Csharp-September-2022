using System;
using System.Linq;

namespace P._04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bandedWords = Console.ReadLine()
                .Split(", " , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            foreach (string currBandWord in bandedWords)
            {
                text = text.Replace(currBandWord, new string('*' , currBandWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
