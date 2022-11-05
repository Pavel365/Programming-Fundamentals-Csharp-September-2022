using System;

namespace P._04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daylyPlunder = int.Parse(Console.ReadLine());
            decimal expectPlunder = decimal.Parse(Console.ReadLine());

            decimal totalPlunder = 0m;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += daylyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder += 0.5m * daylyPlunder;
                }
                if (i % 5 == 0)
                {
                    totalPlunder -= 0.3m * totalPlunder;
                }
            }

            if (totalPlunder >= expectPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                decimal percentage = (totalPlunder/expectPlunder ) * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
