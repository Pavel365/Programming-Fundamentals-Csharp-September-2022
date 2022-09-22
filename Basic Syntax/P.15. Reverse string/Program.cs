using System;

namespace P._15._Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string newName = string.Empty;

            for (int i = name.Length-1; i >= 0; i--)
            {
                char ch = name[i];
                newName += ch;
            }
            Console.WriteLine(newName);
        }
    }
}
