using System;
using System.Text.RegularExpressions;

namespace P._01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = Console.ReadLine();

            Regex rg = new Regex(pattern);
            MatchCollection matchCollection = rg.Matches(input);

            foreach (Match item in matchCollection)
            {
                Console.Write(item.Value + " ");
            }    

        }
    }
}
