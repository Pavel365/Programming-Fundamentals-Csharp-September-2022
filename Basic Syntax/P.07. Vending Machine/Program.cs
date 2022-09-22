using System;

namespace P._07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double tottalCoins = 0;
            string command = string.Empty;
            while (command != "Start")
            {
                command = Console.ReadLine();
                if (command == "Start")
                {
                    break;
                }

                double coins = double.Parse(command);
                tottalCoins += coins;

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    tottalCoins -= coins;
                }
                
            } 

            string command1 = string.Empty;
            while (command1 != "End")
            {
                command1 = Console.ReadLine();
                if (command1 == "End")
                {
                    break;
                }

                string typeProduct = command1;

                if (typeProduct == "Nuts" && tottalCoins > 0)
                {
                    if (tottalCoins >= 2)
                    {
                        Console.WriteLine("Purchased nuts");
                        tottalCoins -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (typeProduct == "Water" && tottalCoins > 0)
                {
                    if (tottalCoins >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        tottalCoins -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (typeProduct == "Crisps" && tottalCoins > 0)
                {
                    if (tottalCoins >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        tottalCoins -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (typeProduct == "Soda" && tottalCoins > 0)
                {
                    if (tottalCoins >= 0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        tottalCoins -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(typeProduct == "Coke" && tottalCoins > 0)
                {
                    if (tottalCoins >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        tottalCoins -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (typeProduct != "Coke" && typeProduct != "Soda" && typeProduct != "Crisps" && typeProduct != "Water" && typeProduct != "Nuts")
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {tottalCoins:F2}");
        }
    }
}
