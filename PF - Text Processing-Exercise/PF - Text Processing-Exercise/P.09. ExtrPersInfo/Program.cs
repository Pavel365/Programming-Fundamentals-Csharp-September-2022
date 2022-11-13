using System;

namespace P._09._ExtrPersInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                int indexOfStartName = text.IndexOf('@');
                int indexofEndName = text.IndexOf('|');

                string name = text.Substring(indexOfStartName + 1,
                    indexofEndName - indexOfStartName - 1);

                int indexOfStartAge = text.IndexOf('#');
                int indexOfEndAge = text.IndexOf('*');

                string age = text.Substring(indexOfStartAge + 1,
                    indexOfEndAge - indexOfStartAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
