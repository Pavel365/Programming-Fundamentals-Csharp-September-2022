using System;
using System.Linq;

namespace P._01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string name in usernames)
            {
                if (name.Length > 3 && name.Length <= 16)
                {
                    bool isNameValid = true;

                    foreach (char ch in name)
                    {
                        if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                        {
                            isNameValid = false;
                            break;
                        }
                    }

                    if (isNameValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

        }
    }
}
