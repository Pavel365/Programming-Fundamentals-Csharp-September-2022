using System;

namespace P._01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string reversedString = string.Empty;
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedString += command[i];
                }

                Console.WriteLine($"{command} = {reversedString}");
            }
        }
    }
}
