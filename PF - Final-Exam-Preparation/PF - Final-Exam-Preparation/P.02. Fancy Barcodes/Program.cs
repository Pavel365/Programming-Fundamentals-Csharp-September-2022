using System;
using System.Text.RegularExpressions;

namespace P._02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            int n = int.Parse(Console.ReadLine());

            Regex barcodeRegex = new Regex(pattern);
            Regex prGrReg = new Regex(@"\d+");

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                Match match = barcodeRegex.Match(input);

                if (match.Success)
                {
                    MatchCollection prGrRegs = prGrReg.Matches(match.Value);

                    if (prGrRegs.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", prGrRegs)}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
