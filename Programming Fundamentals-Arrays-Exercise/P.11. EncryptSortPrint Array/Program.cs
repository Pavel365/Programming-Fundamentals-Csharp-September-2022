using System;

namespace P._11._EncryptSortPrint_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            int sumVowels = 0;
            int sumConsonant = 0;
            int sum = 0;

            string vowels = "EeUuIiOoAa";
            int[] arrayOfSums = new int[n];

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                for (int j = 0; j < word.Length; j++)
                {
                    char currSymbol = word[j];

                    if (vowels.Contains(currSymbol))
                    {
                        sumVowels += currSymbol*word.Length;
                    }
                    else
                    {
                        sumConsonant += currSymbol/word.Length;
                    }
                }

                sum = sumVowels + sumConsonant;
                arrayOfSums[i] = sum;

                sum = 0;
                sumConsonant = 0;
                sumVowels = 0;
            }

            Array.Sort(arrayOfSums);
            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);
            }
        }
    }
}
