using System;
using System.Text;

namespace P._04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char ch in input)
            {
                int currPosition = ch;
                currPosition += 3;

                sb.Append((char)currPosition);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
