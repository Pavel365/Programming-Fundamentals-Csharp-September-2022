using System;

namespace P._01.Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal quantityFood = decimal.Parse(Console.ReadLine());
            decimal quantityHay = decimal.Parse(Console.ReadLine());
            decimal quantityCover = decimal.Parse(Console.ReadLine());
            decimal weigth = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                quantityFood -= 0.300m;

                if (i % 2 == 0)
                {
                    quantityHay -= quantityFood * 0.05m;
                }

                if (i % 3 == 0)
                {
                    quantityCover -= weigth / 3;
                }

                if (quantityFood <= 0 || quantityHay <= 0 || quantityCover <= 0)
                {
                    break;
                }
            }

            if (quantityFood <= 0 || quantityHay <= 0 || quantityCover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood:F2}, Hay: {quantityHay:F2}, Cover: {quantityCover:F2}.");
            }
        }
    }
}
