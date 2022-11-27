using System;
using System.Text.RegularExpressions;

namespace P._06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            MatchCollection collection = Regex.Matches(input, pattern);

            foreach (Match item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
