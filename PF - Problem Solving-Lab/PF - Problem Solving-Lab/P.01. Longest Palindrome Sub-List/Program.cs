using System;

namespace P._01._Longest_Palindrome_Sub_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            int maxLenght = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                maxLenght = Math.Max(maxLenght, Palindrome(i, i, letters));
            }

            for (int i = 0; i < letters.Length - 1; i++)
            {
                maxLenght = Math.Max(maxLenght, Palindrome(i, i + 1, letters));
            }

            Console.WriteLine(maxLenght);
        }

        static int Palindrome(int leftIndex, int rightIndex, string letters)
        {
            while (leftIndex >= 0 && rightIndex < letters.Length
                && letters[leftIndex] == letters[rightIndex])
            {
                leftIndex--;
                rightIndex++;
            }

            return rightIndex - leftIndex - 1;
        }
    }
}
