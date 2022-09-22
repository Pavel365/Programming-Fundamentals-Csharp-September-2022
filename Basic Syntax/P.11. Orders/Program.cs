using System;

namespace P._11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nOrders = int.Parse(Console.ReadLine());

            double tottalForCoffee = 0;

            double tottal = 0; 

            for (int i = 1; i <= nOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleNum = int.Parse(Console.ReadLine());

                tottalForCoffee = days * capsuleNum * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${tottalForCoffee:F2}");

                tottal += tottalForCoffee;
            }

            Console.WriteLine($"Total: ${tottal:F2}");
        }
    }
}
