using System;
using System.Collections.Generic;
using System.Linq;

namespace P._08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    FixInvalidIndexes(word,ref startIndex,ref endIndex);

                    MergeWords(word, startIndex,endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);

                    string words = word[index];

                    List<string> partitionsList = DivideWord(words, partitions);

                    word.RemoveAt(index);
                    word.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(string.Join(" ", word));
        }

        static void FixInvalidIndexes(List<string> word, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= word.Count)
            {
                startIndex = word.Count - 1;
            }

            if (endIndex <= 0)
            {
                endIndex = 0;
            }

            if (endIndex >= word.Count)
            {
                endIndex = word.Count - 1;
            }
        }

        static void MergeWords(List<string> word, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = word[startIndex];
                mergedText += currWord;
                word.RemoveAt(startIndex);
            }

            word.Insert(startIndex, mergedText);
        }

        static List<string> DivideWord(string words, int partitions)
        {
            int substringLength = words.Length / partitions;
            int lastSubstringLength = words.Length - ((partitions - 1) * substringLength);

            List<string> partitionsList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                int desiredLngth = substringLength;
                if (i == partitions - 1)
                {
                    desiredLngth = lastSubstringLength;
                }
                char[] newPartitionArr = words
                    .Skip(i * substringLength)
                    .Take(desiredLngth)
                    .ToArray();

                string newPartition = string.Join("", newPartitionArr);

                partitionsList.Add(newPartition);
            }

            return partitionsList;
        }
    }
}
