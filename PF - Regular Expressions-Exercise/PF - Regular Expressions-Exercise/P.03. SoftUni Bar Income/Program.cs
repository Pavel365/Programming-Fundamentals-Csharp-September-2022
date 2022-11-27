using System;
using System.Text.RegularExpressions;

namespace P._03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
            Regex rg = new Regex(pattern);

            double tottal = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = rg.Match(input);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);


                    double tottalPrice = count * price;
                    tottal += tottalPrice;

                    Console.WriteLine($"{customer}: {product} - {tottalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {tottal:F2}");
        }
    }
}
