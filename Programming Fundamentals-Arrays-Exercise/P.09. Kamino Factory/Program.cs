using System;
using System.Linq;

namespace P._09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestSample = new int[n];

            int leftMostIndex = n;
            int bestSeqSampLenght = 0;
            int bestSampSum = 0;
            int bestSampNum = 1;

            int sampleNum = 0;

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currSample = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleNum++;

                int currentSequenceLenght = 0;
                int previousSequenceLenght = 0;
                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = n;
                int currentSampleSum = 0;

                for (int i = 0; i < currSample.Length; i++)
                {
                    if (currSample[i] == 1)
                    {
                        currentSequenceLenght++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;
                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        currentLongestSequence = currentSequenceLenght;
                        leftmostIndexInCurrentArray = i - currentSequenceLenght + 1;
                    }
                }

                if (currentLongestSequence > bestSeqSampLenght)
                {
                    bestSeqSampLenght = currentLongestSequence;
                    leftMostIndex = leftmostIndexInCurrentArray;
                    bestSample = currSample;
                    bestSampNum = sampleNum;
                    bestSampSum = currentSampleSum;
                }
                else if (currentLongestSequence == bestSeqSampLenght)
                {
                    if (leftmostIndexInCurrentArray < leftMostIndex)
                    {
                        leftMostIndex = leftmostIndexInCurrentArray;
                        bestSampSum = currentSampleSum;
                        bestSample = currSample;
                        bestSampNum = sampleNum;
                    }
                    else if (leftMostIndex == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSampSum)
                        {
                            bestSampSum = currentSampleSum;
                            bestSample = currSample;
                            bestSampNum = sampleNum;
                        }
                    }

                }

            }

            Console.WriteLine($"Best DNA sample {bestSampNum} with sum: {bestSampSum}.");
            Console.WriteLine(string.Join(" ", bestSample));
        }
    }
}
