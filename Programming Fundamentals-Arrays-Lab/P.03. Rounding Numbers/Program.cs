using System;
using System.Linq;

namespace P._03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i]} => {(int)Math.Round(num[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
