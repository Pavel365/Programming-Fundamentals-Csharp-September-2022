using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P._07._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ticket = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < ticket.Length; i++)
            {
                if (ticket[i].Length == 20)
                {
                    Match firstHalf = regex.Match(ticket[i].Substring(0, 10));
                    Match secondHalf = regex.Match(ticket[i].Substring(10));
                    int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

                    if (firstHalf.Success && secondHalf.Success)
                    {
                        string winFirstHalf = firstHalf.Value.Substring(0, minLength);
                        string winSecondHalf = secondHalf.Value.Substring(0, minLength);

                        if (winFirstHalf.Equals(winSecondHalf))
                        {
                            if (winFirstHalf.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
