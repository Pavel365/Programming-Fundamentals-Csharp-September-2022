using System;
using System.Linq;

namespace P._01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdName = cmdArgs[0];

                if (cmdName == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (cmdName == "Reverse")
                {
                    string substring = cmdArgs[1];

                    int substringIndex = message.IndexOf(substring);

                    if (substringIndex != -1)
                    {
                        message = message.Remove(substringIndex, substring.Length);
                        message += string.Join("", substring.Reverse());

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdName == "ChangeAll")
                {
                    string substr = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    message = message.Replace(substr, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
