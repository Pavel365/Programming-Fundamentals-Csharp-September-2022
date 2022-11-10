using System;
using System.Linq;

namespace P._02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] secondArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < secondArr.Length; i++)
            {
                string currElement = secondArr[i];
                string currElement1 = null;
                for (int j = 0; j < firstArr.Length; j++)
                {
                    currElement1 = firstArr[j];
                    if (currElement == currElement1)
                    {
                        Console.Write(currElement + " ");
                    }
                }
            }
        }
    }
}
