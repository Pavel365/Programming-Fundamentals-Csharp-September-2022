using System;

namespace P._14._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double money1 = money;
            double tottal = 0;

            string command = string.Empty;
            while (command != "Game Time")
            {
                command = Console.ReadLine();

                if (command == "Game Time")
                {
                    break;
                }

                string gameName = command;

                if (gameName == "OutFall 4")
                {
                    if (money1 < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 39.99;
                        money1 -= 39.99;
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (money1 < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 15.99;
                        money1 -= 15.99;
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (money1 < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 19.99;
                        money1 -= 19.99;
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (money1 < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 59.99;
                        money1 -= 59.99;
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (money1 < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 29.99;
                        money1 -= 29.99;
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (money1 < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                        tottal += 39.99;
                        money1 -= 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (money1 <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.Write($"Total spent: ${tottal:F2}. ");
            Console.WriteLine($"Remaining: ${(money - tottal):F2}");
        }
    }
}
