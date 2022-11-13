using System;
using System.Linq;

namespace P._03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string file = input[input.Length - 1];
            string[] lastWord = file
                .Split('.')
                .ToArray();

            Console.WriteLine($"File name: {lastWord[0]} ");
            Console.WriteLine($"File extension: {lastWord[1]}");
        }
    }
}
