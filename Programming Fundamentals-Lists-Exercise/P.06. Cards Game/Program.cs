using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace P._06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> hand2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (hand1.Count > 0 && hand2.Count > 0)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.RemoveAt(0);
                    hand1.Add(hand2[0]);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] < hand2[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.RemoveAt(0);
                    hand2.Add(hand1[0]);
                    hand1.RemoveAt(0);
                }
                else if (hand1[0] == hand2[0])
                {
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
            }
            if (hand1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {hand2.Sum()}");
            }
            else if (hand2.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {hand1.Sum()}");
            }
        }
    }
}
