using System;
using System.Collections.Generic;
using System.Linq;

namespace P._11._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string sentence = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                int indexes = CalculationIndexes(currNum);

                char currCh = GettingChar(indexes, sentence);
                Console.Write(currCh);

                int newIndexes = CalculateNewIndex(indexes, sentence);
                string newStr = sentence.Remove(newIndexes, 1);
                sentence = newStr;
            }
        }

        static int CalculationIndexes(int number)
        {
            int sumIndex = 0;
            while (number > 0)
            {
                int curr = number % 10;
                sumIndex += curr;
                number /= 10;
            }

            return sumIndex;
        }

        static char GettingChar(int index, string senetemce)
        {
            int countIndexes = 0;
            for (int i = 0; i < index; i++)
            {
                countIndexes++;

                if (countIndexes == senetemce.Length)
                {
                    countIndexes = 0;
                }
            }

            char curCh = senetemce[countIndexes];
            return curCh;
        }

        static int CalculateNewIndex(int index, string sentence)
        {
            int countIndexes = 0;
            for (int i = 0; i < index; i++)
            {
                countIndexes++;

                if (countIndexes == sentence.Length)
                {
                    countIndexes = 0;
                }
            }

            return countIndexes;
        }
    }
}
