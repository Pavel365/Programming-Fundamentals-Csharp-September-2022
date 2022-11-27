using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P._01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}$";

            List<string> boughtFurniture = new List<string>();
            double tottal = 0;

            Regex rg = new Regex(pattern);

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = rg.Match(input);

                if (match.Success)
                {
                    string furnutureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    boughtFurniture.Add(furnutureName);
                    tottal += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string name in boughtFurniture)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {tottal:F2}");
        }
    }
}
