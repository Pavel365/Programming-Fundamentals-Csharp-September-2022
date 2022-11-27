using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P._10._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<name>[A-Za-z]+)([^-@!:>]+)?![G]!";

            int key = int.Parse(Console.ReadLine());

            List<string> kids = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
				string input = string.Empty;

				for (int i = 0; i < command.Length; i++)
				{
					char curr = command[i];

					if (char.IsDigit(curr))
					{
						int currAsNum = int.Parse(curr.ToString());
						currAsNum -= key;
						input += currAsNum;
					}
					else
					{
						int currAsNum = (int)curr;
						currAsNum -= key;
						char toAdd = (char)currAsNum;
						input += toAdd;
					}
				}

				if (Regex.IsMatch(input, pattern))
				{
					Match match = Regex.Match(input, pattern);

					string name = match.Groups["name"].Value;

					kids.Add(name);
				}
			}

			foreach (string name in kids)
			{
				Console.WriteLine(name);
			}
		
        }
    }
}
